using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Estimator.Pages.Manufacturer
{
    public class IndexModel : BaseEstimatorPage
    {
        public string Message { get; set; }

        public List<Estimator.Models.Company> Companies { get; private set; } = new();
        public IndexModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {

        }
        public async Task<IActionResult> OnGet(int? id, string? countIm, string? countUp)
        {
            if (id != null && isAdministrator)
            {
                var comp = await _context.Companies.FindAsync(id);

                if (comp != null)
                {
                    _context.Companies.Remove(comp);
                    await    _context.SaveChangesAsync();
                }
            }
            if (countIm != null && countUp != null)
                this.Message = "Import - " + countIm + " Update - " + countUp; //Что то с кодировкой?


            Companies = _context.Companies.AsNoTracking().ToList();

            return Page();
        }
    }
}
