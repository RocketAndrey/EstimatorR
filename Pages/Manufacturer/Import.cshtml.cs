using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Estimator.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using Estimator.Helpers;

namespace Estimator.Pages.Manufacturer
{
    public class ImportModel : PageModel
    {
        public bool _disable { get; set; }

        public List<String> tmpF = new List<string>();

        public char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        [Display(Name = "Наименование")]
        public ColumnNames _codeCol { get; set; }
        public enum ColumnNames
        {

            A = 1, B = 2, C = 3, D = 4, E = 5, F = 6, G = 7, H = 8, I = 9, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z
        }

        Estimator.Data.EstimatorContext context;
               

        public List<Estimator.Models.Company> addCompanies;
        public ImFileData imFiles { get; set; } = new();
        
        private IWebHostEnvironment Environment;
        public string Message { get; set; }

        public ImportModel(IWebHostEnvironment _environment, Estimator.Data.EstimatorContext db)
        {
            Environment = _environment;
            context = db;
            _disable = true;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostUpload(IFormFile postedFiles)
        {
            if (postedFiles == null || postedFiles.Length <= 0)
            {
                Message = "This is not a valid file.";
                return Page();
            }

            if (!Path.GetExtension(postedFiles.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                Message = "Wrong file format. Should be xlsx.";
                return Page();
            }

            string path = Path.Combine(this.Environment.WebRootPath, "Uploads");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
                        
            string fileName = Path.GetFileName(postedFiles.FileName);
            using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                postedFiles.CopyTo(stream);
                uploadedFiles.Add(fileName);
                this.Message += string.Format("<b>{0}</b>  - Загружен.<br />", fileName);
                path = path + "\\" + fileName;
            }

            imFiles.Path = path;

            HandlerImport h_Import = new HandlerImport(path);

            tmpF = h_Import.takeData(path);

            context.ImportData.Add(imFiles);
            context.SaveChanges();

            _disable = false;

            return Page();
            
        }

        public async Task<IActionResult> OnPostFinishAsync()
        {

            var _lastShowPathId = context.ImportData.Max(x => x.Id);
            var _lastPath = context.ImportData.FirstOrDefault(x => x.Id == _lastShowPathId).Path;

            HandlerImport h_Import = new HandlerImport(_lastPath, int.Parse(Request.Form["SelectedCode"].First()), int.Parse(Request.Form["SelectedName"].First()), int.Parse(Request.Form["SelectedNote"].First()), Request.Form["AreChecked"].IsNullOrEmpty());

            addCompanies = new List<Estimator.Models.Company>();
            addCompanies = h_Import.ImportFileManufacturer();

            int countIm = 0;
            int countUp = 0;

            if (addCompanies != null)
            {
                for (int i = 0; i < addCompanies.Count(); i++)
                {
                    //Проверка на существование производителя (по его номеру)
                    var _isCompExist = context.Companies.Any(x => x.Code == addCompanies.ElementAt(i).Code);

                    if (_isCompExist)
                    {
                        context.Companies.Where(t => t.Code == addCompanies.ElementAt(i).Code).
                            ExecuteUpdate(b => b.SetProperty(u => u.Note, addCompanies.ElementAt(i).Note));
                        countUp++;
                    }
                    else
                    {
                        context.Companies.Add(addCompanies.ElementAt(i));
                        countIm++;
                    }

                    await context.SaveChangesAsync();
                }
            }

            System.Diagnostics.Debug.WriteLine(value: Request.Form["AreChecked"].IsNullOrEmpty());

            return RedirectToPage("Index", new { countIm = countIm.ToString(), countUp = countUp.ToString() });
        }

    }
}
