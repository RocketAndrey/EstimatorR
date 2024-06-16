using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Estimator.Data;
using Estimator.Models;

namespace Estimator.Pages.Price
{
    public class EditModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;
        public SelectList companyList { get; set; }
        public EditModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PriceList PriceList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            companyList = new SelectList(_context.Companies.ToList(), "Name", "Name");

            if (id == null)
            {
                return NotFound();
            }

            PriceList = await _context.PriceLists.FirstOrDefaultAsync(m => m.PriceListId == id);

            if (PriceList == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PriceList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PriceListExists(PriceList.PriceListId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PriceListExists(int id)
        {
            return _context.PriceLists.Any(e => e.PriceListId == id);
        }
    }
}
