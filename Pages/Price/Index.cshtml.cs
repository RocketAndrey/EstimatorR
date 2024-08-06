using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Estimator.Pages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Estimator.Pages.Price
{
    public class IndexModel : BaseEstimatorPage
    {

       
        public List<Estimator.Models.PriceList> PriceList { get; private set; } = new();
        public IndexModel(Estimator.Data.EstimatorContext db, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(db, appEnvironment, configuration)
        {
            _context = db;
        }

        public async Task<IActionResult> OnGet(int? id)
        {
            if (id != null)
            {
                var comp = await _context.PriceLists.FindAsync(id);

                if (comp != null)
                {
                    _context.Prices.Where(x => x.PriceListId == id).ExecuteDelete(); //Удаление импортирванных прайсов

                    _context.PriceLists.Remove(comp);
                    await _context.SaveChangesAsync();
                }
            }

            PriceList = await _context
                .PriceLists
                .Include(e=>e.Manufacture)
                .AsNoTracking()
                .ToListAsync();
            
            return Page();
        }
    }
}
