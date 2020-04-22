using Estimator.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Pages.CustomerRequests
{
    public class IndexModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;
        public PaginatedList<CustomerRequestView> CustomerRequestList { get; set; }
        // public PaginatedList<CustomerRequestView> CustomerRequestViews { get; set; }
        public string DateSort { get; set; }
        public string ProgramSort { get; set; }
        public string CustomerSort { get; set; }
        public string CurrentSort { get; set; }
        public string CurrentFilter { get; set; }
        public IndexModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IList<CustomerRequestView> customerRequestViewsIQ = await _context.CustomerRequests
                .Select(p => new CustomerRequestView
                {
                    CustomerRequestID = p.CustomerRequestID,
                    RequestDate = p.RequestDate,
                    RequestNumber = p.RequestNumber,
                    Description = p.Description,
                    CustomerName = p.Customer.Name,
                    CustomerINN = p.Customer.INN,
                    ProgramName = p.Program.Name
                }).ToListAsync();


            DateSort = String.IsNullOrEmpty(sortOrder) ? "Date_desc" : "";
            ProgramSort = sortOrder == "Program" ? "Program_desc" : "Program";
            CustomerSort = sortOrder == "Customer" ? "Customer_desc" : "Customer";

            if (!String.IsNullOrEmpty(searchString))
            {
                customerRequestViewsIQ = customerRequestViewsIQ.Where(s => s.Description.Contains(searchString)
                                       || s.CustomerName.Contains(searchString)).ToList();
            }

            switch (sortOrder)
            {
                case "Program":
                    customerRequestViewsIQ = customerRequestViewsIQ.OrderBy(s => s.ProgramName).ToList();
                    break;
                case "Program_desc":
                    customerRequestViewsIQ = customerRequestViewsIQ.OrderByDescending(s => s.ProgramName).ToList();
                    break;
                case "Customer":
                    customerRequestViewsIQ = customerRequestViewsIQ.OrderBy(s => s.CustomerName).ToList();
                    break;
                case "Customer_desc":
                    customerRequestViewsIQ = customerRequestViewsIQ.OrderByDescending(s => s.CustomerName).ToList();
                    break;
                case "Date":
                    customerRequestViewsIQ = customerRequestViewsIQ.OrderBy(s => s.RequestDate).ToList();
                    break;
                case "Date_desc":
                    customerRequestViewsIQ = customerRequestViewsIQ.OrderBy(s => s.RequestDate).ToList();
                    break;
                default:
                    customerRequestViewsIQ = customerRequestViewsIQ.OrderByDescending(s => s.RequestDate).ToList();
                    break;
            }



            int pageSize = 20;
            CustomerRequestList = await PaginatedList<CustomerRequestView>.CreateAsync(
                customerRequestViewsIQ.ToList(), pageIndex ?? 1, pageSize);

        }
    }
}
