using Estimator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Estimator.CustomerRequests
{
   
    public class CreateModel : Estimator.Pages.BaseEstimatorPage 
    {
       
     
        public CreateModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration):base( context,  appEnvironment, configuration)
        { 
        }
        public IActionResult OnGet()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customers.OrderBy(e => e.Name), "CustomerID", "Name");
            ViewData["TestProgramID"] = new SelectList(_context.TestPrograms, "TestProgramID", "Name");
            CustomerRequest = new CustomerRequest();
            return Page();
        }

        [BindProperty]
        public CustomerRequest CustomerRequest { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(string mode)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           
            CustomerRequest.CreateDate = System.DateTime.Now;
            if (UserID > 0)
            {
                CustomerRequest.CreateUserID = UserID;
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
                    RequestElementType r = new RequestElementType
                    {
                       ElementType = e,
                    BatchCount = 0,
                    ItemCount = 0,
                   Order = e.Order};

                    List<RequestOperation> roList = new List<RequestOperation>();

                    foreach (TestChainItem tci in e.ChainItems)
                    {
                        RequestOperation rO = new RequestOperation 
                        {
                        TestChainItem = tci,
                        RequestElementType = r,
                        IsExecute = tci.Operation.IsExecuteDefault,
                        SampleCount = tci.Operation.SampleCount,
                        ExecuteCount = 1
                        };

                        roList.Add(rO);

                        r.RequestOperations = roList;

                    }
                    retList.Add(r);


                }
                CustomerRequest.RequestElementTypes = retList;


                CustomerRequest.IsProceed = true;
            }

            num = _context.SaveChanges();

       

            if ((mode ?? "") == "import")
            {
                return RedirectToPage("./import", new { id = id });
            }
            else
            {
                return RedirectToPage("./Edit", new { id = id });

            }


        }
    }
}
