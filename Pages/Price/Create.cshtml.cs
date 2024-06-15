using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Estimator.Data;
using Estimator.Models;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.IO;
using Estimator.Models;

using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;

namespace Estimator.Pages.Price
{
    public class CreateModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;

        private IWebHostEnvironment Environment;
        public SelectList companyList { get; set; }
        public string Message { get; set; }
        public CreateModel(IWebHostEnvironment _environment, Estimator.Data.EstimatorContext context)
        {
            Environment = _environment;
            _context = context;
        }

        public IActionResult OnGet()
        {
            companyList = new SelectList(_context.Companies.ToList(), "Name", "Name");
            
            return Page();
        }

        [BindProperty]
        public PriceList PriceList { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD

        public async Task<IActionResult> OnPostUpload(IFormFile postedFiles)
        {
            if (postedFiles == null || postedFiles.Length <= 0)
            {
                Message = "This is not a valid file.";
                return Page();
            }

            if (!Path.GetExtension(postedFiles.FileName).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                Message = "Wrong file format. Should be pdf.";
                return Page();
            }

            string path = Path.Combine(this.Environment.WebRootPath, "Prices");

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
                path = path + "\\" + fileName;
            }

            PriceList.ScanOfPrice = path;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PriceLists.Add(PriceList);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");         

        }
    }
}
