using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Estimator.Pages.Manufacturer
{
    [IgnoreAntiforgeryToken]
    public class EditModel : BaseEstimatorPage
    {
        [BindProperty]
        public Estimator.Models.Company? Factory { get; set; }

        public EditModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {

        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == 0) 
            {
                Factory = new Models.Company(); 
            }
            else
            {
                Factory = await _context.Companies.FindAsync(id);

            }


            if (Factory == null) return NotFound();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (isAdministrator)
            {
                if (Factory.Id == 0)
                {
                    _context.Companies.Add(Factory);
                }
                else
                {
                    _context.Companies.Update(Factory!);
                }
              
                await _context.SaveChangesAsync();
               
            }
            return RedirectToPage("Index");
        }
    }
}
