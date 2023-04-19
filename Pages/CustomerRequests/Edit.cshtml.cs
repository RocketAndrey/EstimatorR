using Estimator.Models;
using Estimator.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
using DocumentFormat.OpenXml.Drawing;
using Microsoft.AspNetCore.Authorization;

namespace Estimator.Pages.CustomerRequests
{

    public class EditModel : CustomerRequestPageModel
    {
        public EditModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {

        }
        public ElementImport ElementImport;
        public TestProgram ChildProgram;
        public string strRate; 
        public async Task<IActionResult> OnGetAsync(int? id, int? parentid)
        {
            if (id == null & parentid == null)
            {
                return NotFound();
            }
            if ((parentid ?? 0) > 0)
            {
                id = CreateRequestFromParent(parentid.Value);
                return RedirectToPage("./edit", new { id = id });
            }

            CustomerRequest = await _context.CustomerRequests
                .Include(c => c.Customer)
                .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                .Include(c => c.RequestElementTypes)
                    .ThenInclude(c => c.ElementType)
                .Include(c => c.Program)
                    .ThenInclude(c => c.Templates)
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);

            ElementImport = _context.ElementImports
                   .Include(c=>c.XLSXElementTypes)     
                   .FirstOrDefault(m => m.CustomerRequest.CustomerRequestID == id);
            
            strRate = CustomerRequest.Rate.ToString();

            CustomerRequest.ElementImport = ElementImport; 

            // запролняем типы элементов
            PopulateAssignedElementTypes(CustomerRequest);
            //Заполняем операции
            PopulateOperations(CustomerRequest);

            if (CustomerRequest == null)
            {
                return NotFound();
            }
            // Добавляем типы элементов для новой заявки

            ViewData["CustomerID"] = new SelectList(_context.Customers.OrderBy(e => e.Name), "CustomerID", "Name");
            ViewData["TestProgramID"] = new SelectList(_context.TestPrograms, "TestProgramID", "Name");
            ViewData["TestProgramTemplateID"] = new SelectList(CustomerRequest.Program.Templates, "TestProgramTemplateID", "TemplateName");

            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id, AssignedRequestElementType[] elementTypes, RequestOperationGroupView[] requestOperationGroupViews)
        {
            if (!ModelState.IsValid)
            {

                var errors = ModelState.Values.SelectMany(v => v.Errors);
                return Page();
            }
            if (id == null)
            {
                return NotFound();
            }
            //Элемент импорт тоже пригодиться
            ElementImport = _context.ElementImports
                .AsNoTracking()
                .FirstOrDefault(m => m.CustomerRequest.CustomerRequestID == id);
            //получаем текущую заявку
            var requestToUpdate = await _context.CustomerRequests
                .Include(c => c.Customer)
                .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                .Include(c => c.Program)
                    .ThenInclude(e => e.Templates)
                .Include(c => c.RequestElementTypes)
                    .ThenInclude(c => c.ElementType)
                  .Include(c => c.RequestElementTypes)
                    .ThenInclude(c => c.RequestOperations)
                        .ThenInclude(c => c.TestChainItem)
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);

            requestToUpdate.ModificateDate = System.DateTime.Now;
            requestToUpdate.ElementImport = ElementImport; 

