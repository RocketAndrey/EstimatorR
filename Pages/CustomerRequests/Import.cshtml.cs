using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using Estimator.Data;
using Estimator.Models;
using Estimator.Helpers;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Estimator.Models.AsuViews;
using DocumentFormat.OpenXml.Office.CustomUI;

namespace Estimator.Pages.CustomerRequests
{
    public class ImportModel : Estimator.Pages.BaseEstimatorPage
    {

        public string ErrorMessage;
        private AsuContext _asuContext;
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

            ElementImport = _context.ElementImports
                   .FirstOrDefault(m => m.CustomerRequest.CustomerRequestID == id);

            //не нашли такого файла импорта
            if (ElementImport == null)
            {
                ElementImport = new ElementImport
                {
                    XLSXElementTypes = new List<XLSXElementType>(),
                    CustomerRequestID = id.Value
                };

                ElementImport.CustomerRequest = _context.CustomerRequests
                                                        .Include(c => c.Customer)
                                                        .Include(c => c.Program)
                                                            .ThenInclude(c => c.ElementntTypes)
                                                                .ThenInclude (c=>c.Keys)
                                                      .FirstOrDefault(m => m.CustomerRequestID == id);
            }
            else
            {

                ElementImport = _context.ElementImports
                    .Include(e => e.XLSXElementTypes)
                   .FirstOrDefault(m => m.CustomerRequest.CustomerRequestID == id);



                if (ValidateXLSX(false))
                {
                    if (ImportStep != -1)
                    {
                        ImportStep = 3;
                        FillELementTypes();
                    }
                    else
                    {
                        ImportStep = 1;
                        //если пытаемся заного загрузить файл,  когда уже 1 раз загрузили
                        if (ElementImport.XLSXElementTypes != null)

                        {
                            if (ElementImport.XLSXElementTypes.Count > 0)
                            {
                                ErrorMessage = "Если вы загрузите новый файл, старые значения будут стерты!";
                            }

                        }
                    }
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
        public async Task<IActionResult> OnPostAsync(IFormFile? uploadedFile, int step, XLSXElementType[] elementTypes)

        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //установка этапа
            ImportStep = step;

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
                            //очищаем элементы,  мы загружаем их заного
                            if (ElementImport.XLSXElementTypes != null)
                            {
                                ElementImport.XLSXElementTypes.Clear();
                            }
                            //загружаем файлы их экселя
                            ElementImport.XLSXElementTypes = xhelper.Convert(uploadedFile.OpenReadStream(), ElementImport);
                            ImportStep += 1;

                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            ErrorMessage = "Можно загружать файлы только в формате xslx. Другой форман файлов невозможен.";
                        }

                    }
                    else
                    {
                        //на шаге 1 файл не зегружен
                        ErrorMessage = "Вы не загрузили файл! ";
                        //если пытаемся заного загрузить файл,  когда уже 1 раз загрузили
                        if (ElementImport.XLSXElementTypes != null)

                        {
                            if (ElementImport.XLSXElementTypes.Count > 0)
                            {
                                ErrorMessage = "Если вы загрузите новый файл, старые значения будут стерты!";
                            }
                        }

                    }

                    //Пытаемся сохранить свойства импорта

                    ValidateXLSX(true);
                    //запоминаем кто отредактировать заявку
                    ElementImport.CustomerRequest.ModificateDate = System.DateTime.Now;

                    if (UserID > 0)
                    {
                        ElementImport.CustomerRequest.LastModificateUserID = UserID;
                    }

                    await _context.SaveChangesAsync();

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

                if (ValidateXLSX(true))
                {
                    FillELementTypes();
                }
                await _context.SaveChangesAsync();


            }

