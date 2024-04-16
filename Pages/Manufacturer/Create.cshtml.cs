using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Estimator.Pages.Manufacturer
{
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        Estimator.Data.EstimatorContext context;
        [BindProperty]
        public Estimator.Models.Manufactures Factory { get; set; } = new();
        public CreateModel(Estimator.Data.EstimatorContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Companies.Add(Factory);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
