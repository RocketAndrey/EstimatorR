using Estimator.Models;
using Estimator.Models.ViewModels;
using Estimator.Data;
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
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Policy;
using NPOI.SS.Formula.Functions;

namespace Estimator.Helpers
{
    public class PriceMachine
    {
        protected Estimator.Data.EstimatorContext _context;

        protected Estimator.Data.AsuContext _asuContext;

        private List<Estimator.Models.RuChipsDB> _dirVniir;
        private List<Estimator.Models.Company> _manufactures;
        public PriceMachine(Estimator.Data.EstimatorContext context, Estimator.Data.AsuContext asuContext)
        {
            _context = context;
            _asuContext = asuContext;

        }
        public async Task SetItemPrice(PurchaseElementView pView)
        {
            if (pView == null) return; 

            if(pView.PriceType==ElementPriceType.AddByUser && pView.ElementPrice!=0) { return; }

            XLSXElementType item = _context.XLSXElementTypes
            .Include(e => e.PriceHistory)
                  .FirstOrDefault(m => m.ID == pView.ID);

            if (pView.ElementPrice == 0)
            //Ищем для позиций у которых  нет цены
            {
                List<Price> priceList;
                //для позиций найденных в справочнике
                if (pView.VniirItemId != null)
                {
                    priceList = await _context.Prices
                        .Where(e => e.VniirId == pView.VniirItemId)
                        .Include(e => e.PriceList)
                        .OrderByDescending(r => r.PriceList.DateStart)
                        .ToListAsync();

                }
                else
                {
                    priceList = await _context.Prices
                       .Where(e => e.Name == pView.ElementName)
                       .Include(e => e.PriceList)
                       .OrderByDescending(r => r.PriceList.DateStart)
                       .ToListAsync();

                }
                //нашли 
                if (priceList.Count != 0)
                {
                    item.ElementPrice = (decimal)priceList[0].Cost;
                    item.VniirItemId = priceList[0].VniirId;
                    item.PackingSample = priceList[0].PackingSample;
                    item.MinPackingSize = priceList[0].MinPackingSize;
                    item.DeliveryTime = priceList[0].DeliveryTime;
                    item.PriceType = ElementPriceType.Price;
                    item.PriceId = priceList[0].PriceId;
                    _context.Entry(item).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    pView.ElementPrice = item.ElementPrice; 
                }

            }
            // в прайсах цену не нашли 
            if (pView.ElementPrice == 0)
          
            {
                //ищем в предыдущих  заявках 

                List<ElementPriceHistory> pHistoryList = await  _context.ElementPriceHistory
                      .Where(e => e.ElementName == pView.ElementName && e.PriceAmount !=0 )
                      .ToListAsync() ;

                if (pHistoryList.Count > 0)
                {
                    //cамая крайняя запись
                    DateTime lastRecordTime = pHistoryList.Max(e => e.CreateDate);
                    ElementPriceHistory pHistory = pHistoryList.FirstOrDefault(e => e.CreateDate == lastRecordTime);

                    //Нашли!!
                    if (pHistory != null)
                    {
                        if(pHistory.CustomerRequestID == (item?.PriceHistorySource?.CustomerRequestID??0))
                        {
                            //  рамках одной и той же заявки
                            item.PriceType = ElementPriceType.AddByUser;
                        }
                        else
                        {
                            item.PriceType = ElementPriceType.FromPreviosCustomerRequest;
                        }
                      
                        item.ElementPrice = (decimal)pHistory.PriceAmount;

                        item.PackingSample = pHistory.PackingSample;
                        item.MinPackingSize = pHistory.MinPackingSize;
                        item.DeliveryTime = pHistory.DeliveryTime;

                        item.PriceHistorySource  = pHistory;
                        _context.Entry(item).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                    }
                }


            }
        }
        /// <summary>
        /// Определяет производителя 
        /// </summary>
        /// <param name="pView"></param>
        /// <returns></returns>
        public async Task SetXSLXViewManufactory(PurchaseElementView pView, bool fullRefresh =false )
        {
            //БД ВНИИР
            if (_dirVniir == null)
            {
                _dirVniir = await _context.DirVniir
                    .AsNoTracking()
                    .ToListAsync();
            }
            if (_manufactures == null)
            {
                _manufactures = await _context.Companies
                  .AsNoTracking()
                  .ToListAsync();
            }
            List<VniirSearchItem> searchItems = new();
            string result = string.Empty;

            if ((pView.Manufactory?.Id ?? 0) == 0 || fullRefresh)
            {
                //коллекция найденных элементов
                searchItems.Clear();
                string[] words = SplitElementName(pView.ElementName);
                // перебор всей БД ВНИИР 
                foreach (RuChipsDB item in _dirVniir)
                {
                    string[] keys = SplitElementName(item.Name);
                    // проверяем соответствует ли уровень качества 
                    if (qualityLevelEquval(words, keys))
                    {
                        foreach (string word in words)
                        {
                            foreach (string key in keys)
                            {
                                if (key.Length > 3)
                                {
                                    if (PrepareStr(word).Contains(PrepareStr(key)))
                                    {
                                        // нашли элемент
                                        VniirSearchItem sitem = new VniirSearchItem
                                        {
                                            VniirItemID = item.Id,
                                            VniirItemName = item.Name,
                                            ManufactutureCode = item.CodeManufacturer,
                                            ManufactutureName = item.Manufacturer,
                                            Key = key,
                                            // вес ключа 
                                            KeyLenght = PrepareStr(key).Length
                                        };
                                        if (!searchItems.Contains(sitem))
                                        {
                                            searchItems.Add(sitem);
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
                //сортировка по весу 
                searchItems = searchItems.OrderByDescending(e => e.KeyLenght).ToList();
                if (searchItems.Count == 0)
                {
                   pView.MаnufactorySearchErrorString = "Производитель не найден";
                }
                //В БД ВНИИР найден только 1 элемент
                if (searchItems.Count == 1)

                {
                    fillPurchaseViewManufacture(pView, searchItems[0]);

                }
                //найдено несколько элементов 
                if (searchItems.Count > 1)
                {

                    //Вес первого ключа
                    int maxLen = searchItems[0].KeyLenght;
                    // для проверки гипотезы о существовании нескольких ключей с максимальным весом
                    int multiKey = 0;

                    for (int m = 1; m < searchItems.Count; m++)
                    {
                        if (searchItems[m].KeyLenght >= maxLen) multiKey++;
                    }
                    // ключ с максимальным весом только один 
                    if (multiKey == 0)
                    {
                        fillPurchaseViewManufacture(pView, searchItems[0]);

                    }
                    //несколько ключей с максимальным весом 
                    else
                    {

                        //проверяем гипотезу что все эти изделия c максимальным весом  имеют одного производителя
                        var companies = searchItems
                             .Where(p => p.KeyLenght == maxLen)
                            .GroupBy(p => p.ManufactutureCode)
                            .Select(g => new { Name = g.Key, Count = g.Count() });


                        if (companies.Count() == 1)
                        {
                            fillPurchaseViewManufacture(pView, searchItems[0]);

                        }
                        else
                        {
                            pView.MаnufactorySearchErrorString = string.Format("Найдено производителей: {0}", searchItems.Count);
                            pView.SupposedManufactory = searchItems.ToList(); 
                        }


                    }
                }
                //сохраняем 
                if (pView.Manufactory.Id > 0)
                {


                    XLSXElementType xitem = _context.XLSXElementTypes.FirstOrDefault(p => p.ID == pView.ID);
                    if (xitem != null)
                    {
                        xitem.CompanyId = pView.Manufactory.Id;
                        xitem.VniirItemId = pView.VniirItemId;
                        _context.Entry(xitem).State = EntityState.Modified;

                        await _context.SaveChangesAsync();

                    }
                }
                searchItems.Clear();

            }

        }
        private void fillPurchaseViewManufacture(PurchaseElementView view, VniirSearchItem item)

        {
            //среди всех ключей с максимальным весом только 1 производитель 
            view.Manufactory.Code = item.ManufactutureCode;
            view.Desc = item.VniirItemName;
            view.VniirItemId = item.VniirItemID;

            List<Company> manufacture = _manufactures.Where(e => e.Code == view.Manufactory.Code).ToList();

            if (manufacture.Count == 0)
            {
                // почему то есть элементы у которых не привязан код произодителя
                manufacture = _manufactures.Where(e => e.Name == item.ManufactutureName).ToList();
            }

            if (manufacture.Count > 0)
            {
                view.Manufactory.Name = manufacture[0].Name;
                view.Manufactory.Id = manufacture[0].Id;
            }
            else
            {
                view.Manufactory.Name = item.ManufactutureName;
                view.Manufactory.Id = 0;

                view.MаnufactorySearchErrorString = "Не найден производитель:" ;
                view.MаnufactorySearchString = item.ManufactutureName ; 
               // item.v

            }
        }
        /// <summary>
        /// делит строку на слова
        /// </summary>
        /// <param name="elementValue"></param>
        /// <returns></returns>
        protected string[] SplitElementName(string elementValue)
        {
          //тут бы побольше мусорных слов
            string[] garbageWords = { "микросхема", "операционный", "усилитель" };

            for (int i = 0; i < garbageWords.Length; i++)
            {

                elementValue = elementValue.Replace(garbageWords[i], "");
            }
            return  elementValue.Split(" ");
        }
        /// <summary>
        /// расстояние левенштейна, https://habr.com/ru/articles/331174/
        /// для нечеткого поиска 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int LevenshteinDistance(string source, string target)
        {
            if (string.IsNullOrEmpty(source))
            {
                if (string.IsNullOrEmpty(target)) return 0;
                return target.Length;
            }
            if (string.IsNullOrEmpty(target)) return source.Length;

            if (source.Length > target.Length)
            {
                var temp = target;
                target = source;
                source = temp;
            }

            var m = target.Length;
            var n = source.Length;
            var distance = new int[2, m + 1];
            // Initialize the distance matrix
            for (var j = 1; j <= m; j++) distance[0, j] = j;

            var currentRow = 0;
            for (var i = 1; i <= n; ++i)
            {
                currentRow = i & 1;
                distance[currentRow, 0] = i;
                var previousRow = currentRow ^ 1;
                for (var j = 1; j <= m; j++)
                {
                    var cost = (target[j - 1] == source[i - 1] ? 0 : 1);
                    distance[currentRow, j] = Math.Min(Math.Min(
                                distance[previousRow, j] + 1,
                                distance[currentRow, j - 1] + 1),
                                distance[previousRow, j - 1] + cost);
                }
            }
            return distance[currentRow, m];
        }
        /// <summary>
        /// Проверка сответствия уровня качества изделия и  записи БД ВНИИР
        /// </summary>
        /// <param name="words"></param>
        /// <param name="keys"></param>
        /// <returns></returns>
        private bool qualityLevelEquval(string[] words, string[] keys)
        {
            string ql = "ВП";
            string qlKey = "ВП";

            foreach (string word in words)
            {
                if (word.Trim() == "ОС" || word.Trim() == "ОСМ" || word.Trim() == "ОТК")
                    ql = word.Trim();
            }

            foreach (string key in keys)
            {
                if (key.Trim() == "ОС" || key.Trim() == "ОСМ" || key.Trim() == "ОТК") qlKey = key.Trim();
            }

            return (ql == qlKey);
        }
        /// <summary>
        /// функция удалает из строки все пробелы и переводит в нижний регистр 
        /// </summary>
        /// <param name="value">Исходная строка</param>
        /// <returns></returns>
        protected string PrepareStr(string value)
        {
            if (value == null) { return ""; }
            // новая строка для записи строки без пробелов
            string newstr = "";
            // цыкл
            for (int i = 0; i < value.Length; i++)
            {
                // если елемент i-ый елемент не пробел - пишем его в новую строку "newstr"
                if (value[i] != ' ')
                {
                    // - пишем его в новую строку "newstr"
                    newstr += value[i];
                }
            }
            return newstr.Trim().ToUpper();
        }
    }
}