            return RedirectToPage("./import", new { id = ElementImport.CustomerRequestID, step = ImportStep });
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
            //перебираем все загрузки
            foreach (var itemXLSX in ElementImport.XLSXElementTypes)
            {
                itemXLSX.Valid = false;
                itemXLSX.ErrorMessage = "";

                itemXLSX.ElementName ??= "";
                itemXLSX.ElementTypeKey ??= "";

                if (!itemXLSX.InList & saveChanges)
                {
                    _context.Attach(itemXLSX).State = EntityState.Deleted;
                    XLSXElementType item = _context.XLSXElementTypes.FirstOrDefault(m => m.ID == itemXLSX.ID);
                    //ElementImport.XLSXElementTypes.Remove(itemXLSX);
                    continue;
                }

                //нет имени - не загружаем
                if (PrepareStr(itemXLSX.ElementName) == "")
                {
                    itemXLSX.ErrorMessage = "Имя элемента не заполнено";
                    returnValue = false;
                    continue;
                }
                if (PrepareStr(itemXLSX.ElementTypeKey) == "")
                {
                    itemXLSX.ErrorMessage = "Ключ для элемента не заполнен.";
                    returnValue = false;
                    continue;
                }
                XLSXElementType beforeItem = new XLSXElementType();
                beforeItem = BeforeUploadedXLSXElementType(itemXLSX.ElementName , itemXLSX.ID, ElementImport.CustomerRequest.TestProgramID );
                //Если предыдущий типономина найден и ему присвоен тип
                if (!((beforeItem!=null? beforeItem.ElementTypeID:0) > 0))
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
                else 
                {
                    // берем значения из ранее загруженного изделия
                    itemXLSX.ElementTypeID = beforeItem.ElementTypeID ;
                    itemXLSX.ElementTypeKey = beforeItem.ElementTypeKey;
                    itemXLSX.ErrorMessage = "";
                    itemXLSX.Valid = true;
                    itemXLSX.BeforeUploadedXLSXElementTypeID = beforeItem.ID;

                    itemXLSX.ElementTypeName = ElementImport.CustomerRequest.Program.ElementntTypes.FirstOrDefault(m => m.ElementTypeID == itemXLSX.ElementTypeID).Name??"";

                }
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
                    item.ElementTypeKey = itemXLSX.ElementTypeKey ?? "";
                    item.ElementName = itemXLSX.ElementName ?? "";
                    item.ElementCount = itemXLSX.ElementCount;
                    item.ElementTypeID = itemXLSX.ElementTypeID;
                    item.BeforeUploadedXLSXElementTypeID  = itemXLSX.BeforeUploadedXLSXElementTypeID;
                    _context.Entry(item).State = EntityState.Modified;
                }
            }
            return returnValue;
        }
        private bool ElementImportExists(int id)
        {
            return _context.ElementImports.Any(e => e.ElementImportID == id);
        }
        /// <summary>
        /// функция удалает из строки все пробелы и переводит в нижний регистр 
        /// </summary>
        /// <param name="value">Исходная строка</param>
        /// <returns></returns>
        private string PrepareStr(string value)
        {
            // новая строка для записи строки без пробелов
            string newstr = "";
            // цыкл
            for (int i = 0; i < value.Length; i++)
            {
                // если елемент i-ый елемент не пробел - пишем его в новую строку "newstr"
                if (value[i] != ' ')
                {
                    // - пишем его в новую строку "newstr"
                    newstr += value[i];
                }
            }
            return newstr.Trim().ToUpper();
        }

        private void FillELementTypes()
        {
            //подгружаем типв элемоенов для заявки
            ElementImport.CustomerRequest.RequestElementTypes = _context.RequestElementTypes.Where(e => e.CustomerRequestID == ElementImport.CustomerRequestID).ToList();
            if (ElementImport.CustomerRequest.RequestElementTypes != null)
            {
                foreach (var itemRet in ElementImport.CustomerRequest.RequestElementTypes)
                {
                    itemRet.ItemCount = 0;
                    //   itemRet.KitCount = 0;
                    itemRet.BatchCount = 0;
                    foreach (var itemX in ElementImport.XLSXElementTypes)
                    {
                        if (itemRet.ElementTypeID == itemX.ElementTypeID)
                        {
                            itemRet.BatchCount++;
                            itemRet.ItemCount += itemX.ElementCount;
                            if (!itemX.IsAsuProtokolExists)
                            {
                                itemRet.KitCount ++;
                            }
                        }
                    }
                }
            }
        }

        private string LastAsuProtokolNumber (string elementName)
        {
            SetAsuContext();
            string query = "select  l.LotID as TestedTypeID, w.TypeNominal," +
                "l.PrefixNumber + '-' + CAST(l.Number AS VARCHAR(32)) + (CASE WHEN(l.SuffixNumber IS NULL) THEN('') ELSE l.SuffixNumber END) AS [ProtokolNumber] "+
                 "from Wares w, Lot l where w.WareId = l.WareId and UPPER(LTRIM(RTRIM(w.TypeNominal))) = {0} "+
                 "order by l.LotId Desc";
            List<TestedType> list = _asuContext.TestedTypes.FromSqlRaw(query, PrepareStr(elementName)).ToList();
         
            if (list !=null)
            {
                return  list.Count > 0? list[0].ProtokolNumber:""; 
            }
            else
            { return ""; }
        }

        /// <summary>
        /// Подключение к базе данных ASU  для получения данных о ранее проведенных  испытаниях
        /// </summary>
        private void SetAsuContext()
        {
            if (UseAsu)
            {
                var optionsBuilder = new DbContextOptionsBuilder<AsuContext>();
                var options = optionsBuilder
                    .UseSqlServer(_configuration.GetConnectionString("AsuContext"))
                    .Options;
                // установка конфигурации подключения к базе данных калькулятора
                _asuContext = new AsuContext(options);
            
            }

        }
        /// <summary>
        /// Проверяет загружали ли ли такой элемент ранее,  если да то ElementType  берется из ранее загруженного элемента
        /// </summary>
        /// <returns></returns>
        private XLSXElementType BeforeUploadedXLSXElementType(string elementName, int id, int programid)
        {
            string selectStr= "SELECT [ID] ,[ElementImportID] ,[ElementName] ,[ElementTypeKey]"+
            ",[ElementCount] ,e.[ElementTypeID] ,[AsuProtokolCode] ,[BeforeUploadedXLSXElementTypeID] " +
            "FROM [XLSXElementType] x, ElementType e where e.ElementTypeID=x.ElementTypeID and  RTRIM(LTRIM(UPPER(replace(ElementName,' ','')))) ={0} and ID <> {1} " + 
            " AND  e.ProgramID = {2}";
            
            List<XLSXElementType> list = _context.XLSXElementTypes.FromSqlRaw(selectStr, PrepareStr(elementName),id,programid).ToList();

            return list.Count > 0 ? list[0] : null;
        

        }
    }
}