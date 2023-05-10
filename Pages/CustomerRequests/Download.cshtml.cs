using Estimator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Estimator.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using NPOI.HPSF;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections;
using DocumentFormat.OpenXml.Bibliography;

namespace Estimator.Pages.CustomerRequests
{
    public class DownloadModel :Estimator.Pages.BaseEstimatorPage
    {
        public DownloadModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {

          //  ErrorMessage = "";
          //  ImportStep = 1;

        }
        public IActionResult  OnGet(string reportType , int id, int year)
        {
          
            string fileName = _appEnvironment.WebRootPath + "/Files/" + reportType + id.ToString() + ".xlsx" ;
            //получаем заявку
            CustomerRequest request =  _context.CustomerRequests
                .Include(c => c.Customer)
                .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                .Include(e => e.RequestElementTypes)
                    .ThenInclude(e => e.RequestOperations)
                        .ThenInclude(e => e.TestChainItem)
                            .ThenInclude(e => e.TestActions)
                               .ThenInclude(i => i.Qualification)
                   .Include(e => e.RequestElementTypes)
                    .ThenInclude(e => e.RequestOperations)
                        .ThenInclude(e => e.TestChainItem)
                            .ThenInclude(e => e.Operation)
                                .ThenInclude(e => e.OperationGroup)
                    .Include(e => e.RequestElementTypes)
                        .ThenInclude(e => e.ElementType)
                .AsNoTracking()
                .FirstOrDefault(m => m.CustomerRequestID == id);

            ElementImport ElementImport = _context.ElementImports
                .Include(e => e.XLSXElementTypes)
                .FirstOrDefault(m => m.CustomerRequest.CustomerRequestID == id);

            ElementImport.CustomerRequest = request;
            request.ElementImport = ElementImport;

            request.CompanyHistory = _context.CompanyHistories
                  .Include(c => c.Staff)
                       .ThenInclude(e => e.Qualification)
            .Include(c => c.CalcFactors)
                  .FirstOrDefault(m => m.YearOfNorms == year);

            // request.CalculateGroups();
            ElementImport.CalculateXLSXCosts();

            XSLXWriter writer = new XSLXWriter(fileName);
            
            writer.CreateXSLXFileElements(ElementImport);

           return File ("/files/" + reportType  + id.ToString() + ".xlsx", "text/plain", reportType + id.ToString() + ".xlsx"); 

        }
        
    }
}
