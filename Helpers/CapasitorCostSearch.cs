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
using Estimator.Models.Elements;


namespace Estimator.Helpers
{
    public class CapasitorCostSearch:baseCostSearch
    {
        public CapasitorCostSearch(Estimator.Data.EstimatorContext context, Estimator.Data.AsuContext asuContext) : base(context, asuContext)
        {
        }

        public override async Task<Price> GetCost(PurchaseElementView elementView, List<PriceList> currentPrices)

        {
            if (currentPrices == null) { return null; }
            if (currentPrices.Count == 0) { return null; }
            List<Price> priceList = null;

            currentPrices  = currentPrices.OrderByDescending(r => r.DateEnd).ToList(); 

            for (int i = 0;i < currentPrices.Count; i++)
            {
            
               PriceList currentPrice = currentPrices[i];

                currentPrice.PriceItems = await _context.Prices
                        .Where(e => e.PriceListId == currentPrice.PriceListId)
                        .OrderByDescending(r => r.PriceList.DateEnd).ToListAsync();

                Capasitor cap = new Capasitor(elementView.ElementName, currentPrice.Template);
                //Наименование
                priceList = currentPrice.PriceItems.Where(e => e.Name.ToUpper() == cap.Type.ToUpper()).ToList();
                //Емкость 
                priceList = priceList.Where(e => Funct.InRange(e.Property2, cap.Capacity)).ToList();
                //ТКЕ
                priceList = priceList.Where(e => Funct.ReplaceEngChar(e.Property0).ToUpper() == cap?.TCGroup).ToList();
                ////Точность 
                if (!String.IsNullOrEmpty(cap.Accuracy))
                {
                    //Точность не всегда указыввается в наименовании!!
                    priceList = priceList.Where(e => e.Property5?.ToUpper() == cap?.Accuracy).ToList();
                }
                //Рабочее напряжение
                if (cap.RatedVoltage > 0)
                {
                    ////Точность  
                    priceList = priceList.Where(e => e.Property1?.ToUpper() == cap.RatedVoltage.ToString()).ToList();

                }
                //колличество 
                priceList = priceList.Where(e => Funct.InRange(e?.Property8, elementView.ItemsCount)).ToList();
                //Гальваническое покрытие
                priceList = priceList.Where(e => (e.Property7 ?? "") == (cap.Electroplating ?? "")).ToList();

                // если отбор по автомату вообще есть то отбираем
                if ((priceList.Where(e => (e.Property9 ?? "") == (cap.Automat ?? "")).ToList().Count > 0))
                    {
                    //Упаковка для автоматизированного монтаха
                    priceList = priceList.Where(e => (e.Property9 ?? "") == (cap.Automat ?? "")).ToList();
                }

                if (!String.IsNullOrEmpty (cap.TypeSize ))
                {
                    priceList = priceList.Where(e => (e.Property6 ?? "") == (cap.TypeSize ?? "")).ToList();
                }

                priceList = priceList.OrderByDescending(e => e.Cost).ToList();

                if (priceList.Count > 0) { break ; }
            }

            if (priceList?.Count > 0)
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
