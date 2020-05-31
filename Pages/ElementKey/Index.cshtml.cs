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
    public class IndexModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;
        public IndexModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        public Estimator.Models.ElementType ElementType { get;set; }

        public async Task<IActionResult> OnGetAsync(int? id)

        {
            if (id == null)
            {
                return NotFound();
            }

            ElementType = await _context.ElementTypes
                .Include(e => e.Keys)
                .AsNoTracking()
                .FirstOrDefaultAsync(e=>e.ElementTypeID==id);
            if(ElementType==null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
