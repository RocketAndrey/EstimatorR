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

        Estimator.Data.EstimatorContext context;
        public List<Estimator.Models.Company> Companies { get; private set; } = new();
        public IndexModel(Estimator.Data.EstimatorContext db, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(db, appEnvironment, configuration)
        {
            context = db;
        }
        public async Task<IActionResult> OnGet(int? id, string? countIm, string? countUp)
        {
            if (id != null)
            {
                var comp = await context.Companies.FindAsync(id);

                if (comp != null)
                {
                    context.Companies.Remove(comp);
                    await context.SaveChangesAsync();
                }
            }
            if (countIm != null && countUp != null)
                this.Message = "Import - " + countIm + " Update - " + countUp; //Что то с кодировкой?


            Companies = context.Companies.AsNoTracking().ToList();

            return Page();
        }
    }
}
