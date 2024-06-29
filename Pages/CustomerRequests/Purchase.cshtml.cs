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
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Globalization;
using Microsoft.AspNetCore.Http.Connections;
using System.IO;


namespace Estimator.Pages.CustomerRequests
{
   
    public class PurchaseModel : CustomerRequestPageModel
    {
        // Производители ЭКБ 
        private List<Company> _manufactures;
       
        public List <PurchaseElementView> PurchaseView { get; set; }
        private List<PurchaseElementView> _RequestPurchaseView { get; set; }


        [BindProperty]
        public int CustomerRequestID { get; set;  }
        public int filterByManufactoryId { get; set; } = -1; 
        public string filterByName { get; set; }=string.Empty;  
        public string[] filterPrice { get; set; }
        public string filterPriceValue { get; set; } = ">=0,00";

        public string filterValidValue { get; set; } = "Все";
        public string[] filterValid { get; set; }
        public string PageLoadTime  { get; set; }
        
        /// <summary>
        /// колличесто элементов с неустановленным производителем 
        /// </summary>
        public int UnlinkedManufactureCount
        {
            get
            {
                return PurchaseView?.Where(e => e.Manufactory.Id  == 0)?.Count() ?? 0;
            }
        }
        public PurchaseModel (Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
    {
            filterPrice = new[] { ">=0,00", "=0,00", ">0,00" };
            filterValid = new[] {"Все","Заполненные","Не заполненные" };
    }
        public async Task<IActionResult> OnGetAsync(int? id, string filterPurchaseName, string filterByPrice= ">=0,00", int manufactoryId=-1,string filterValidValue= "Все")
        {

      
            if (id == null)
            {
                return NotFound();
            }

            return await SetPurchaseList((int)id,  filterPurchaseName,  filterByPrice,  manufactoryId, filterValidValue );

        }
        private async Task<IActionResult> SetPurchaseList(int id, string filterPurchaseName, string filterByPrice, int manufactoryIds,string filterValidVal)
        {
            /////предыдущая фильтрация
            //if (HttpContext.Request.Cookies.ContainsKey(id.ToString () + "PurchasefilterPurchaseName") && filterPurchaseName==null)
            //{
            //    filterPurchaseName = HttpContext.Request.Cookies[id.ToString() + "PurchasefilterPurchaseName"];

            //}
            //if (HttpContext.Request.Cookies.ContainsKey(id.ToString() + "PurchasefilterByPrice") && filterByPrice == "")
            //{
            //    filterByPrice = HttpContext.Request.Cookies[id.ToString() + "PurchasefilterByPrice"];

            //}
            //if (HttpContext.Request.Cookies.ContainsKey(id.ToString() + "PurchasefilterValidValue") && filterValidValue == "")
            //{
            //    filterValidValue = HttpContext.Request.Cookies[id.ToString() + "PurchasefilterValidValue"];

            //}

            //if (HttpContext.Request.Cookies.ContainsKey(id.ToString() + "PurchasemanufactoryId") && manufactoryIds >= 0)
            //{

            //    int i = 1;


            //    if (Int32.TryParse(HttpContext.Request.Cookies[id.ToString() + "PurchasemanufactoryId"], out i))
            //    {
            //        manufactoryIds = i;
            //    }
            //}


            //замер скорости выполнения метода
            var sw = new Stopwatch();
            sw.Start();

            CustomerRequestID = (int)id;

            await base.SetCustomerReguest((int)id, int.Parse(_configuration.GetSection("YearOfNorms")["value"]));

            await _context.SaveChangesAsync();
            foreach(XLSXElementType xitem in CustomerRequest?.ElementImport?.XLSXElementTypes)
            {
                if (xitem.PriceType ==ElementPriceType.Price)
                {
                    xitem.VniirItem = await _context.DirVniir.FirstOrDefaultAsync(e => e.Id == xitem.VniirItemId);
               xitem.Price = await _context.Prices
                        .Include (r=>r.PriceList)
                        .FirstOrDefaultAsync(e=>e.PriceId == xitem.PriceId);   
                }
                else if(xitem.PriceType == ElementPriceType.FromPreviosCustomerRequest)
                {
                    xitem.PriceHistorySource = await _context.ElementPriceHistory.FirstOrDefaultAsync(e => e.ElementPriceHistoryID == xitem.PriceHistorySourceID);
                }
                

            }
            

            PurchaseView = CustomerRequest.ElementImport.XLSXElementTypes
             .Select(p => new PurchaseElementView(p))
             
             .ToList();

            if (CustomerRequest == null)
            {
                return NotFound();
            }

            await SetItemsManufactory();

            //производители
            List<Company> group_manufactures = new();


            group_manufactures.Add(new Company { Id = -1, Name = "Все" });

            group_manufactures.Add(new Company { Id = 0, Name = "Не найденные" });

            group_manufactures.AddRange(PurchaseView
                .GroupBy(p => new { p.Manufactory.Id, p.Manufactory.Name })
                .Select(g => new Company
                {
                    Id = g.Key.Id,
                    Name = g.Key.Name
                })
                .OrderBy(e=>e.Name)
                .ToList());
            //удаляем пустую стороку
            Company emptyItem= group_manufactures.FirstOrDefault(e => e.Name == "");
            if (emptyItem != null) { group_manufactures.Remove(emptyItem); }

            //начинаем фильтровать
            //По yнаименованию или ТУ
            if (!String.IsNullOrEmpty(filterPurchaseName))
            {
                PurchaseView = PurchaseView.Where(p => p.ElementName.Contains(filterPurchaseName) || p.Datasheet.Contains(filterPurchaseName)).ToList();
                filterByName = filterPurchaseName;
                HttpContext.Response.Cookies.Append(id.ToString() + "PurchasefilterPurchaseName", filterPurchaseName);
            }
            //производителю
            if (manufactoryIds != -1)
            {
                PurchaseView = PurchaseView.Where(p => p.Manufactory.Id == manufactoryIds).ToList();
                filterByManufactoryId = manufactoryIds;
                HttpContext.Response.Cookies.Append(id.ToString() + "PurchasemanufactoryId", filterByManufactoryId.ToString());
            }
            //по цене
            if (filterByPrice== "=0,00") 
            {
                PurchaseView = PurchaseView.Where(p => p.ElementPrice == 0).ToList();
                HttpContext.Response.Cookies.Append(id.ToString() + "PurchasefilterByPrice", filterByPrice.ToString());
            }
            
            if (filterByPrice == ">0,00")
            {
                PurchaseView = PurchaseView.Where(p => p.ElementPrice > 0).ToList();
                HttpContext.Response.Cookies.Append(id.ToString() + "PurchasefilterByPrice", filterByPrice.ToString());
            }
            //по статусу 
            if (filterValidVal == "Заполненные")
            {
                PurchaseView = PurchaseView.Where(p => p.Valid == true).ToList();
                HttpContext.Response.Cookies.Append(id.ToString() + "PurchasefilterValidValue", filterValidVal.ToString());
            }
            if (filterValidVal == "Не заполненные")
            {
                PurchaseView = PurchaseView.Where(p => p.Valid ==false).ToList();
                HttpContext.Response.Cookies.Append(id.ToString() + "PurchasefilterValidValue", filterValidVal.ToString());

            }

            filterValidValue = filterValidVal;  
            filterPriceValue = filterByPrice;

            ViewData["Manufactureid"] = new SelectList(group_manufactures, "Id", "Name");

            ViewData["PriceFilter"] = new SelectList(filterPrice);
            ViewData["ValidFilter"] = new SelectList(filterValid);
        

            //воостанавливаем данные уже полученные от пользователя
            if (_RequestPurchaseView !=null)
            {
                foreach (PurchaseElementView pitem in _RequestPurchaseView) 
                {
                    PurchaseElementView sitem= PurchaseView.FirstOrDefault (i=>i.ID == pitem.ID);
                    if (sitem != null)
                    {
                        sitem.MаnufactorySearchErrorString = pitem.MаnufactorySearchErrorString;
                        sitem.MаnufactorySearchString = pitem.MаnufactorySearchString;
                    }
                }
            }

            sw.Stop();
            this.PageLoadTime = sw.ElapsedMilliseconds.ToString();

            return Page();

        }
        public async Task<IActionResult> OnPostFilterAsync(string filterPurchaseName, string filterPrice, int manufactoryId,string filterValidValue)
        {
           
            return await SetPurchaseList(CustomerRequestID, filterPurchaseName??"", filterPriceValue, manufactoryId, filterValidValue);
        }

        public async Task<IActionResult> OnPostSaveAsync(string filterPurchaseName, string filterPriceValue, int manufactoryId, PurchaseElementView[] PurchaseView)
        {
            //запоминаем данные если они получены от клиента
            _RequestPurchaseView = PurchaseView.ToList();
            if (_manufactures == null)
            {
                _manufactures = await _context.Companies
                    .AsNoTracking()
                    .ToListAsync();
            }
            // здесь будем сохранять 
            foreach (PurchaseElementView view in PurchaseView )
            {
                XLSXElementType item = _context.XLSXElementTypes
                    .Include(e=>e.PriceHistory)
                    .FirstOrDefault(m => m.ID == view.ID);


                if (item != null)
                {

                    bool changeFlag = (view.ElementPrice != item.ElementPrice);
                   
                    if (view.ElementPrice == 0)
                    {
                    //пытаемся найти в этой же заявке такой-же элемент  по имени и все из него скопировать 
                        PurchaseElementView someItem = PurchaseView.FirstOrDefault
                        (e=>e.ElementPrice >0 && e.ElementName == view.ElementName && e.ID!= view.ID
                        && e.Datasheet == view.Datasheet);
                        
                        if (someItem != null)
                        {
                            changeFlag = true;

                            view.ElementPrice=someItem.ElementPrice;
                            view.MinPackingSize = someItem.MinPackingSize;
                            view.PackingSample = someItem.PackingSample;    
                            view.DeliveryTime = someItem.DeliveryTime;
                            view.VniirItemId = someItem.VniirItemId;    
                            if (view.Manufactory.Id == 0 && someItem.Manufactory.Id != 0)
                            {
                                item.CompanyId = someItem.Manufactory.Id;
                                view.Manufactory.Id = someItem.Manufactory.Id;   
                            }
                        }
                    }
                     //если производитель не установлен
                    //поиск производителя по имени 
                    if (view.Manufactory.Id == 0 && !string.IsNullOrEmpty(view.MаnufactorySearchString))
                    {
                        view.MаnufactorySearchErrorString = string.Empty;
                        List<Company> coms = _manufactures
                            .Where(j => PrepareStr(j.Name).Contains(PrepareStr(view.MаnufactorySearchString)))
                            .ToList();
                        //нашли
                        if (coms.Count == 1)
                        {
                            item.CompanyId = coms[0].Id;
                            changeFlag = true;
                        }
                        //нашли несколько или ничего 
                        else
                        {
                            view.MаnufactorySearchErrorString = string.Format("Найдено производителей: {0} ", coms.Count);
                        }
                    }

                    //если что-поменялось
                    if (item.ElementPrice != view.ElementPrice || item.MinPackingSize != view.MinPackingSize || 
                        item.PackingSample != view.PackingSample || item.DeliveryTime != view.DeliveryTime
                        ||item.Datasheet !=view.Datasheet || changeFlag ||
                        item.ElementName != view.ElementName || item.Included != view.Included)
                    {
                        //Сохраняем параметры  если они изменилась
                        if (view.ElementName.Trim()!=string.Empty  )
                        {
                            item.ElementName = view.ElementName;
                        }
                        if (view.ElementPrice >= 0 ){item.ElementPrice = view.ElementPrice;}

                        if (view.MinPackingSize > 0 ) { item.MinPackingSize = view.MinPackingSize; }
                        if (view.PackingSample > 0 ) { item.PackingSample = view.PackingSample; }
                         if (item.DeliveryTime>=0) { item.DeliveryTime = view.DeliveryTime; }
                       
                        item.Datasheet = view.Datasheet;
                        
                        item.PriceType = ElementPriceType.AddByUser;
                        item.Included = view.Included; 
                       
                        // сохранение истории цены
                        if (view.ElementPrice > 0)
                        {

                            if (item.PriceHistory == null) { item.PriceHistory = new(); }

                            ElementPriceHistory priceItem = item.PriceHistory.FirstOrDefault(e => e.PriceType == ElementPriceType.AddByUser);

                            if (priceItem == null)
                            {
                                priceItem = new ElementPriceHistory
                                {
                                    CustomerRequestID = CustomerRequestID,
                                    XLSXElementType = item,
                                    PriceType = ElementPriceType.AddByUser
                                };
                                item.PriceHistory.Add(priceItem);

                            }
                            priceItem.ElementName = item.ElementName.Trim();
                            priceItem.CreateDate = DateTime.Now;
                            priceItem.PriceAmount = item.ElementPrice;
                            priceItem.MinPackingSize = item.MinPackingSize;
                            priceItem.PackingSample = item.PackingSample;
                            priceItem.DeliveryTime = (int)(item.DeliveryTime??0);


                        }
                        _context.Entry(item).State = EntityState.Modified;
                        _context.SaveChanges();

                    }
                    

                    

                }
            }


            return RedirectToPage("Purchase", new
            {
                id = CustomerRequestID,
                filterPurchaseName = filterPurchaseName,
                filterPrice = filterPrice,
                manufactoryId = manufactoryId
            });

        }
       /// <summary>
       /// Показывает установлен ли фильтр 
       /// </summary>
        public bool Filtered
        {
            get
            {
                return (filterByManufactoryId != -1 || filterByName.Length > 0 || filterPriceValue != ">=0,00");
            }
        }
        /// <summary>
        /// Поиск производителя по базе произваодителей
        /// </summary>
        /// <returns></returns>
        private async Task SetItemsManufactory(bool fullRefresh = false)
        {

            Helpers.PriceMachine machine = new Helpers.PriceMachine(_context, _asuContext);

            if (CustomerRequest.Program.UseRuChipsDB)
            {
                //перебираем весь список экб
                for (int i = 0; i < PurchaseView.Count; i++)
                {
                    await machine.SetXSLXViewManufactory(PurchaseView[i],fullRefresh);

                    if (PurchaseView[i].ElementPrice==0)
                        {
                             await machine.SetItemPrice(PurchaseView[i]); 

                        }
                }
            }
        }

      
    }
}
