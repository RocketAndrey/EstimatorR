using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Estimator.Pages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Estimator.Pages.RuChips
{
    public class IndexModel : BaseEstimatorPage
    {

        public string Message { get; set; }

        Estimator.Data.EstimatorContext context;
        public List<Estimator.Models.RuChipsDB> DirVniir { get; private set; } = new();
        public IndexModel(Estimator.Data.EstimatorContext db, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(db, appEnvironment, configuration)
        {
            context = db;
        }
        public async Task<IActionResult> OnGet(int? id, string? countIm, string? countUp)
        {
            if (id != null)
            {
                var comp = await context.DirVniir.FindAsync(id);

                if (comp != null)
                {
                    context.DirVniir.Remove(comp);
                    await context.SaveChangesAsync();
                }
            }
            if (countIm != null && countUp != null)
                this.Message = "Import - " + countIm + " Update - " + countUp; //Что то с кодировкой?


            DirVniir = context.DirVniir.AsNoTracking().ToList();

            return Page();
        }
    }
}
