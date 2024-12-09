using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using Estimator.Models.ViewModels;
using Estimator.Helpers;
using System;
using Estimator.Models;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;


namespace Estimator.Pages.Price
{
   
    public class ElementPriceModel : Estimator.Pages.CustomerRequests.CustomerRequestPageModel


    {
        [BindProperty]
       public  PurchaseElementView view { get; set; }
        public ElementPriceModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {
            ElementCount = 1; 
        }
        public async Task<IActionResult> OnGetAsync()

        {
           // await base.SetCustomerReguest((int)id, int.Parse(_configuration.GetSection("YearOfNorms")["value"]));
            return Page(); 
        }
        [BindProperty]
        public string ElementName { get; set; }
        [BindProperty]
        public int ElementCount { get; set; } 

        [BindProperty]
        public int ManufactoryId {  get; set; }
        [BindProperty]
        public string ManufactoryName {  get; set; }    

        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()


        {
            ErrorMessage = "";
            if (string.IsNullOrEmpty(ElementName)) { return Page(); }

            Helpers.PriceMachine machine = new Helpers.PriceMachine(_context, _asuContext);

            view = new PurchaseElementView();

            view.ElementName = Funct.ReplaceEngChar(ElementName);
            if (ElementCount < 1) { ElementCount = 1; }

            view.ItemsCount = ElementCount;
            if (ManufactoryId == 0) 

            {
               if (!string.IsNullOrEmpty(ManufactoryName)) { view.MànufactorySearchString = ManufactoryName; }
       
                await machine.SetXSLXViewManufactory(view, true);
                
            }
         
            else {view.Manufactory.Id = ManufactoryId; }

            if (view.Manufactory.Id != 0)
            {
                await machine.SetItemPrice(view);
                if (view.CalculatedElementPrice == 0) { ErrorMessage = view.MànufactorySearchErrorString; }
            }
            else

            {
                ErrorMessage = view.MànufactorySearchErrorString;
            }
            return Page();
        }
    }
}
