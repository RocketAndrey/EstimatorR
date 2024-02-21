using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Estimator.Pages.RuChips
{
    [IgnoreAntiforgeryToken]
    public class EditModel : PageModel
    {
        Estimator.Data.EstimatorContext context;
        [BindProperty]
        public Estimator.Models.RuChipsDB? editDirVniir { get; set; }

        public EditModel(Estimator.Data.EstimatorContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            editDirVniir = await context.DirVniir.FindAsync(id);

            if (editDirVniir == null) return NotFound();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.DirVniir.Update(editDirVniir!);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
