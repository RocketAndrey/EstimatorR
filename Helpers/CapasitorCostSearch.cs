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
    public class CapasitorCostSearch:baseCostSearch
    {
        public CapasitorCostSearch(Estimator.Data.EstimatorContext context, Estimator.Data.AsuContext asuContext) : base(context, asuContext)
        {
        }

        public override async Task<Price> GetCost(PurchaseElementView elementView, PriceList currentPrice)

        {
            return null;
        }
    }

}
