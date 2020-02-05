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
using Estimator.Models.ViewModels;


namespace Estimator.Pages.CustomerRequests
{
    public class EditModel :CustomerRequestPageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;

        public EditModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CustomerRequest CustomerRequest { get; set; }
       // public IList <RequestElementType> RequestElementTypes { get; set; }
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
                .Include(c=>c.RequestElementTypes)
                    .ThenInclude(c=>c.ElementType)
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);

            PopulateAssignedElementTypes(_context, CustomerRequest);
            //Сортировка
          

           // RequestElementTypes = await rET.ToListAsync();

            if (CustomerRequest == null)
            {
                return NotFound();
            }
            // Добавляем типы элементов для новой заявки
           
           ViewData["CustomerID"] = new SelectList(_context.Customers, "CustomerID", "Name");
           ViewData["TestProgramID"] = new SelectList(_context.TestPrograms, "TestProgramID", "Name");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(AssignedRequestElementType[] elementTypes)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            foreach (var e in elementTypes)
            {
              //  AssignedElementsList[]
            }

            _context.Attach(CustomerRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerRequestExists(CustomerRequest.CustomerRequestID))
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

        private bool CustomerRequestExists(int id)
        {
            return _context.CustomerRequests.Any(e => e.CustomerRequestID == id);
        }
    }
}
