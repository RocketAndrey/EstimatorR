using Estimator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Estimator.CustomerRequests
{
    public class CreateModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;
        private ICollection<RequestElementType> _requestElementTypes;
        public CreateModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customers, "CustomerID", "Name");
            ViewData["TestProgramID"] = new SelectList(_context.TestPrograms, "TestProgramID", "Name");
            return Page();
        }

        [BindProperty]
        public CustomerRequest CustomerRequest { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            _context.CustomerRequests.Add(CustomerRequest);

            // await _context.SaveChangesAsync();
            int num = _context.SaveChanges();
            int id = CustomerRequest.CustomerRequestID;

            CustomerRequest = await _context.CustomerRequests
                .Include(c => c.Customer)
                .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                        .ThenInclude(e => e.ChainItems)
                            .ThenInclude(r => r.Operation)
                .Include(c => c.RequestElementTypes)
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);

            if (!CustomerRequest.IsProceed)
            {
                List<RequestElementType> retList = new List<RequestElementType>();

                foreach (ElementType e in CustomerRequest.Program.ElementntTypes)

                {
                    RequestElementType r = new RequestElementType();
                    r.ElementType = e;
                    r.BatchCount = 0;
                    r.ItemCount = 0;
                    r.Order = e.Order;

                    List<RequestOperation> roList = new List<RequestOperation>();

                    foreach (TestChainItem tci in e.ChainItems)
                    {
                        RequestOperation rO = new RequestOperation();
                        rO.TestChainItem = tci;
                        rO.RequestElementType = r;
                        rO.IsExecute = tci.Operation.IsExecuteDefault;
                        rO.SampleCount = tci.Operation.SampleCount;
                        rO.ExecuteCount = 1;
                        roList.Add(rO);

                        r.RequestOperations = roList;

                    }
                    retList.Add(r);


                }
                CustomerRequest.RequestElementTypes = retList;


                CustomerRequest.IsProceed = true;
            }

            num = _context.SaveChanges();

            return RedirectToPage("./Edit", new { id = id });


        }
    }
}
