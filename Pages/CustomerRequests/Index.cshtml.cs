using Estimator.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Estimator.Pages.CustomerRequests


{
  
    public class IndexModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;
        public PaginatedList <CustomerRequestView> CustomerRequestList { get; set; }
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
                }).AsNoTracking().ToListAsync();


            DateSort = String.IsNullOrEmpty(sortOrder) ? "Date_desc" : "";
            ProgramSort = sortOrder == "Program" ? "Program_desc" : "Program";
            CustomerSort = sortOrder == "Customer" ? "Customer_desc" : "Customer";

            if (!String.IsNullOrEmpty(searchString))
            {
                customerRequestViewsIQ = customerRequestViewsIQ.Where(s => s.Description.Contains(searchString)
                                       || s.CustomerName.Contains(searchString)).ToList();
            }

            customerRequestViewsIQ = sortOrder switch
            {
                "Program" => customerRequestViewsIQ.OrderBy(s => s.ProgramName).ToList(),
                "Program_desc" => customerRequestViewsIQ.OrderByDescending(s => s.ProgramName).ToList(),
                "Customer" => customerRequestViewsIQ.OrderBy(s => s.CustomerName).ToList(),
                "Customer_desc" => customerRequestViewsIQ.OrderByDescending(s => s.CustomerName).ToList(),
                "Date" => customerRequestViewsIQ.OrderBy(s => s.RequestDate).ToList(),
                "Date_desc" => customerRequestViewsIQ.OrderBy(s => s.RequestDate).ToList(),
                _ => customerRequestViewsIQ.OrderByDescending(s => s.RequestDate).ToList(),
            };
            int pageSize = 20;
           // CustomerRequestList = new X.PagedList.StaticPagedList<CustomerRequestView>(customerRequestViewsIQ, pageIndex ?? 1, pageSize, customerRequestViewsIQ.Count);
           
            CustomerRequestList = await PaginatedList<CustomerRequestView>.CreateAsync(
            customerRequestViewsIQ.ToList(), pageIndex ?? 1, pageSize);

        }
    }
}
