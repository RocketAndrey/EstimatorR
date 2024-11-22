using Estimator.Models;
using Estimator.Models.ViewModels;
using Estimator.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Policy;
using NPOI.SS.Formula.Functions;
using Microsoft.IdentityModel.Tokens;
using NPOI.XSSF.Streaming.Values;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace Estimator.Helpers
{
    public class ElementCostSearch:baseCostSearch


    {
        public ElementCostSearch(Estimator.Data.EstimatorContext context, Estimator.Data.AsuContext asuContext):base(context, asuContext) 
        { 
        }   
        
        public override async Task<Price> GetCost(PurchaseElementView elementView, List<PriceList> currentPrice)

        {

            List<Price> priceItems = null;

            priceItems = await _context.Prices
                    .Where(e => e.VniirId == elementView.VniirItemId)
                    .Include(e => e.PriceList)
                    .OrderByDescending(r => r.PriceList.DateEnd).ToListAsync();


            if (priceItems.Count == 0)
            {
                priceItems = await _context.Prices
               .Where(e => e.Name == elementView.ElementName)
               .Include(e => e.PriceList)
               .OrderByDescending(r => r.PriceList.DateEnd)
               .ToListAsync();
            }

            if (priceItems.Count > 0)
            {

                elementView.ElementPrice = (decimal)priceItems[0].Cost;
                elementView.IndexDeflator = base.GetDeflatorFactor(priceItems[0].PriceList.DateEnd);
                elementView.DeliveryTime = (int)priceItems[0].DeliveryTime;
                elementView.PriceType = ElementPriceType.Price;
                elementView.Price = priceItems[0];

                return priceItems[0];
            }
            return null; 
        }
    }
}
