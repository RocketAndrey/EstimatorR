﻿using Estimator.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.AspNetCore.Authorization;

namespace Estimator.Pages.CustomerRequests
{

    public class ReportModel : CustomerRequestPageModel
    {

        public int Mode { get; set; }

        public ReportModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {
            Mode = 1;            
        }
        


        public async Task<IActionResult> OnGetAsync(int? id, int? mode)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (mode == null)
            {
                Mode = 1;
            }
            else
            {
                Mode = mode.Value;
            }

            CustomerRequest = await _context.CustomerRequests
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
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);

            if (CustomerRequest == null)
            {
                return NotFound();
            }
            //сортируем
            CustomerRequest.RequestElementTypes = CustomerRequest.RequestElementTypes.OrderBy(e => e.Order);

            //получаем показатели рассчитываеомго года
            SetCompanyHistory(YearOfNoms);
            //CustomerRequest.CompanyHistory=CompanyHistory;

            // foreach (var item in CustomerRequest.OperationGroups)

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(IFormFile uploadedFile)

        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;

                // сохраняем файл в папку Files в каталоге wwwroot

                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
            }

            return Page();
        }
    }
}
