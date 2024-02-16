using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Hosting;
using Estimator.Data;
using Estimator.Models;
using Estimator.Helpers;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Estimator.Models.AsuViews;
using Estimator.Migrations;

namespace Estimator.Pages.CustomerRequests

{
  
    public class ImportModel : Estimator.Pages.BaseEstimatorPage
    {

        public string ErrorMessage;
        public ImportModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {
            
            ErrorMessage = "";
            ImportStep = 1;

        }
        /// <summary>
        /// 1- загрузка файла,2- обработка данных,3- загрузка данных в базу
        /// </summary>
        public int ImportStep { get; set; }
        public string StepName
        {
            get
            {
                switch (ImportStep)
                {
                    case 1:
                        return "Этап 1: загрузка перечня из xlsx файла.";
                    case 2:
                        return "Этап 2: обработка полученных данных.";
                    case 3:
                        return "Этап 3: Вывод результата обработки загруженных данных.";
                    default:
                        break;
                }
                return "";
            }
        }

        public async Task<IActionResult> OnGetAsync(int? id, int? step)
        {
            if (id == null)
            {
                return NotFound();
            }

            //установка шага 1 если  шаг не задан
            ImportStep = step == null ? 1 : step.Value;

             ElementImport = await _context.ElementImports
                .Include(e => e.XLSXElementTypes)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.CustomerRequest.CustomerRequestID == id);

            //если шаг не задан
            if (step == null)
            {
                if (ElementImport?.XLSXElementTypes?.Count > 0) { ImportStep = 2; }
                else { ImportStep = 1; }
            }
           if (ElementImport?.XLSXElementTypes?.Count > 0 && ImportStep==1)
            {
                //если пытаемся заного загрузить файл,  когда уже 1 раз загрузили
                ErrorMessage = "Если вы загрузите новый файл, старые значения будут стерты!";
            }
            //не нашли такого файла импорта
            if (ElementImport == null)
            {
                ElementImport = new ElementImport
                {
                    XLSXElementTypes = new List<XLSXElementType>(),
                    CustomerRequestID = id.Value
                };

                ElementImport.CustomerRequest =  await _context.CustomerRequests
                                                        .Include(c => c.Customer)
                                                        .Include(c => c.Program)
                                                            .ThenInclude(c => c.ElementntTypes)
                                                                .ThenInclude (c=>c.Keys)
                                                      .FirstOrDefaultAsync(m => m.CustomerRequestID == id);
                
                ElementImport.CustomerRequestID = (int)id;

                    }
            else
            {
               
                if (ValidateXLSX(false))
                {
                    ElementImport.XLSXElementTypes = ElementImport.XLSXElementTypes.OrderBy(e => e.RowNum ).ToList();
                }
                else
                {
                    ElementImport.XLSXElementTypes = ElementImport.XLSXElementTypes.OrderBy(e => e.Valid).ToList();
                }
            }

            return Page();
        }

        [BindProperty]
        public ElementImport ElementImport { get; set; }
        public async Task<IActionResult> OnPostAsync(IFormFile uploadedFile, int step, XLSXElementType[] elementTypes)

        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           
            //установка этапа
            ImportStep = step;

            ElementImport.CustomerRequest = _context.CustomerRequests
                                                .Include(c => c.Customer)
                                                .Include(c => c.Program)
                                                    .ThenInclude(c => c.ElementntTypes)
            .ThenInclude(c => c.Keys)
                                              .FirstOrDefault(m => m.CustomerRequestID == ElementImport.CustomerRequestID);

