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
        public  int PreviosTestChainItemID
        {
            get
            {
                return TestChainItem.TestChainItemID - 1;
                    
            }
        }
        public  int NextTestChainItemID
        {
            get
            {
                return TestChainItem.TestChainItemID + 1;

            }
        }
        public string HeaderText
        {
            get
            {
                if (TestChainItem!=null)
                {
                    return TestChainItem.Operation.Code + ": " + TestChainItem.Operation.Name;
                }
                else
                {
                    return String.Empty ;
                }
            }
        }
        public EditModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }
     

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
                .Include(e => e.Operation)
                .Include(e => e.TestActions)
                    .ThenInclude(e => e.Qualification)
                .Include(e => e.ElementType)
                     .ThenInclude(e => e.Program)
                .FirstOrDefaultAsync(m => m.TestChainItemID == testChainItemID);
            if (TestChainItem == null)
            {
                return NotFound();
            }

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

        
      
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? testChainItemID, TestActionView[] views)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (testChainItemID == null)
            {
                return NotFound();
            }

            var testChainItemToUpdate = await _context.TestChainItems
                .Include(e => e.Operation)
                .Include(e => e.TestActions)
                    .ThenInclude(e => e.Qualification)
                .Include(e => e.ElementType)
                     .ThenInclude(e => e.Program)
                .FirstOrDefaultAsync(m => m.TestChainItemID == testChainItemID);

            if (testChainItemToUpdate == null)
            {
                return NotFound();
            }

            foreach (var element in testChainItemToUpdate.TestActions)
            {
                foreach (var updElement in views)
                {
                    if (element.TestActionID == updElement.TestActionID)
                    {
                        element.ItemLabor = updElement.ItemLabor;
                        element.KitLabor = updElement.KitLabor;
                        element.BatchLabor = updElement.BatchLabor;
                    }
                }
            }
           

            _context.Attach(testChainItemToUpdate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestChainItemExists(testChainItemToUpdate.TestChainItemID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Edit", new { testChainItemID = testChainItemToUpdate.TestChainItemID });
        }

        private bool TestChainItemExists(int id)
        {
            return _context.TestChainItems.Any(e => e.TestChainItemID == id);
        }
    }
}
