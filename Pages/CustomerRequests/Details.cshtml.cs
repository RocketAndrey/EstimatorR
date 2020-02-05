using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Estimator.Data;
using Estimator.Models;

namespace Estimator.CustomerRequests
{
    public class DetailsModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;

        public DetailsModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        public CustomerRequest CustomerRequest { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CustomerRequest = await _context.CustomerRequests
                .Include(c => c.Customer)
                .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);
                
              //  .Include(c => c.Program).FirstOrDefaultAsync(m => m.CustomerRequestID == id);

            if (CustomerRequest == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
