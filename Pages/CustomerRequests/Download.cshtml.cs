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
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Estimator.Pages.CustomerRequests
{
    public class DownloadModel :CustomerRequestPageModel
    {
        public DownloadModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {

          //  ErrorMessage = "";
          //  ImportStep = 1;

        }
       
        public string ErrorMessage { get; set; }
        public async Task<IActionResult> OnGet(string reportType , int id, int year)
        {


            string fileName;

            await  base.SetCustomerReguest(id,year);
           
          

            XSLXWriter writer;
            string errorMessage="";
            fileName = _appEnvironment.WebRootPath + "/Files/" + reportType + id.ToString() + ".xlsx";

            if (reportType == "elements")
            {
                
                writer = new XSLXWriter(fileName);

                if (writer.CreateXSLXFileElements(CustomerRequest.ElementImport,out errorMessage))
                {

                    return File("/files/" + reportType + id.ToString() + ".xlsx", "text/plain", reportType + id.ToString() + ".xlsx");
                }
            }
            else if (reportType == "FillElementList")
            {
                fileName = _appEnvironment.WebRootPath + "/Files/"  + id.ToString() + ".xlsx";
                writer = new XSLXWriter (fileName);
               
               if ( writer.AddReportDataToXLSX(CustomerRequest.ElementImport,out errorMessage))
               {
                    return File("/files/" + reportType + id.ToString() + ".xlsx", "text/plain", reportType + id.ToString() + ".xlsx");
               }

            }
            else if (reportType == "Invoce")
             {
                writer = new XSLXWriter(fileName);

                if (writer.CreateInvoce(CustomerRequest.ElementImport, out errorMessage))
                {

                    return File("/files/" + reportType + id.ToString() + ".xlsx", "text/plain", reportType + id.ToString() + ".xlsx");
                }
            }
            else 
            {
                errorMessage = string.Format("Тип отчета {0} не найден", reportType); 
            }
              

            
            ErrorMessage = errorMessage;
            return Page();
        }
        
    }
}
