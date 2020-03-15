using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Estimator.Data;
using Estimator.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Estimator.Pages.CustomerRequests
{
    public class DetailsModel : CustomerRequestPageModel
    {
       
        public DetailsModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }
     
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CustomerRequest = await _context.CustomerRequests
                .Include(c => c.Customer)
                .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);
              

            if (CustomerRequest == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(IFormFile uploadedFile)

        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;

                // сохраняем файл в папку Files в каталоге wwwroot

                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
            }

            return Page();
        }
    }
}
