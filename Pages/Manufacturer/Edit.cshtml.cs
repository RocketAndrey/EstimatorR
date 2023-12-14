using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Estimator.Pages.Manufacturer
{
    [IgnoreAntiforgeryToken]
    public class EditModel : PageModel
    {
        Estimator.Data.EstimatorContext context;
        [BindProperty]
        public Estimator.Models.Company? Factory { get; set; }

        public EditModel(Estimator.Data.EstimatorContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Factory = await context.Companies.FindAsync(id);

            if (Factory == null) return NotFound();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Companies.Update(Factory!);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
