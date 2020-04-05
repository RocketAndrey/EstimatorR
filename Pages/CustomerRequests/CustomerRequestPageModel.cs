using Estimator.Models;
using Estimator.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace Estimator.Pages.CustomerRequests
{
    /// <summary>
    /// базовый класс для страницы модели страницы редактирования  заявки
    /// </summary>
    public class CustomerRequestPageModel : PageModel

    {
        protected Estimator.Data.EstimatorContext _context;
        protected IWebHostEnvironment _appEnvironment;
        protected IConfiguration _configuration;

        [BindProperty]
        public CustomerRequest CustomerRequest { get; set; }

        public CompanyHistory CompanyHistory { get; set; }
        public List<AssignedRequestElementType> AssignedElementsList;
        public List<RequestOperationGroupView> RequestOperationGroupViews;
        /// <summary>
        /// операции текущей заявки
        /// </summary>
        /// <param name="customerRequest"></param>
        public void PopulateOperations(CustomerRequest customerRequest)

        {
            string query = "SELECT [Operation].OperationID,[Operation].Name,[RequestOperation].SampleCount, [IsExecute],[ExecuteCount],[TestChainItem].[Order] ,[OperationGroup].Code as OperationGroupCode " +
                            "FROM[RequestOperation],[TestChainItem],[Operation],[dbo].[RequestElementType],[OperationGroup] WHERE[RequestOperation].[TestChainItemID]= [TestChainItem].TestChainItemID " +
                                "and[dbo].[Operation].OperationID= [TestChainItem].OperationID and[RequestOperation].RequestElementTypeID=[dbo].[RequestElementType].RequestElementTypeID " +
                                "and [RequestElementType].CustomerRequestID ={0} and [OperationGroup].OperationGroupID=[Operation].OperationGroupID GROUP BY[Operation].OperationID, [Operation].Name,[RequestOperation].SampleCount,[ExecuteCount], [OperationGroup].Code,  [IsExecute],[TestChainItem].[Order] ORDER BY[TestChainItem].[Order]";
            RequestOperationGroupViews = _context.RequestOperationGroupViews.FromSqlRaw(query, customerRequest.CustomerRequestID).ToList();

        }
        public void PopulateAssignedElementTypes(CustomerRequest customerRequest)
        {

            IQueryable<RequestElementType> elementTypesIQ = _context.RequestElementTypes.Where(s => s.CustomerRequestID == customerRequest.CustomerRequestID);
            //сортируем
            elementTypesIQ = elementTypesIQ.OrderBy(r => r.ElementType.Order);
            AssignedElementsList = new List<AssignedRequestElementType>();
            if (elementTypesIQ != null)
            {
                foreach (var item in elementTypesIQ)
                {
                    AssignedElementsList.Add(new AssignedRequestElementType
                    {
                        RequestElementTypeID = item.RequestElementTypeID,
                        Name = item.ElementType.Name,
                        BatchCount = item.BatchCount,
                        ItemCount = item.ItemCount,
                        MissingKitCount = item.KitCount

                    });
                }

            }


        }

        protected async void setCompanyHistory(int year)
        {
            CustomerRequest.CompanyHistory = await _context.CompanyHistories
               .Include(c => c.Staff)
                    .ThenInclude(e => e.Qualification)
               .Include(c => c.CalcFactors)
               .FirstOrDefaultAsync(m => m.YearOfNorms == year);

        }
    }
}
