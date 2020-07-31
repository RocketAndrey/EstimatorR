using Estimator.Models;
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

namespace Estimator.Pages.CustomerRequests
{

    public class ReportModel : CustomerRequestPageModel
    {

        public int Mode { get; set; }
        public ElementImport ElementImport;

        public ReportModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {
            Mode = 1;            
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

            if (CustomerRequest == null)
            {
                return NotFound();
            }
            //заполняем аблицу браков
            if (Mode == 6)
            {
                FillDefectedTypes();
            }
            //сортируем
            CustomerRequest.RequestElementTypes = CustomerRequest.RequestElementTypes.OrderBy(e => e.Order);

            ViewData["YearOfNorms"] = new SelectList(_context.CompanyHistories , "YearOfNorms", "YearOfNorms");

            //получаем показатели рассчитываеомго года
            if (year != null)
            {
                YearOfNoms = (int)year;

            }
            SelectedYear = YearOfNoms;

            SetCompanyHistory(YearOfNoms);
  
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id, int? mode)

        {

            return RedirectToPage("Report", new { id , mode, year = SelectedYear  });

        }

        [BindProperty]
        public int SelectedYear { get; set; }

        private void FillDefectedTypes()
        {
            //получаем список элементов 
             ElementImport = _context.ElementImports
                       .Include(e => e.XLSXElementTypes)
                      .FirstOrDefault(m => m.CustomerRequest.CustomerRequestID == CustomerRequest.CustomerRequestID);
            //если нет импорта то и нет элементов
            if (ElementImport == null) return;
            ElementImport.CustomerRequest = CustomerRequest;

            SetAsuContext();
            

            //  List<XLSXElementType> list = _context.XLSXElementTypes.FromSqlRaw(selectStr, PrepareStr(elementName), id, programid).ToList();
            ElementImport.DefectedTypes = new System.Collections.Generic.List<DefectedType>();

            foreach (XLSXElementType type in ElementImport.XLSXElementTypes)
            {
                string selectStr = "select l.LotID as ID, l.PrefixNumber + '-' + CAST(l.Number AS VARCHAR(32)) + (CASE WHEN(l.SuffixNumber IS NULL) THEN('') ELSE l.SuffixNumber END) AS[ProtokolNumber]," +
                "w.TypeNominal , w.TU1 + ' ' + w.TU2 AS[TY], l.ManufacturingDate,d.[Description], d.TU as NormTY,d.Unrecommend ,d.RFA " +
                "from Defect d, [DefectTypes] dt,[dbo].[RouteOperation] r, lot l, Wares w " +
                "where dt.DefectTypeId = d.DefectTypeId and r.RouteOperationId = d.RouteOperationId and l.LotId = r.LotId and w.WareId = l.WareId " +
                 "and w.TypeNominal like '%{0}%'";
               
                string elementName = type.ElementName.Trim().Substring(0, type.ElementName.Trim ().Length > 15?15:type.ElementName.Trim().Length );
                selectStr = String.Format(selectStr, elementName);


                System.Collections.Generic.List <DefectedType> defTypes = _asuContext.DefectedTypes.FromSqlRaw(selectStr).ToList();
                ElementImport.DefectedTypes.AddRange(defTypes);

            }
            int i = ElementImport.DefectedTypes.Count;


        }
    }
}