            if (ImportStep == 1)
            {
                try
                {

                    if (ElementImport.ElementImportID == 0)
                    {
                        _context.ElementImports.Add(ElementImport);
                    }
                    else
                    {
                        _context.Attach(ElementImport).State = EntityState.Modified;
                    }
                    if (uploadedFile != null)
                    {
                        //очищаем элементы,  мы загружаем их заного
                        if (ElementImport.XLSXElementTypes != null)
                        {
                            ElementImport.XLSXElementTypes.Clear();
                            
                        }
                        await _context.SaveChangesAsync();

                        string ext = uploadedFile.FileName.ToLower();
                        //вычисляем расширение
                        ext = ext.Substring(ext.Length - 4, 4);
                        if (ext == "xlsx")
                        {
                            XLSXhelper xhelper = new XLSXhelper();
                            //сохраняем  файл на сервере 
                            using (var fileStream = new FileStream(FilePath, FileMode.Create))
                            {
                                await uploadedFile.CopyToAsync(fileStream);
                            }
                            //запоминаем что файл загружен 
                            ElementImport.FileUploaded = true;

                          
                            bool convertResult;
                            string convertMessage;
                            //загружаем файлы их экселя
                            ElementImport.XLSXElementTypes = xhelper.Convert(uploadedFile.OpenReadStream(), ElementImport, out convertResult,out convertMessage );
                            
                            if (convertResult)
                            {
                                ImportStep += 1;

                                await _context.SaveChangesAsync();
                            }
                            else
                            {
                                ErrorMessage = convertMessage;
                                return Page();
                            }
                        }
                        else
                        {
                            ErrorMessage = "Можно загружать файлы только в формате xslx. Другой форман файлов невозможен.";
                            return Page(); 
                        }

                    }
                    else
                    {
                        //на шаге 1 файл не зегружен
                        ErrorMessage = "Вы не загрузили файл! ";
                        return Page();
                       

                    }

                    //Пытаемся сохранить свойства импорта


                    if (ValidateXLSX(true))
                    {
                        ElementImport.XLSXElementTypes = ElementImport.XLSXElementTypes.OrderBy(e => e.RowNum).ToList();
                    }
                    else
                    {
                        ElementImport.XLSXElementTypes = ElementImport.XLSXElementTypes.OrderBy(e => e.Valid).ToList();
                    }
                    //запоминаем кто отредактировать заявку
                    ElementImport.CustomerRequest.ModificateDate = System.DateTime.Now;
                    ElementImport.CustomerRequest.UseImport = true;


                    if (UserID > 0)
                    {
                        ElementImport.CustomerRequest.LastModificateUserID = UserID;
                    }

                    await _context.SaveChangesAsync();
                      
                if (ValidateXLSX(false))
                {
                    ElementImport.XLSXElementTypes = ElementImport.XLSXElementTypes.OrderBy(e => e.RowNum ).ToList();
                }
                else
                {
                    ElementImport.XLSXElementTypes = ElementImport.XLSXElementTypes.OrderBy(e => e.Valid).ToList();
                }
                    return Page();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ElementImportExists(ElementImport.ElementImportID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        return Page();
                    }
                }

                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                    return Page();
                }
            }
            else if (ImportStep == 2)
            {
                ElementImport.CustomerRequest.ModificateDate = System.DateTime.Now; if (UserID > 0)
                {
                    ElementImport.CustomerRequest.LastModificateUserID = UserID;
                }
                await _context.SaveChangesAsync();
                ValidateXLSX(true);
                return RedirectToPage("Import", new { id = ElementImport.CustomerRequestID, step = 2 });

            }

            return Page();


        }

        public string FilePath
        {
            get
            {
                return _appEnvironment.WebRootPath + "/Files/" + ElementImport.CustomerRequestID.ToString() + ".xlsx";
            }
        }

        private bool ValidateXLSX(bool saveChanges)
        {
            //получаем коллекцию ключей
            Dictionary<string, ElementType> keys = new Dictionary<string, ElementType>();



            ElementImport.CustomerRequest = _context.CustomerRequests
                                .Include(e => e.Customer)
                                .Include(m => m.Program)
                                    .ThenInclude(e => e.ElementntTypes)
                                        .ThenInclude(e => e.Keys)
                                .FirstOrDefault(e => e.CustomerRequestID == ElementImport.CustomerRequestID);


            //заполняем коллецию ключей
            foreach (var itemET in ElementImport.CustomerRequest.Program.ElementntTypes)
            {
                foreach (var itemKey in itemET.Keys)
                {
                    keys.Add(itemKey.Key, itemET );
                }
            }

            //функция возвращает true  только когда все элементы валидны;
            bool returnValue = true;

            // 
            if (ElementImport.XLSXElementTypes == null)
            {
                return false; 
            }
            int rowNumber = 1;
            //перебираем все загрузки
            foreach (var itemXLSX in ElementImport.XLSXElementTypes)
            {
                itemXLSX.Valid = false;
                itemXLSX.ErrorMessage = "";

                itemXLSX.ElementName ??= "";
                itemXLSX.ElementTypeKey ??= "";
                //удаление вычеркнутого элемента
                if (!itemXLSX.InList & saveChanges)
                {
                    _context.Attach(itemXLSX).State = EntityState.Deleted;
                    XLSXElementType item = _context.XLSXElementTypes.FirstOrDefault(m => m.ID == itemXLSX.ID);
                    continue;
                }

                //нет имени - не загружаем
                if (PrepareStr(itemXLSX.ElementName) == "")
                {
                    itemXLSX.ErrorMessage = "Имя элемента не заполнено";
                    returnValue = false;
                    continue;
                }
                // если ключ не пустой

                if (PrepareStr(itemXLSX.ElementTypeKey) != "")
                {
                    // ищем в коллекции ключей
                    foreach (var key in keys)
                    {
                        if (PrepareStr(itemXLSX.ElementTypeKey) == PrepareStr(key.Key))
                        {

                            itemXLSX.ElementTypeID = keys[key.Key].ElementTypeID;
                            itemXLSX.ErrorMessage = "";
                            itemXLSX.Valid = true;
                            itemXLSX.ElementTypeName = keys[key.Key].Name;
                            break;
                        }

                    }
                }
                //пустое место вместо ключа или ключ не нашли на предыдущем этапе 
                if (PrepareStr(itemXLSX.ElementTypeKey) == "" | itemXLSX.ElementTypeID == null)
                {
                    //здесь пытаемся найти ключ в поле ElementName
                 
                    foreach (var key in keys)
                    {
                        if (PrepareStr(itemXLSX.ElementName).IndexOf(PrepareStr(key.Key))>=0)
                        {
                            
                            itemXLSX.ElementTypeKey= key.Key;
                            itemXLSX.ElementTypeID = keys[key.Key].ElementTypeID;
                            itemXLSX.ElementTypeName = keys[key.Key].Name;
                            itemXLSX.ErrorMessage = "";
                            itemXLSX.Valid = true;
                            break;
                        }
 
                    }
                   
                }
                XLSXElementType beforeItem = null;
                //или ключ не найден  или искать в предыдущем импорте
                if ((PrepareStr(itemXLSX.ElementTypeKey) == "") | this.ElementImport.UseLastCalculation)
                {
                    beforeItem = BeforeUploadedXLSXElementType(itemXLSX.ElementName, itemXLSX.ID, ElementImport.CustomerRequest.TestProgramID);
                    //Если предыдущий типономина  найден и ему присвоен тип
                    if (((beforeItem != null ? beforeItem.ElementTypeID : 0) > 0))
                    {
                        itemXLSX.ElementTypeID = beforeItem.ElementTypeID;
                        itemXLSX.ElementTypeKey = beforeItem.ElementTypeKey;
                        itemXLSX.ErrorMessage = "";
                        itemXLSX.Valid = true;
                        itemXLSX.BeforeUploadedXLSXElementTypeID = beforeItem.ID;
                        itemXLSX.ElementTypeName = ElementImport.CustomerRequest.Program.ElementntTypes.FirstOrDefault(m => m.ElementTypeID == itemXLSX.ElementTypeID).Name ?? "";
                    }
                }

                //ключ всетаки не найден после всех  попыток
                if (PrepareStr(itemXLSX.ElementTypeKey) == "")
                {
                    itemXLSX.ErrorMessage = "Ключ для элемента не заполнен.";
                    returnValue = false;
                    continue;
                }
                //присваеваем номер строки в эксель там где он не присвоем(до изменения где номер строки добавляется при импорте)
                if (itemXLSX.RowNum == null) 
                { 
                    itemXLSX.RowNum = rowNumber; 
                }

                rowNumber++;

                if (itemXLSX.ElementTypeID > 0)
                {
                    //Ищем такой элемент в ASU, если надо
                    bool checkElemenTypeInAsu = ElementImport.CustomerRequest.Program.ElementntTypes.FirstOrDefault(m => m.ElementTypeID == itemXLSX.ElementTypeID).CheckInAsu;
                    
                    if (UseAsu & itemXLSX.Valid & checkElemenTypeInAsu)
                    {
                        string protokolName = LastAsuProtokolNumber(itemXLSX.ElementName);
                        if (!String.IsNullOrWhiteSpace(protokolName))
                        {
                            itemXLSX.AsuProtokolCode = protokolName;
                        }
                    }
                }
                if (!itemXLSX.Valid)
                {
                    itemXLSX.ErrorMessage = "Ключ не найден.";
                    returnValue = false;
                }
                if (saveChanges)
                {
                    XLSXElementType item = _context.XLSXElementTypes.FirstOrDefault(m => m.ID == itemXLSX.ID);
                  
                    if (item != null)
                    {
                        item.ElementTypeKey = itemXLSX.ElementTypeKey ?? "";
                        item.ElementName = itemXLSX.ElementName ?? "";
                        item.ElementCount = itemXLSX.ElementCount;
                        item.ElementTypeID = itemXLSX.ElementTypeID;
                        if (item.RowNum == null)
                        {
                            item.RowNum = itemXLSX.RowNum;
                        }
                        item.BeforeUploadedXLSXElementTypeID = itemXLSX.BeforeUploadedXLSXElementTypeID;
                        _context.Entry(item).State = EntityState.Modified;

                        _context.SaveChanges();
                    }

                    }
                
            }
         
                if (returnValue )
            {
                FillELementTypes();
            }
            return returnValue;
        }
        private bool ElementImportExists(int id)
        {
            return _context.ElementImports.Any(e => e.ElementImportID == id);
        }
   
        private void FillELementTypes()
        {
            //подгружаем типа элементов для заявки
            ElementImport.CustomerRequest.RequestElementTypes = _context.RequestElementTypes.Where(e => e.CustomerRequestID == ElementImport.CustomerRequestID).ToList();
            if (ElementImport.CustomerRequest.RequestElementTypes != null)
            {
                foreach (var itemRet in ElementImport.CustomerRequest.RequestElementTypes)
                {
                    itemRet.ItemCount = 0;
                    itemRet.KitCount = 0;
                    itemRet.BatchCount = 0;

                    foreach (var itemX in ElementImport.XLSXElementTypes)
                    {
                        if (itemRet.ElementTypeID == itemX.ElementTypeID)
                        {
                            itemRet.BatchCount++;
                            itemRet.ItemCount += itemX.ElementCount;
                            itemRet.KitCount++;

                            if (itemX.IsAsuProtokolExists)
                            {
                                //такой тип найден- вычитаем оснастку
                                itemRet.KitCount --;
                            }
                        }
                    }
                }
            }
            _context.SaveChanges();
        }

        private string LastAsuProtokolNumber (string elementName)
            
        {
            try
            {
                SetAsuContext();
                string query = "select  l.LotID as ID, w.TypeNominal," +
                    "l.PrefixNumber + '-' + CAST(l.Number AS VARCHAR(32)) + (CASE WHEN(l.SuffixNumber IS NULL) THEN('') ELSE l.SuffixNumber END) AS [ProtokolNumber] " +
                     "from Wares w, Lot l where w.WareId = l.WareId and UPPER(LTRIM(RTRIM(w.TypeNominal))) = {0} " +
                     "order by l.LotId Desc";
                List<TestedType> list = _asuContext.TestedTypes.FromSqlRaw(query, PrepareStr(elementName)).ToList();

                if (list != null)
                {
                    return list.Count > 0 ? list[0].ProtokolNumber : "";
                }
                else
                { return ""; }
            }
            catch (Exception e)
            {
               
                return e.Message;
            }
        }

     
        /// <summary>
        /// Проверяет загружали ли ли такой элемент ранее,  если да то ElementType  берется из ранее загруженного элемента
        /// </summary>
        /// <returns></returns>
        private XLSXElementType BeforeUploadedXLSXElementType(string elementName, int id, int programid)
        {
            string selectStr= "SELECT [ID] ,[RowNum],[ElementImportID] ,[ElementName] ,[ElementTypeKey]" +
            ",[ElementCount] ,e.[ElementTypeID] ,[AsuProtokolCode] ,[ElementPrice],[BeforeUploadedXLSXElementTypeID],[ElementContractorPrice],[ElementKitPrice],"+
            "[DeliveryTime],[Datasheet],[ImportedQualificationLevel] " +
            "FROM [XLSXElementType] x, ElementType e where e.ElementTypeID=x.ElementTypeID and  RTRIM(LTRIM(UPPER(replace(ElementName,' ','')))) ={0} and ID <> {1} " + 
            " AND  e.ProgramID = {2}";
           
            List<XLSXElementType> list = _context.XLSXElementTypes.FromSqlRaw(selectStr, PrepareStr(elementName),id,programid).ToList();

            return list.Count > 0 ? list[0] : null;
        

        }
    }
}