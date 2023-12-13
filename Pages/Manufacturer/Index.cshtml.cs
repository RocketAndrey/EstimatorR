using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Estimator.Pages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Estimator.Pages.Manufacturer
{
    public class IndexModel : BaseEstimatorPage
    {

        public IndexModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {

        }
        public void OnGet()
        {
        }
    }
}
