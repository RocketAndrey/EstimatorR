using Estimator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

using Microsoft.AspNetCore.Hosting;
using System.Drawing;
using System.Linq;
using Estimator.Helpers;
using System.ComponentModel.DataAnnotations;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NuGet.Packaging.Signing;
using NPOI.XWPF.UserModel;
using NuGet.Protocol;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NPOI.SS.Formula.Functions;
using System.Diagnostics;
using Estimator.Migrations;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace Estimator.Pages.Price
{
    public class ImportModel : PageModel
    {
        public string Message { get; set; }

        private IWebHostEnvironment Environment;

        Estimator.Data.EstimatorContext context;
        public bool _disable { get; set; }
        public bool _showDiff { get; set; }

        public List<List<string>> tmpF = new List<List<string>>();

        public List<Estimator.Models.Price> addPrice;
        public ImFileData imFiles { get; set; } = new();

        public char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public int size = 0;
        public int countExistPrice = 0;
        [Display(Name = "Наименование")]
        public ColumnNames _codeCol { get; set; }

        public List<Models.PricePropertyName> _pricePropertyName = new List<Models.PricePropertyName>();
                
        public enum ColumnNames
        {

           A = 1, B = 2, C = 3, D = 4, E = 5, F = 6, G = 7, H = 8, I = 9, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z, 
        }
        public enum ColumnNamesDifficult
        {

            Отсутвует = 0, A = 1, B = 2, C = 3, D = 4, E = 5, F = 6, G = 7, H = 8, I = 9, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z,
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            TempData["PriceListId"] = (int)id;

            var existPrices = context.Prices.Where(x => x.PriceListId == id);

            if (existPrices.Any())
            {
                countExistPrice = existPrices.Count();
            }

            int priceItemType = context.PriceLists.First(x => x.PriceListId == id).PriceItemTypeID; //Получаем ID прайса
            TempData["priceItemType"] = priceItemType;

            return Page();
        }
        public ImportModel(IWebHostEnvironment _environment, Estimator.Data.EstimatorContext db)
        {
            Environment = _environment;
            context = db;
            _disable = true;
            _showDiff = true;
        }
        public IActionResult OnPostUpload(IFormFile postedFiles)
        {
            if (postedFiles == null || postedFiles.Length <= 0)
            {
                Message = "This is not a valid file.";
                return Page();
            }

            if (!Path.GetExtension(postedFiles.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                Message = "Wrong file format. Should be xlsx.";
                return Page();
            }

            string path = Path.Combine(this.Environment.WebRootPath, "Uploads");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();

            string fileName = Path.GetFileName(postedFiles.FileName);
            using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                postedFiles.CopyTo(stream);
                uploadedFiles.Add(fileName);
                this.Message += string.Format("<b>{0}</b>  - Загружен.<br />", fileName);
                path = path + "\\" + fileName;
            }           

            HandlerImport h_Import = new HandlerImport(path);

            tmpF = h_Import.takeAllData(path);
            TempData["path"] = path;


            var PricePropertyName = context.PriceItemType.Include(e => e.PricePropertyNames).Where(c => c.PriceItemTypeID == (int)TempData["priceItemType"]); //Получаем свойства элемента по ID
            TempData.Keep();

            foreach (var x in PricePropertyName)
            {
                foreach (var y in x.PricePropertyNames)
                {
                    _pricePropertyName.Add(y);
                }
            }
            
            if (_pricePropertyName.IsNullOrEmpty())
                _disable=false;
            else _showDiff=false;

            
            size = tmpF.ElementAt(tmpF.Count-1).Count();
            return Page();

        }

        public async Task<IActionResult> OnPostClear()
        {
            context.Prices.Where(x => x.PriceListId == (int)TempData["PriceListId"]).ExecuteDelete(); //Удаление импортирванных прайсов
            await context.SaveChangesAsync();

            return Page();
        }
        public async Task<FileResult> OnPostExport() //добавить функционал экспорта для сложных прайсов
        {
            var exDatas = context.Prices.Where(x => x.PriceListId == (int)TempData["PriceListId"]);

            string sWebRootFolder = Environment.WebRootPath;
            string sFileName = @"exportPrice.xlsx";
            string URL = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, sFileName);
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            var memory = new MemoryStream();

            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook;
                workbook = new XSSFWorkbook();
                ISheet sheet1 = workbook.CreateSheet("Sheet 1");

                IRow row1 = sheet1.CreateRow(0);

                for (int i = 0; i < 6; i++)
                {
                    NPOI.SS.UserModel.ICell cell = row1.CreateCell(i);
                }

                row1.Cells.ElementAt(0).SetCellValue("Наименование");
                row1.Cells.ElementAt(1).SetCellValue("ТУ");
                row1.Cells.ElementAt(2).SetCellValue("Цена");
                row1.Cells.ElementAt(3).SetCellValue("Минимальная партия"); //Заголовок
                row1.Cells.ElementAt(4).SetCellValue("Норма упаковки");
                row1.Cells.ElementAt(5).SetCellValue("Срок поставки");

                int rowCount = 1;
                foreach (Models.Price exdata in exDatas)
                {
                    IRow row = sheet1.CreateRow(rowCount);

                    for (int j = 0; j < 6; j++)
                    {
                        NPOI.SS.UserModel.ICell cell = row.CreateCell(j);
                    }

                    row.Cells.ElementAt(0).SetCellValue(exdata.Name);
                    row.Cells.ElementAt(1).SetCellValue(exdata.Ty);
                    row.Cells.ElementAt(2).SetCellValue(exdata.Cost);
                    row.Cells.ElementAt(3).SetCellValue(exdata.MinPackingSize); //Данные
                    row.Cells.ElementAt(4).SetCellValue(exdata.PackingSample);
                    row.Cells.ElementAt(5).SetCellValue(exdata.DeliveryTime.ToString());

                    rowCount++;
                }
                workbook.Write(fs);

            }

            using (var stream = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }

            memory.Position = 0;

            return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);
        }

        public async Task<IActionResult> OnPostFinishAsync()
        {

            HandlerImport h_Import = new HandlerImport(TempData["path"].ToString(), int.Parse(Request.Form["SelectedRow"].First()), int.Parse(Request.Form["SelectedName"].First()), int.Parse(Request.Form["SelectedCost"].First()), int.Parse(Request.Form["SelectedStandartPack"].First()), int.Parse(Request.Form["SelectedStandartDelivery"].First()), int.Parse(Request.Form["SelectedTimeDelivery"].First()), (int)TempData["PriceListId"], context);
            
            addPrice = new List<Estimator.Models.Price>();
            addPrice = h_Import.ImportFilePrice();
            
            int countIm = 0;
            int countUp = 0;

            if (addPrice != null)
            {
                for (int i = 0; i < addPrice.Count(); i++)
                {
                    context.Prices.Add(addPrice.ElementAt(i));
                    countIm++;

                    await context.SaveChangesAsync();
                }
            }

            return RedirectToPage("Index", new { countIm = countIm.ToString(), countUp = countUp.ToString() }); //ДОБАВИТЬ В INDEX функционал с уведомлением
        }

        public async Task<IActionResult> OnPostFinishDiffAsync()
        {
            var PricePropertyName = context.PriceItemType.Include(e => e.PricePropertyNames).Where(c => c.PriceItemTypeID == (int)TempData["priceItemType"]); //Получаем свойства элемента по ID

            foreach (var x in PricePropertyName)
            {
                foreach (var y in x.PricePropertyNames)
                {
                    _pricePropertyName.Add(y);
                }
            }

            List<int> position = new List<int>();

            foreach(var x in _pricePropertyName)
            {
                position.Add(int.Parse(Request.Form[x.PropertyName].First()));
            }

            HandlerImport h_Import = new HandlerImport(TempData["path"].ToString(), int.Parse(Request.Form["SelectedRow"].First()), position, int.Parse(Request.Form["SelectedName"].First()), int.Parse(Request.Form["SelectedCost"].First()), int.Parse(Request.Form["SelectedStandartPack"].First()), int.Parse(Request.Form["SelectedStandartDelivery"].First()), int.Parse(Request.Form["SelectedTimeDelivery"].First()), (int)TempData["priceItemType"], (int)TempData["PriceListId"], context);

            addPrice = new List<Estimator.Models.Price>();
            addPrice = h_Import.ImportFileDiffPrice();

            int countIm = 0;
            int countUp = 0;

            if (addPrice != null)
            {
                for (int i = 0; i < addPrice.Count(); i++)
                {
                    context.Prices.Add(addPrice.ElementAt(i));
                    countIm++;

                    await context.SaveChangesAsync();
                }
            }

            return RedirectToPage("Index", new { countIm = countIm.ToString(), countUp = countUp.ToString() }); //ДОБАВИТЬ В INDEX функционал с уведомлением
        }

        

    }
}
