using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Estimator.Data;
using Estimator.Models;
using Microsoft.AspNetCore.Authorization;

namespace Estimator.Pages.ElementKey
{
    [Authorize(Roles = "Administrator")]
    public class DeleteModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;

        public DeleteModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Estimator.Models.ElementKey ElementKey { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ElementKey = await _context.ElementKey
                .Include(e => e.ElementType).FirstOrDefaultAsync(m => m.ElementKeyID == id);

            if (ElementKey == null)
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

            ElementKey = await _context.ElementKey.FindAsync(id);

            if (ElementKey != null)
            {
                _context.ElementKey.Remove(ElementKey);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index", new { id=ElementKey.ElementTypeID });
        }
    }
}
