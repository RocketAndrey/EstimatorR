﻿using Estimator.Models;
using Estimator.Models.ViewModels;
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
using System.Threading.Tasks;

namespace Estimator.Pages.CustomerRequests
{
    /// <summary>
    /// базовый класс для страницы модели страницы редактирования  заявки
    /// </summary>
    public class CustomerRequestPageModel : BaseEstimatorPage

    {
        public CustomerRequestPageModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {

        }

        [BindProperty]
        public CustomerRequest CustomerRequest { get; set; }

        protected async Task SetCustomerReguest( int id, int year)
        {
      
            //получаем заявку
            this.CustomerRequest =  await _context.CustomerRequests
                .Include(c => c.Customer)
                .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                .Include(c => c.Program)
                    .ThenInclude(c => c.Templates)
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
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);
            
            CustomerRequest.ElementImport = await _context.ElementImports
               .Include(e => e.XLSXElementTypes).ThenInclude(e=>e.PriceHistory)
               .Include(e => e.XLSXElementTypes).ThenInclude(x=>x.Company)
               .Include(e => e.XLSXElementTypes).ThenInclude(x => x.PriceHistorySource)
               .AsNoTracking()
               .FirstOrDefaultAsync(m => m.CustomerRequest.CustomerRequestID == id);

            if (CustomerRequest.ElementImport != null)
            {
                CustomerRequest.ElementImport.CustomerRequest = this.CustomerRequest;
                CustomerRequest.ElementImport.CustomerRequest.CustomerRequestID = id;
                
            }
            this.SetCompanyHistory(year);
            // Родительская заявка
            if ((CustomerRequest.ParentCustomerRequestID ?? 0) != 0)
            {
                CustomerRequest.ParentCustomerRequest = await _context.CustomerRequests
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
                .FirstOrDefaultAsync(m => m.CustomerRequestID == CustomerRequest.ParentCustomerRequestID);

                CustomerRequest.ParentCustomerRequest.CompanyHistory = CustomerRequest.CompanyHistory;
                CustomerRequest.ParentCustomerRequest.Rate = CustomerRequest.Rate;

            }
            //Дочерняя заявка
            if (ChildCustomerRequestExists(CustomerRequest.CustomerRequestID))
            {
                CustomerRequest.ChildCustomerRequestID = ChildCustomerReguestID;
                CustomerRequest.ChildCustomerRequest =  await _context.CustomerRequests
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
               .FirstOrDefaultAsync(m => m.CustomerRequestID == CustomerRequest.ChildCustomerRequestID);

                CustomerRequest.ChildCustomerRequest.CompanyHistory = CustomerRequest.CompanyHistory;
                CustomerRequest.ChildCustomerRequest.Rate = CustomerRequest.Rate;
            }
            if (CustomerRequest.ElementImport !=null)   CustomerRequest.ElementImport.CalculateXLSXCosts(); 
            }

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
        public async Task PopulateAssignedElementTypes(CustomerRequest customerRequest)
        {

            List<RequestElementType> elementTypesIQ = await _context.RequestElementTypes
                .Include(e=>e.ElementType)
                .AsNoTracking()
                .Where(s => s.CustomerRequestID == customerRequest.CustomerRequestID).ToListAsync();
            //сортируем
            if (elementTypesIQ.Count > 0)
            {
                elementTypesIQ = elementTypesIQ.OrderBy(r => r.ElementType?.Order ?? 0).ToList();
            }
            
            AssignedElementsList = new List<AssignedRequestElementType>();
           
            if (elementTypesIQ != null)
            {
                foreach (var item in elementTypesIQ)
                {
                    AssignedElementsList.Add(new AssignedRequestElementType
                    {
                        RequestElementTypeID = item.RequestElementTypeID,
                        Name = item.ElementType?.Name??"",
                        BatchCount = item.BatchCount,
                        ItemCount = item.ItemCount,
                        MissingKitCount = item.KitCount

                    });
                }

            }


        }
        /// <summary>
        /// Получение свойств предприятия по году
        /// </summary>
        /// <param name="year"></param>
        protected  void SetCompanyHistory(int year)
        {
            try
            {
                CustomerRequest.CompanyHistory =  _context.CompanyHistories
                   .Include(c => c.Staff)
                        .ThenInclude(e => e.Qualification)
                   .Include(c => c.CalcFactors)
                   .AsNoTracking()
                   .FirstOrDefault(m => m.YearOfNorms == year);
            }
            catch 
            {
                throw new Exception("Не удалось установить нормативы!");
            }

        }

        public int ChildCustomerReguestID
        {
            get
            {
                return _context.CustomerRequests.FirstOrDefault(e => e.ParentCustomerRequestID == CustomerRequest.CustomerRequestID).CustomerRequestID;

            }
        }
        public bool ChildCustomerRequestExists(int id)
        {
            return _context.CustomerRequests.Any(e => e.ParentCustomerRequestID == id);
        }

    }
}
