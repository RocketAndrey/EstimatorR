using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Estimator.Data;
using Estimator.Models;

namespace Estimator
{
    public class IndexModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;
        public string NameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public IndexModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString)

        {
            //сортировка
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            
            // Фильтрация
            CurrentFilter = searchString;
            //все заказчики
            IQueryable<Customer> custmersIQ = from s in _context.Customers
                                              select s;
            
            if (!String.IsNullOrEmpty(searchString))
            {
                //фильтрованные заказчики
                custmersIQ = custmersIQ.Where(s => s.Name.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "name_desc":
                    custmersIQ = custmersIQ.OrderByDescending(s => s.Name);
                    break;
                default:
                    custmersIQ = custmersIQ.OrderBy(s => s.Name);
                    break;
            }

            Customer = await custmersIQ.AsNoTracking().ToListAsync();

       
        }
    }
}
