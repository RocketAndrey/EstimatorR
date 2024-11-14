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
using Microsoft.IdentityModel.Tokens;
using NPOI.XSSF.Streaming.Values;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

            Price elementPriceItem = null; 

            XLSXElementType item = null;

            baseCostSearch costSearcher = null;
            PriceList currentPrice = null;

            if (pView.ID != 0)
            {
                item = _context.XLSXElementTypes
                .Include(e => e.PriceHistory)
                      .FirstOrDefault(m => m.ID == pView.ID);
            }

            if (pView.ElementPrice == 0 || pView.DeliveryTime < 1)
            //Ищем для позиций у которых  нет цены
            {
                //сначала разбираемся с типом прайса:
                
              
                //для позиций найденных в справочнике
                if (pView.VniirItemId != null)
                {
                    //определяем тип прайса 
                    pView.VniirItem= await _context.DirVniir.FirstOrDefaultAsync(e => e.Id == (pView.VniirItemId ?? 0));

                    if (pView.VniirItemId != null)
                    {

                        //находим все прайсы производителя 
                        List<PriceList> priceList = await _context.PriceLists
                             .Where(e => e.Manufacture.Id == pView.Manufactory.Id)
                              .Include(e => e.Manufacture)
                              .Include (e => e.PriceItemType) 
                             .ToListAsync();
                        //теперь проверяем есть ли спец.прайс для данного типа изделий
                        List<PriceList> specialPriceList = priceList.
                            Where(e => String.IsNullOrEmpty(e.ElementName?.Trim()) == false)
                            .OrderByDescending(r => r.DateEnd)
                           .ToList();
                        //! Такие прайсы есть !!
              

                        if (specialPriceList.Count > 0)
                        {
                            for(int i = 0; i < specialPriceList.Count; i++)
                            {
                                string[] words = specialPriceList[i].ElementName.Split(';');
                               
                                for (int j = 0;j<words.Length;j++)
                                {
                                    if (words[j]== pView.VniirItem.Name)
                                    {
                                        //УРА Мы нашли тот самый прайс
                                        currentPrice = specialPriceList[i]; 
                                        break;
                                    }
                                }
                                if (currentPrice != null) { break; }
                            }
                        
                        }
                        else
                        {
                            //прайс  простой
                            costSearcher = new ElementCostSearch(_context,_asuContext); 
                        }
                        ///определяем тип прайса и создаем сооответствующий класс для обработки цены 
                        if (currentPrice != null)
                        {
                            switch (currentPrice.PriceItemType.PriceItemTypeName) 
                            {
                                case "Резисторы постоянные непроволочные":
                                    costSearcher = new ResistorCostSearch(_context, _asuContext);
                                    break;
                                case "Конденсаторы постоянной емкости керамические":
                                    costSearcher = new CapasitorCostSearch(_context, _asuContext);
                                    break;
                                case "Общий":
                                    costSearcher = new ElementCostSearch(_context, _asuContext);
                                    break;


                            }
                        }
                    }
                    elementPriceItem = await costSearcher.GetCost(pView,  currentPrice); 
                }
                else
                {
                    elementPriceItem = await  costSearcher.GetCost(pView,  currentPrice);
                }
               
                //нашли 
                if (elementPriceItem !=null)
                {

                    if (item != null)
                    { 
                            item.ElementPrice = (decimal)elementPriceItem.Cost;
                            item.VniirItemId = elementPriceItem.VniirId;
                            item.PackingSample = elementPriceItem.PackingSample;
                            item.MinPackingSize = elementPriceItem.MinPackingSize;
                            item.DeliveryTime = elementPriceItem.DeliveryTime;
                            item.PriceType = ElementPriceType.Price;
                            item.PriceId = elementPriceItem.PriceId;
                            _context.Entry(item).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                        pView.ElementPrice = item.ElementPrice;
                    }
                    

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
                    if (pView.RowNum ==104)
                    {
                        pView.RowNum = 104;
                    }
                    // проверяем соответствует ли уровень качества 
                    if (qualityLevelEquval(words, keys))
                    {
                        foreach (string word in words)
                        {
                            foreach (string key in keys)
                            {
                                if (key.Length > 3)
                                {
                                    if (Funct.PrepareStr(word).Contains(Funct.PrepareStr(key)))
                                    {
                                        // нашли элемент
                                        VniirSearchItem sitem = new VniirSearchItem
                                        {
                                            VniirItemID = item.Id,
                                            VniirItemName = item.Name,
                                            
                                            ManufactutureCode = item.CodeManufacturer,
                                            ManufactutureName = item.Manufacturer,
                                            
                                            Key = key,
                                            VniirDatasheet = item.TechCondition,
                                            // вес ключа 
                                            KeyLenght = Funct.PrepareStr(key).Length
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
                            ///пробуем найти соответствие по ТУ
                           
                               if (searchItems.Where(e => Funct.PrepareDatasheet(e.VniirDatasheet) == Funct.PrepareDatasheet(pView.Datasheet)).Count()==1)
                                {
                                    foreach (var item in searchItems)
                                    {
                                        if (Funct.PrepareDatasheet(item.VniirDatasheet) == Funct.PrepareDatasheet(pView.Datasheet))
                                        {

                                            fillPurchaseViewManufacture(pView, item);
                                        }
                                    }
                                }
                            
                              
                            else
                            {
                            
                                //оставляем значения только с максимальным ключем
                                pView.SupposedManufactory = searchItems.Where(p => p.KeyLenght == maxLen).ToList();
                                pView.MаnufactorySearchErrorString = string.Format("Найдено производителей: {0}", pView.SupposedManufactory.Count);

                            }

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
            view.Manufactory.Note = item.ManufactutureNote;
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
                view.Manufactory = manufacture[0];  
           
            }
            else
            {
                view.Manufactory.Name = item.ManufactutureName;
                view.Manufactory.Id = 0;

                view.MаnufactorySearchErrorString = "Не найден производитель:" ;
                view.MаnufactorySearchString = item.ManufactutureName ; 
              

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
          string words=  "oперационный,усилитель, Микросхема,Транзистор,Фильтр,Терморезистор,Термометр,Диод,Источник,вторичного, электропитания,помехоподавляющий,симметричный, Генератор,кварцевый, Чип-индуктивности,Чип-индуктивность, Резистор, Диод, Дроссель,Стабилитрон,Блок,трансформаторов,Трансформатор,Микросхема";
            words = words.ToUpper(); 
         
            string[] garbageWords = words.Split(",");

            elementValue= elementValue.ToUpper();   

            for (int i = 0; i < garbageWords.Length; i++)
            {

                elementValue = elementValue.Replace(garbageWords[i], "");
            }
            // новая строка для записи строки без пробелов
            string newstr = "";
           
            // цикл
            for (int i = 0; i < elementValue.Length; i++)
            {
                char symvol = elementValue[i];  

                // если елемент i-ый елемент специальный пробел то заменяем его на обыкновенный
                if (char.IsWhiteSpace(symvol) && symvol != ' ')
                {
                    // - пишем его в новую строку "newstr"
                    symvol = ' ';   
                }
                newstr += symvol;
            }
            return newstr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
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
      
    }
}
