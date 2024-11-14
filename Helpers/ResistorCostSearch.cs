using Estimator.Models;
using Estimator.Models.Elements; 
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
    /// <summary>
    ///Для определения цены резистора по прейскуранту производителя
    /// </summary>
    public class ResistorCostSearch:baseCostSearch
    {
        public ResistorCostSearch(Estimator.Data.EstimatorContext context, Estimator.Data.AsuContext asuContext) : base(context, asuContext)
        {
        }

        public override async Task<Price> GetCost(PurchaseElementView elementView, PriceList currentPrice)

        {
            currentPrice.PriceItems = await _context.Prices
                    .Where(e => e.PriceListId == currentPrice.PriceListId)
                    .OrderByDescending(r => r.PriceList.DateEnd).ToListAsync();
            
            Resistor resistor = new Resistor(elementView.ElementName,currentPrice.Template);
            //сопротивление 
            List <Price> priceList = currentPrice.PriceItems.Where(e=> Funct.InRange(e.Property0,resistor.Resistance)).ToList();
            //Мощность
            priceList= priceList.Where (e=>e.Property1.ToUpper()==resistor.Power).ToList();
            //Точность 
            priceList = priceList.Where(e => e.Property3.ToUpper() == resistor.TRR).ToList();
            //ТКС
            if(!String.IsNullOrEmpty(resistor.TCR))
            {
                //ТКС
                priceList = priceList.Where(e => e.Property2.ToUpper() == resistor.TCR).ToList();
            }

            priceList = priceList.OrderByDescending(e => e.Cost).ToList();

            if (priceList.Count > 0)
            {
                elementView.ElementPrice = (decimal)priceList[0].Cost;
                elementView.IndexDeflator = base.GetDeflatorFactor(priceList[0].PriceList.DateEnd);
                elementView.DeliveryTime = (int)priceList[0].DeliveryTime;
                elementView.PriceType = ElementPriceType.Price;
                elementView.Price = priceList[0];

                return priceList[0]; 
            }

            return null;
        }
    }
}
