using Estimator.Models;
using Estimator.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Estimator.Helpers
{
    public class baseCostSearch
    {
        protected Estimator.Data.EstimatorContext _context;

        protected Estimator.Data.AsuContext _asuContext;
        public baseCostSearch(Estimator.Data.EstimatorContext context, Estimator.Data.AsuContext asuContext)
        {
            _context = context;
            _asuContext = asuContext;

        }
        public virtual async Task <Price> GetCost(PurchaseElementView elementView, List<PriceList> currentPrice)
        {
            return null;   
        }
        /// <summary>
        /// Врозвращае произведение индексов дефляторов
        /// </summary>
        /// <param name="priceEndDate"></param>
        /// <returns></returns>
        public decimal GetDeflatorFactor (DateTime priceEndDate)
        {
            decimal returnValue = 1; 

            if (priceEndDate > DateTime.Now)
            {
                return 1;
            }
            // разница в годах от даты окончания прайса 
            TimeSpan span = DateTime.Now - priceEndDate;
            int yearsDiff = new DateTime(span.Ticks).Year;

            List <Deflator> deflators= _context.Deflators
                .Where(e=>e.Year >= priceEndDate.Year)
                .OrderBy (e=>e.Year)
                .ToList();
           
            for (int i = 0;i<yearsDiff;i++)
            {
                returnValue = returnValue * (deflators[i].Value)/100;
            }
            return returnValue;
        }
    }
}
