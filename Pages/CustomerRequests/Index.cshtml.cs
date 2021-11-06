using Estimator.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Estimator.Pages.CustomerRequests


{
  
    public class IndexModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;
        public PaginatedList <CustomerRequestView> CustomerRequestList { get; set; }
       
        public string DateSort { get; set; }
        public string ProgramSort { get; set; }
        public string CustomerSort { get; set; }
        public string CurrentSort { get; set; }
        public string CurrentFilter { get; set; }

        public CustomerRequestFilter filter; 

        public IndexModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
            filter = new CustomerRequestFilter(); 

        }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex, int? customerID,int? programID, int? customerRequestID)
        {
            //фильтр по заказчику
            if (customerID == null) { customerID = 0; }
            List<Models.Customer> customers = _context.Customers.ToList();
            customers.Add(new Models.Customer { CustomerID = 0, Name = "Все" });
            ViewData["CustomerID"] = new SelectList(customers.OrderBy (e=>e.Name ), "CustomerID", "Name");
            //фильтр по программе
            if (programID == null) { programID = 0; }
            List<Models.TestProgram> programs = _context.TestPrograms.ToList();
            programs.Add(new Models.TestProgram  { TestProgramID  = 0,Name  = "Все" });
            ViewData["TestProgramID"] = new SelectList(programs, "TestProgramID", "Name");
            //фильтр по номеру заявки 
            if (customerRequestID == null) customerRequestID = 0;

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
                    ProgramName = p.Program.Name,
                    CustomerID =p.CustomerID ,
                    ProgramID = p.Program.TestProgramID
                }).AsNoTracking().ToListAsync();


            DateSort = String.IsNullOrEmpty(sortOrder) ? "Date_desc" : "";
            ProgramSort = sortOrder == "Program" ? "Program_desc" : "Program";
            CustomerSort = sortOrder == "Customer" ? "Customer_desc" : "Customer";

            if (!String.IsNullOrEmpty(searchString))
            {
                customerRequestViewsIQ = customerRequestViewsIQ.Where(s => s.Description.Contains(searchString)
                                       || s.CustomerName.Contains(searchString)).ToList();
            }
           
            if (customerID != 0)
            {             
                    customerRequestViewsIQ = customerRequestViewsIQ.Where(s => s.CustomerID == customerID).ToList();  
            }
            filter.CustomerID = (int)customerID;

            if (programID  != 0)
            {
                    customerRequestViewsIQ = customerRequestViewsIQ.Where(s => s.ProgramID  == programID).ToList();
                
            }
            filter.ProgramID = (int)programID;

            if (customerRequestID  != 0)
            {
                customerRequestViewsIQ = customerRequestViewsIQ.Where(s => s.CustomerRequestID == customerRequestID).ToList();

            }
            filter.CustomerRequestID = (int)customerRequestID;

            customerRequestViewsIQ = sortOrder switch
            {
                "Program" => customerRequestViewsIQ.OrderBy(s => s.ProgramName).ToList(),
                "Program_desc" => customerRequestViewsIQ.OrderByDescending(s => s.ProgramName).ToList(),
                "Customer" => customerRequestViewsIQ.OrderBy(s => s.CustomerName).ToList(),
                "Customer_desc" => customerRequestViewsIQ.OrderByDescending(s => s.CustomerName).ToList(),
                "Date" => customerRequestViewsIQ.OrderBy(s => s.RequestDate).ToList(),
                "Date_desc" => customerRequestViewsIQ.OrderByDescending(s => s.RequestDate).ToList(),
                _ => customerRequestViewsIQ.OrderByDescending(s => s.RequestDate).ToList(),
            };

            int pageSize = 20;
  
            CustomerRequestList = await PaginatedList<CustomerRequestView>.CreateAsync(
            customerRequestViewsIQ.ToList(), pageIndex ?? 1, pageSize);

        }
    }
}
