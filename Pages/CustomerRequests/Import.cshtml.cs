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

        public async Task<IActionResult> OnGetAsync(int? id,int? step)
        {
            if (id == null)
            {
                return NotFound();
            }
            //установка шага
            ImportStep = step == null ? 1 : step.Value;
           
            ElementImport = _context.ElementImports
                   .Include(c => c.CustomerRequest)
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
                                                      .FirstOrDefault(m => m.CustomerRequestID == id);

            }


            return Page();
        }
      
    [BindProperty]
        public ElementImport ElementImport { get; set; }
        public async Task<IActionResult> OnPostAsync(  IFormFile ?uploadedFile, int step)

        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            /// пытаемся сохранить свойства импорта
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
                //Пытаемся сохранить свойства импорта
                await _context.SaveChangesAsync();
                ///вот тут бы надо проверит что за расширение у файла
        
                // пытаемся сохранить сам файл импорта
                if (step ==1)
                {
                    string path = "/Files/" + ElementImport.CustomerRequestID.ToString()+".xlsx";
                    // сохраняем файл в папку Files в каталоге wwwroot
                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }
                }
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

            if (step == 1)
            {
                if (uploadedFile != null && step == 1)
                {

                    XLSXhelper xhelper = new XLSXhelper();

                    try
                    {
                        ElementImport.XLSXElementTypes = xhelper.Convert(uploadedFile.OpenReadStream(), ElementImport);
                        ImportStep+= 1;
                    }
                    catch (Exception e)
                    {
                        ErrorMessage = e.Message;
                    }

                }
                else
                {
                    ErrorMessage = "Вы не загрузили файл! " + ElementImport.CustomerRequestID.ToString();

                }
            }
           
            return Page();
        }

            public   void OnPostAddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                //using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                //{
                //    await uploadedFile.CopyToAsync(fileStream);
                //}
                //FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
                //_context.Files.Add(file);
                //_context.SaveChanges();
            }

              RedirectToPage("./Index");
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public void  OnPostTest()
        {
            if (!ModelState.IsValid)
            {
                RedirectToPage("./Index");
            }
        

           // _context.ElementImports.Add(ElementImport);
           // await _context.SaveChangesAsync();

        }
        private bool ElementImportExists(int id)
        {
            return _context.ElementImports.Any(e => e.ElementImportID == id);
        }
    }
}
