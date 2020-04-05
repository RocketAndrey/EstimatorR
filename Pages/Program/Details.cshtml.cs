using Estimator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Estimator.Pages.Program
{
    public class DetailsModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;

        public DetailsModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        public TestProgram TestProgram { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TestProgram = await _context.TestPrograms.FirstOrDefaultAsync(m => m.TestProgramID == id);

            if (TestProgram == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
