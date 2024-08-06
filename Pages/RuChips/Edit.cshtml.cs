using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Estimator.Pages.RuChips
{
    [IgnoreAntiforgeryToken]
    public class EditModel : BaseEstimatorPage
    {
        public EditModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {

        }
        [BindProperty]
        public Estimator.Models.RuChipsDB? editDirVniir { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            editDirVniir = await _context.DirVniir.FindAsync(id);

            if (editDirVniir == null) return NotFound();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if(isAdministrator)
            {
                _context.DirVniir.Update(editDirVniir!);
                await _context.SaveChangesAsync();
            }
          
            return RedirectToPage("Index");
        }
    }
}
