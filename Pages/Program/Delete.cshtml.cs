using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Estimator.Data;
using Estimator.Models;

namespace Estimator.Pages.Program
{
    public class DeleteModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;

        public DeleteModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TestProgram = await _context.TestPrograms.FindAsync(id);

            if (TestProgram != null)
            {
                _context.TestPrograms.Remove(TestProgram);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
