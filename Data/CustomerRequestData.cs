using Estimator.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Estimator.Data
{
    public class CustomerRequestData
    {
        protected Estimator.Data.EstimatorContext _context;
        public CustomerRequestData (EstimatorContext context)
        {
            _context = context;
        }
        public async Task<CustomerRequest>  GetByID( int customerRequestID)
        {
            CustomerRequest request;

            request = await _context.CustomerRequests
                .Include(c => c.Customer)
                .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                .Include(c => c.RequestElementTypes)
                    .ThenInclude(c => c.ElementType)
                .Include(c => c.Program)
                    .ThenInclude(c => c.Templates)
                .FirstOrDefaultAsync(m => m.CustomerRequestID == customerRequestID);

            return request; 
        }
    }
}
