﻿using Estimator.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using Microsoft.AspNetCore.Authorization;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Estimator.Models.AsuViews;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.InkML;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Pages.CustomerRequests
{

    public class ReportModel : CustomerRequestPageModel
    {

        public int Mode { get; set; }
        public ElementImport ElementImport;
        public int  childCustomer;

        public ReportModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {
            Mode = 1;
            SelectedTab = 1; 
        }
        
        public async Task<IActionResult> OnGetAsync(int? id, int? mode, int? year)
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
           // HttpContext.Request.BodyReader.
            // выбрання вкладка
            if (HttpContext.Request.Cookies.ContainsKey("SelectedTab"))
            {

                int i =1 ;
        

                if (Int32.TryParse(HttpContext.Request.Cookies["SelectedTab"], out i ))
                {
                    SelectedTab = i; 
                }
            }
            
            //получаем заявку
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
                    .Include(e => e.RequestElementTypes)
                        .ThenInclude (e=>e.ElementType)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.CustomerRequestID == id);

            CustomerRequest.ElementImport = _context.ElementImports
               .Include(e => e.XLSXElementTypes)

                  .FirstOrDefault(m => m.CustomerRequest.CustomerRequestID == id);
            if (CustomerRequest == null)
            {
                return NotFound();
            }
            //получаем показатели рассчитываеомго года
            if (year != null)
            {
                YearOfNoms = (int)year;

            }
            //получаем кооф.сложности
            RequestRate = CustomerRequest.StringRate; 
            SelectedYear = YearOfNoms;

            SetCompanyHistory(YearOfNoms);
            //сортируем
            CustomerRequest.RequestElementTypes = CustomerRequest.RequestElementTypes.OrderBy(e => e.Order);

            ViewData["YearOfNorms"] = new SelectList(_context.CompanyHistories, "YearOfNorms", "YearOfNorms");

            // Родительская заявка
            if ((CustomerRequest.ParentCustomerRequestID?? 0)!=0)
            {
                CustomerRequest.ParentCustomerRequest= await _context.CustomerRequests
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
            }
            //Дочерняя заявка
            if (ChildCustomerRequestExists (CustomerRequest.CustomerRequestID ))
            {
                CustomerRequest.ChildCustomerRequestID = ChildCustomerReguestID;
                CustomerRequest.ChildCustomerRequest  = await _context.CustomerRequests
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
            }

            FillDefectedTypes();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id, int? mode)


        {
            HttpContext.Response.Cookies.Append("SelectedTab",SelectedTab.ToString());
            //получаем заявку
            if (id > 0)
            {
                CustomerRequest = await _context.CustomerRequests
               .FirstOrDefaultAsync(m => m.CustomerRequestID == id);
                if (CustomerRequest !=null)
                {
                    // Обновляет извлеченную сущность CustomerRequest, используя значения из связывателя модели. TryUpdateModel позволяет предотвратить чрезмерную передачу данных.
                    CustomerRequest.StringRate = RequestRate;
                    _context.SaveChanges(); 
                }
            }

            return RedirectToPage("Report", new { id , mode, year = SelectedYear  });

        }

        [BindProperty]
        public int SelectedYear { get; set; }
        [BindProperty]
        public int SelectedTab { get; set; }
       
        [BindProperty]
        [Display(Name = "Коэффициент сложности")]
        [Required(ErrorMessage = "Введитe число с плавающей точкой")]
        [RegularExpression("^[-+]?[0-9]*[,]?[0-9]+(?:[eE][-+]?[0-9]+)?$",ErrorMessage ="Введите число в формате числа с плавающей запятой")]
        [DisplayFormat(DataFormatString = "{0:F4}")]
        public string RequestRate { get; set; }
        private void FillDefectedTypes()
        {
            //получаем список элементов 
             ElementImport = _context.ElementImports
                       .Include(e => e.XLSXElementTypes)
                      .FirstOrDefault(m => m.CustomerRequest.CustomerRequestID == CustomerRequest.CustomerRequestID);
            
            //если нет импорта то и нет элементов
            if (ElementImport == null) return;

            ElementImport.CustomerRequest = CustomerRequest;
            //считаем стоимости
            ElementImport.CalculateXLSXCosts();

            Dictionary<Int64, DefectedType> returnTypes = new Dictionary<Int64, DefectedType>();
            SetAsuContext();
            

            //  List<XLSXElementType> list = _context.XLSXElementTypes.FromSqlRaw(selectStr, PrepareStr(elementName), id, programid).ToList();
            ElementImport.DefectedTypes = new System.Collections.Generic.List<DefectedType>();

            foreach (XLSXElementType type in ElementImport.XLSXElementTypes)
            {
                string selectStr = "select d.DefectId as ID, l.PrefixNumber + '-' + CAST(l.Number AS VARCHAR(32)) + (CASE WHEN(l.SuffixNumber IS NULL) " +
                "THEN('') ELSE l.SuffixNumber END) AS[ProtokolNumber], w.TypeNominal , w.TU1 + ' ' + w.TU2 AS[TY], d.[Description], "+
                "d.TU as NormTY, d.Unrecommend , d.RFA, d.DefectCount as DefectCount " +
                "from Defect d,[dbo].[RouteOperation] r, lot l, Wares w "+
                "where r.RouteOperationId = d.RouteOperationId and l.LotId = r.LotId and w.WareId = l.WareId "+
                "and w.TypeNominal like N'{0}'" ;
               
                string elementName = type.ElementName.Trim().Substring(0, type.ElementName.Trim ().Length > 15?15:type.ElementName.Trim().Length );
                selectStr = String.Format(selectStr, elementName);


                System.Collections.Generic.List <DefectedType> defTypes = _asuContext.DefectedTypes.FromSqlRaw(selectStr).ToList();

                foreach (DefectedType item in defTypes)
                {
                    if(!returnTypes.ContainsKey(item.ID))
                    {
                        returnTypes.Add(item.ID, item);

                    }
                }

                ElementImport.DefectedTypes.AddRange(defTypes);

            }
            ElementImport.DefectedTypes = returnTypes.Values.ToList();


        }

        /// <summary>
        /// полная стоимость дополнительные и сертификационные испытания
        /// </summary>
        public decimal FullTotalCost
        {
            get
            {
                decimal cost = CustomerRequest.TotalCost + (CustomerRequest.ParentCustomerRequest?.TotalCost?? 0) + (CustomerRequest.ChildCustomerRequest?.TotalCost ??0);
                return cost;

            }
        
        }
    }
} 
