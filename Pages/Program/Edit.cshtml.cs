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

namespace Estimator.Pages.Program
{
    public class EditModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;

        public EditModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }
      
        public TestProgram TestProgram { get; set; }

        [BindProperty]
        public TestChainItem TestChainItem { get; set; }
        public List<TestActionView> TestActionViewList { get; set; }
        public async Task<IActionResult> OnGetAsync(int? testChainItemID)
        {
            if (testChainItemID == null)
            {
                return NotFound();
            }

            TestChainItem = await _context.TestChainItems
                .Include(e=>e.Operation)
                .Include(e=>e.TestActions)
                    .ThenInclude(e=>e.Qualification)
                .Include(e=>e.ElementType)
                     .ThenInclude(e => e.Program)
                .FirstOrDefaultAsync(m => m.TestChainItemID == testChainItemID);

            TestActionViewList = new List<TestActionView>();

            
                foreach (var item in TestChainItem.TestActions)
                {
                TestActionViewList.Add(new TestActionView
                    {
                        TestChainItemID=item.TestChainItemID,
                        TestActionID=item.TestActionID,
                        QualificationName=item.Qualification.Name,
                        BatchLabor=item.BatchLabor,
                        ItemLabor=item.ItemLabor,
                        KitLabor=item.KitLabor
                    });
                }

        
            ///  TestProgram = await _context.TestPrograms.FirstOrDefaultAsync(m => m.TestProgramID == id);

            // /  if (TestProgram == null)
            // {
            //   return NotFound();
            //  }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TestProgram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestProgramExists(TestProgram.TestProgramID))
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

        private bool TestProgramExists(int id)
        {
            return _context.TestPrograms.Any(e => e.TestProgramID == id);
        }
    }
}
