using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Estimator.Pages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;


namespace Estimator.Pages.Price
{
    public class IndexModel : BaseEstimatorPage
    {
        public void OnGet()
        {
        }
        public IndexModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {

        }
    }
}