            if (UserID > 0)
            {
                requestToUpdate.LastModificateUserID = UserID;
            }
            if (requestToUpdate == null)
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
                i=>i.UseImport, 
                 i => i.Description, i => i.UseTemplate, i => i.TestProgramTemplateID, i => i.StringRate)
                )
            {
                if (!requestToUpdate.UseImport)
                {
                    UpdateAssignedElementTypes(elementTypes, requestToUpdate);
                }
                if (requestToUpdate.Program.AllowEditChain)
                {
                    UpdateRequestOperations(requestOperationGroupViews, requestToUpdate);
                }
                await _context.SaveChangesAsync();

                return RedirectToPage("./edit", new { id = id });
            }
            else
            {
                // не получилось обновить 
                PopulateAssignedElementTypes(requestToUpdate);
                return Page();
            }



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
            int templateID;
            TestProgramTemplate template = null;

            if (customerRequestToUpdate.UseTemplate)
            {
                templateID = customerRequestToUpdate.TestProgramTemplateID;
                template = _context.TestProgramTemplates
                    .Include(e => e.TemplateItems)
                    .AsNoTracking()
                    .FirstOrDefault(c => c.TestProgramTemplateID == customerRequestToUpdate.TestProgramTemplateID);
            }

            foreach (var element in customerRequestToUpdate.RequestElementTypes)
            {
                //получаем шаблон
             

                foreach (var operation in element.RequestOperations)
                {
                    foreach (var updElement in operationTypes)
                    {
                      
                        if (operation.TestChainItem.OperationID == updElement.OperationID)
                        {
                            if (customerRequestToUpdate.UseTemplate  & template!=null)
                            {

                                TestProgramTemplateItem item = template?.TemplateItems?.FirstOrDefault(c => c.OperationID == updElement.OperationID);
                                   
                                if (item != null )
                                {
                                    operation.IsExecute = item.IsExecute;
                                    operation.ExecuteCount = item.ExecuteCount;
                                }
                                else
                                {
                                    operation.IsExecute = updElement.IsExecute;
                                    operation.ExecuteCount = updElement.ExecuteCount;
                                }
                            }
                            else
                            {
                                operation.IsExecute = updElement.IsExecute;
                                operation.ExecuteCount = updElement.ExecuteCount;
                               
                            }
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
      
        public int ChildProgramID(int programID)
        {
           
                    ChildProgram= _context.TestPrograms
                        .FirstOrDefault(m => m.ParentProgramID == programID);
                    return ChildProgram?.TestProgramID?? 0;
  
        }
       
        private int CreateRequestFromParent(int parentID)
        {
           
            //Родительская заявка
            CustomerRequest parentCR = _context.CustomerRequests
                 .Include(c => c.Customer)
                 .Include(c => c.Program)
                 .Include(c => c.RequestElementTypes)
                     .ThenInclude(c => c.ElementType)
                 .FirstOrDefault(m => m.CustomerRequestID==  parentID);
            //новая заявка 
            CustomerRequest newCR = new CustomerRequest 
            { 
                Customer=parentCR.Customer ,
            TestProgramID =ChildProgramID(parentCR.Program.TestProgramID ) , RequestDate= parentCR.RequestDate,
            Description= parentCR.Description + ". Создана из заявки "+ parentID+".",
            RequestNumber =parentCR.RequestNumber, ParentCustomerRequestID= parentCR.CustomerRequestID 
            };

            //сохранить
            _context.CustomerRequests.Add(newCR);
            int num = _context.SaveChanges();
            int id = newCR.CustomerRequestID;

            newCR  =  _context.CustomerRequests
              .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                        .ThenInclude(e => e.ChainItems)
                            .ThenInclude(r => r.Operation)
                .Include(c => c.RequestElementTypes)
                .FirstOrDefault(m => m.CustomerRequestID == id);


            if (!newCR.IsProceed)
            {
                List<RequestElementType> retList = new List<RequestElementType>();

                foreach (ElementType e in newCR.Program.ElementntTypes)

                {
                    RequestElementType r = new RequestElementType { ElementType =e,Order = e.Order};

                    r.BatchCount = 0;
                    r.ItemCount = 0;
                    r.KitCount = 0;
                    //перебираем элементы родительской заявки

                    foreach (var parentRET in parentCR.RequestElementTypes)
                    {
                        if (parentRET.ElementType.ChildElementTypeID ==e.ElementTypeID)
                        {
                            //копируем из родительского элемента
                            r.KitCount += parentRET.KitCount;
                            r.BatchCount += parentRET.BatchCount;
                            r.ItemCount += parentRET.ItemCount;
                        }
                    }
                    List<RequestOperation> roList = new List<RequestOperation>();

                    foreach (TestChainItem tci in e.ChainItems)
                    {
                        RequestOperation rO = new RequestOperation
                        {
                            TestChainItem = tci,
                            RequestElementType = r,
                            IsExecute = tci.Operation.IsExecuteDefault,
                            SampleCount = tci.Operation.SampleCount,
                            ExecuteCount = 1
                        };
                        roList.Add(rO);

                        r.RequestOperations = roList;

                    }
                    retList.Add(r);


                }
                newCR.RequestElementTypes = retList;


                newCR.IsProceed = true;
            }

             num = _context.SaveChanges();

            return newCR.CustomerRequestID  ;
        }
    }
}
