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
    /// <summary>
    /// базовый класс для страницы модели страницы редактирования  заявки
    /// </summary>
    public class CustomerRequestPageModel : PageModel

    {
        /// <summary>
        /// Типы ЭКБ для заявки
        /// </summary>
        public List<AssignedRequestElementType> AssignedElementsList;

        public void PopulateAssignedElementTypes(EstimatorContext _context, CustomerRequest customerRequest)
        {

            IQueryable<RequestElementType> elementTypesIQ = _context.RequestElementTypes.Where(s => s.CustomerRequestID == customerRequest.CustomerRequestID);
            //сортируем
            elementTypesIQ= elementTypesIQ.OrderBy(r => r.ElementType.Order);
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

    }
}
