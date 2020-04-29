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

namespace Estimator.Pages.CustomerRequests
{
    public class ImportModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;

        public string ErrorMessage;
        private IWebHostEnvironment _appEnvironment;
        public ImportModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            ErrorMessage = "";
            ImportStep = 1;

            _context = context;
            _appEnvironment = appEnvironment;
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
                        return "Этап 3: загрузка данных в базу.";
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
                ElementImport = new ElementImport();
                ElementImport.XLSXElementTypes = new List<XLSXElementType>();
                ElementImport.CustomerRequestID = id.Value;

                ElementImport.CustomerRequest = _context.CustomerRequests
                                                        .Include(c => c.Customer)
                                                        .Include(c => c.Program)
                                                            .ThenInclude(c => c.ElementntTypes)
                                                      .FirstOrDefault(m => m.CustomerRequestID == id);
            }
            else
            {

                ElementImport = _context.ElementImports
                    .Include (e=>e.XLSXElementTypes)
                   .FirstOrDefault(m => m.CustomerRequest.CustomerRequestID == id);
                //если файл загружен то  сразу переходим к анализу загруженных данных
                ImportStep = ImportStep == 1 & ElementImport.FileUploaded ? 2 : ImportStep;


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
                        ext = ext.Substring(ext.Length - 4,4);
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
                        throw;
                    }
                }

                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                }
            }
            else if (ImportStep==2)
            {
                             
                    ValidateXLSX(true);
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
    
         private bool ValidateXLSX (bool saveChanges)
        {
            //получаем коллекцию ключей
            Dictionary <string, int> keys = new Dictionary<string,int>();
            
            

            ElementImport.CustomerRequest = _context.CustomerRequests
                                .Include(m => m.Program)
                                    .ThenInclude(e => e.ElementntTypes)
                                        .ThenInclude(e => e.Keys)
                                .FirstOrDefault(e => e.CustomerRequestID == ElementImport.CustomerRequestID);
                           
          
            //заполняем коллецию ключей
            foreach (var itemET in ElementImport.CustomerRequest.Program.ElementntTypes)
            {
                foreach (var itemKey in itemET.Keys)
                {
                    keys.Add(itemKey.Key, itemKey.ElementTypeID);
                }
            }
            //функция возвращает true  только когда все элементы валидны;
            bool returnValue = true;
            //перебираем все загрузки
            foreach (var itemXLSX in ElementImport.XLSXElementTypes)
            {
                itemXLSX.Valid = false;
                itemXLSX.ErrorMessage = "";

                itemXLSX.ElementName = itemXLSX.ElementName == null ? "" : itemXLSX.ElementName;
                itemXLSX.ElementTypeKey = itemXLSX.ElementTypeKey ==null ? "": itemXLSX.ElementTypeKey;
                if (!itemXLSX.InList & saveChanges )
                {
                    _context.Attach(itemXLSX).State = EntityState.Deleted;
                    XLSXElementType item = _context.XLSXElementTypes.FirstOrDefault(m => m.ID == itemXLSX.ID);
                    ElementImport.XLSXElementTypes.Remove(itemXLSX);
                    break;
                }

                //нет имени - не загружаем
                if (PrepareStr (itemXLSX.ElementName)=="")
                {
                    itemXLSX.ErrorMessage = "Имя элемента не заполнено";
                    returnValue = false;
                    continue; 
                }
                if (PrepareStr(itemXLSX.ElementTypeKey ) == "")
                { 
                    itemXLSX.ErrorMessage = "Ключ для элемента не заполнен.";
                    returnValue = false;
                    continue;
                }
                foreach (var key in keys)
                {
                    if (PrepareStr(itemXLSX.ElementTypeKey) == PrepareStr(key.Key))
                    {

                        itemXLSX.ElementTypeID = keys[key.Key];
                        itemXLSX.ErrorMessage = "";
                        itemXLSX.Valid = true;

                        itemXLSX.ElementTypeName = ElementImport.CustomerRequest.Program.ElementntTypes.FirstOrDefault(m => m.ElementTypeID == itemXLSX.ElementTypeID).Name;

                        break;
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
                    item.ElementTypeKey = itemXLSX.ElementTypeKey == null ? "" : itemXLSX.ElementTypeKey;
                    item.ElementName = itemXLSX.ElementName == null ? "" : itemXLSX.ElementName;
                    item.ElementDatasheet = itemXLSX.ElementDatasheet == null ? "" : itemXLSX.ElementDatasheet;
                    item.ElementCount = itemXLSX.ElementCount;
                    item.ElementTypeID = itemXLSX.ElementTypeID;

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
            return newstr.Trim().ToLower();
        }

        private void FillELementTypes()
        {
            //подгружаем типв элемоенов для заявки
            ElementImport.CustomerRequest.RequestElementTypes = _context.RequestElementTypes.Where (e => e.CustomerRequestID == ElementImport.CustomerRequestID).ToList();
            if (ElementImport.CustomerRequest.RequestElementTypes!=null)
            {
                foreach (var itemRet in ElementImport.CustomerRequest.RequestElementTypes)
                {
                    itemRet.ItemCount = 0;
                    itemRet.KitCount = 0;
                    itemRet.BatchCount = 0;
                    foreach (var itemX in ElementImport.XLSXElementTypes)
                    {
                        if (itemRet.ElementTypeID ==itemX.ElementTypeID )
                        {
                            itemRet.BatchCount ++;
                            itemRet.ItemCount += itemX.ElementCount;
                        }
                    }
                }
            }
        }
    }
}
