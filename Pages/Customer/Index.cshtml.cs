using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly Data.EstimatorContext _context;
        public string NameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public IndexModel(Data.EstimatorContext context)
        {
            _context = context;
        }

        public IList<Models.Customer> Customer { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)

        {
            //сортировка
            NameSort = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            // Фильтрация
            CurrentFilter = searchString;
            //все заказчики
            IQueryable<Models.Customer> custmersIQ = from s in _context.Customers
                                                     select s;

            if (!string.IsNullOrEmpty(searchString))
            {
                //фильтрованные заказчики
                custmersIQ = custmersIQ.Where(s => s.Name.Contains(searchString));
            }


            custmersIQ = sortOrder switch
            {
                "name_desc" => custmersIQ.OrderByDescending(s => s.Name),
                _ => custmersIQ.OrderBy(s => s.Name),
            };
            Customer = await custmersIQ.AsNoTracking().ToListAsync();


        }
    }
}
