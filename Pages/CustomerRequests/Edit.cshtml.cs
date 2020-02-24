using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Estimator.Data;
using Estimator.Models;
using Estimator.Models.ViewModels;


namespace Estimator.Pages.CustomerRequests
{
    public class EditModel :PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;


        public List<AssignedRequestElementType> AssignedElementsList;
        public List<RequestOperationGroupView> RequestOperationGroupViews;

        public EditModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CustomerRequest CustomerRequest { get; set; }
       // public IList <RequestElementType> RequestElementTypes { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CustomerRequest = await _context.CustomerRequests
                .Include(c => c.Customer)
                .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                .Include(c=>c.RequestElementTypes)
                    .ThenInclude(c=>c.ElementType)
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);

            // запролняем типы элементов
            PopulateAssignedElementTypes( CustomerRequest);
            //Заполняем операции
            PopulateOperations(CustomerRequest);
        
            if (CustomerRequest == null)
            {
                return NotFound();
            }
            // Добавляем типы элементов для новой заявки
           
           ViewData["CustomerID"] = new SelectList(_context.Customers, "CustomerID", "Name");
           ViewData["TestProgramID"] = new SelectList(_context.TestPrograms, "TestProgramID", "Name");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id, AssignedRequestElementType[] elementTypes, RequestOperationGroupView[] requestOperationGroupViews)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (id==null)
            {
                return NotFound();
            }

            //получаем текущую заявку
            var requestToUpdate= await _context.CustomerRequests
                .Include(c => c.Customer)
                .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                .Include(c => c.RequestElementTypes)
                    .ThenInclude(c => c.ElementType)
                  .Include(c => c.RequestElementTypes)
                    .ThenInclude(c => c.RequestOperations)
                        .ThenInclude(c=>c.TestChainItem)
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);

            if (requestToUpdate==null)
            {
                // заявка не найдена
                return NotFound();
            }
            // Обновляет извлеченную сущность CustomerRequest, используя значения из связывателя модели. TryUpdateModel позволяет предотвратить чрезмерную передачу данных.
            if (await TryUpdateModelAsync<CustomerRequest>(
                requestToUpdate,
                "CustomerRequest",
                i => i.RequestNumber,
                i => i.RequestDate,
                i => i.CustomerID,
                 i => i.Description)
                )
            {
                UpdateAssignedElementTypes(elementTypes, requestToUpdate);
                UpdateRequestOperations(requestOperationGroupViews, requestToUpdate);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            else
            {
                // не получилось обновить 
                PopulateAssignedElementTypes( requestToUpdate);
                return Page();
            }
            

               
        }
       
        public void PopulateAssignedElementTypes( CustomerRequest customerRequest)
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
                        ItemCount = item.ItemCount
                       
                    });
                }

            }


        }
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
        public void UpdateAssignedElementTypes(AssignedRequestElementType[] elementTypes, CustomerRequest customerRequestToUpdate)
        {
          //  IQueryable<RequestElementType> elementTypesIQ = _context.RequestElementTypes.Where(s => s.CustomerRequestID == customerRequestToUpdate.CustomerRequestID);
            foreach (var element in customerRequestToUpdate.RequestElementTypes)
            {
                foreach (var updElement in elementTypes)
                {
                    if (element.RequestElementTypeID == updElement.RequestElementTypeID)
                    {
                        element.BatchCount = updElement.BatchCount;
                        element.ItemCount = updElement.ItemCount;
                        element.KitCount = updElement.MissingKitCount;
                    }
                }
            }

        }
        public void UpdateRequestOperations(RequestOperationGroupView[] operationTypes, CustomerRequest customerRequestToUpdate)
        {
          //  IQueryable<RequestElementType> retIQ = _context.RequestElementTypes.Where(s => s.CustomerRequestID == customerRequestToUpdate.CustomerRequestID)
            //    .Include(s => s.RequestOperations);

                                                     
            foreach (var element in customerRequestToUpdate.RequestElementTypes)
            {
                foreach (var operation in element.RequestOperations)
                {
                    foreach (var updElement in operationTypes)
                    {
                        if (operation.TestChainItem.OperationID == updElement.OperationID)
                        {
                            operation.IsExecute = updElement.IsExecute;
                            operation.ExecuteCount = updElement.ExecuteCount;
                            operation.SampleCount = updElement.SampleCount;
                        }
                    }
                }
             
            }

        }
        private bool CustomerRequestExists(int id)
        {
            return _context.CustomerRequests.Any(e => e.CustomerRequestID == id);
        }
    }
}
