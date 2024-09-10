using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Estimator.Data;
using Estimator.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.IdentityModel.Tokens;
using Estimator.Migrations;
using NPOI.SS.Formula.Functions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Estimator.Pages.Price
{
    public class EditModel : BaseEstimatorPage
    {
        public string ErrorMessage { get; set; } = String.Empty; 
        public SelectList companyList { get; set; }
        public EditModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {

        }

        [BindProperty]
        public PriceList PriceList { get; set; }
        public bool _isSimple {  get; set; }
        public bool _isAccessImport = true;
        
        public List<string> ListPropety = new List<string>();
        public List<string> ListElementPropetyName = new List<string>();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            ErrorMessage = String.Empty; 



            if (id == null)
            {
               PriceList = new PriceList ();
               _isAccessImport = false;
            }
            else
            {
                PriceList = await _context.PriceLists
                .Include(e => e.PriceItems)
                .Include (e=>e.Manufacture)
                .Include (e=>e.PriceItemType).ThenInclude(e=>e.PricePropertyNames)
                .FirstOrDefaultAsync(m => m.PriceListId == id);

                int priceItemType = _context.PriceLists.First(x => x.PriceListId == id).PriceItemTypeID;
               
                var PricePropertyName = _context.PriceItemType.Include(e => e.PricePropertyNames).Where(e => e.PriceItemTypeID == priceItemType).ToList();

                _isSimple = PricePropertyName.ElementAt(0).PricePropertyNames.IsNullOrEmpty();

                System.Diagnostics.Debug.WriteLine("213213123123_" + _isSimple);

                var PropertyName = _context.PriceItemType.Include(e => e.PricePropertyNames).Where(c => c.PriceItemTypeID == priceItemType); //Получаем свойства элемента по ID
                foreach (var x in PropertyName)
                {
                    foreach (var y in x.PricePropertyNames)
                    {
                        ListPropety.Add(y.PropertyName);
                        ListElementPropetyName.Add(y.ElementPropertyName);                        
                    }
                }               

            }

            ViewData["companyList"] = new SelectList(_context.Companies.OrderBy(e => e.Name), "Id", "Name");
            ViewData["PriceTypes"] = new SelectList (_context.PriceItemType, "PriceItemTypeID", "PriceItemTypeName");
            

            if (PriceList == null)
            {
                return NotFound();
            }
            return Page();
        }


        public async Task<IActionResult> OnPostSaveAsync(IFormFile uploadedFile)
        {
            if (!ModelState.IsValid)
            {
          
                ErrorMessage = GetModelStateErrors (ModelState);   
                return Page();
            }
            if (PriceList.PriceListId == 0)
            {
                _context.PriceLists.Add(PriceList);
            }
            else
            { 
               _context.Attach(PriceList).State = EntityState.Modified;
        }
            try
            {
                await _context.SaveChangesAsync();

                if (uploadedFile != null)
                {
                    if (uploadedFile.Length <= 0)
                    {
                        ErrorMessage = "Некорректный файл";
                        return Page();
                    }

                    if (!Path.GetExtension(uploadedFile.FileName).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                    {
                        ErrorMessage = "Прейскурант должен быть в формате pdf.";
                        return Page();
                    }

                    string path = Path.Combine(base._appEnvironment.WebRootPath,"Uploads", "Prices");

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                  

                    string fileName = PriceList.PriceListId.ToString()+ "_" + PriceList.DateStart.ToShortDateString()  + ".pdf"; //Path.GetFileName(postedFiles.FileName);
                    using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                    {
                        uploadedFile.CopyTo(stream);
                        //path = path + "\\" + fileName;
                    }

                    PriceList.ScanOfPrice = fileName;

                    _context.Attach(PriceList).State = EntityState.Modified;
                    await _context.SaveChangesAsync();

             
                }
            }


            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return Page();
            }
            //return Page();

            return RedirectToPage("./Edit", new { id = PriceList.PriceListId });
        }
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            if (PriceList  != null && isAdministrator)
            {

                try
                {
                    PriceList forDeletePriceList = _context.PriceLists
                    .Include(a => a.PriceItems)
                    .FirstOrDefault(m => m.PriceListId == PriceList.PriceListId);

                    _context.PriceLists.Remove(forDeletePriceList);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex) 
                {
                    ErrorMessage = ex.Message;
                    return Page();
                }

            }
            return RedirectToPage("./Index");
        }
        private bool PriceListExists(int id)
        {
            return _context.PriceLists.Any(e => e.PriceListId == id);
        }
    }
}
