﻿using Estimator.Models;
using Estimator.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Pages.CustomerRequests
{
    public class EditModel : CustomerRequestPageModel
    {

        public EditModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }
        public ElementImport ElementImport;
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
                .Include(c => c.RequestElementTypes)
                    .ThenInclude(c => c.ElementType)
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);

            ElementImport = _context.ElementImports
                   .FirstOrDefault(m => m.CustomerRequest.CustomerRequestID == id);

            // запролняем типы элементов
            PopulateAssignedElementTypes(CustomerRequest);
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

                var errors = ModelState.Values.SelectMany(v => v.Errors);
                return Page();
            }
            if (id == null)
            {
                return NotFound();
            }
            //Элемент импорт тоже пригодиться
            ElementImport = _context.ElementImports
               .FirstOrDefault(m => m.CustomerRequest.CustomerRequestID == id);
            //получаем текущую заявку
            var requestToUpdate = await _context.CustomerRequests
                .Include(c => c.Customer)
                .Include(c => c.Program)
                    .ThenInclude(c => c.ElementntTypes)
                .Include(c => c.RequestElementTypes)
                    .ThenInclude(c => c.ElementType)
                  .Include(c => c.RequestElementTypes)
                    .ThenInclude(c => c.RequestOperations)
                        .ThenInclude(c => c.TestChainItem)
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);

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
                 i => i.Description)
                )
            {
                UpdateAssignedElementTypes(elementTypes, requestToUpdate);

                if (requestToUpdate.Program.AllowEditChain)
                {
                    UpdateRequestOperations(requestOperationGroupViews, requestToUpdate);
                }
                await _context.SaveChangesAsync();
                return RedirectToPage("./report", new {id = id });
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
