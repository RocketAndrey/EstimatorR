
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using NPOI.SS.Formula.Functions;
using NPOI.Util;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Estimator.Models
{
    /// <summary>
    /// заявка на проведение испытаний 
    /// </summary>
    public class CustomerRequest

    {
        private decimal rate;
        private decimal materialRate;
        private List<RequestOperationLaborSummary> _operationSummary;
        private List<RequestOperationGroup> _operationGroups;
        private bool _useimport;
        private bool _usePurchase;
        public CustomerRequest()
        {
            CompanyHistory = new CompanyHistory();
            RequestDate = DateTime.Now;
            UseTemplate = false;
            rate = 1;
            materialRate=1;
            _useimport = true;
            _usePurchase = true;
            HideSamplePrice = true;
            HidePackingSample = true;
        }

        public int CustomerRequestID { get; set; }
        [Required(ErrorMessage ="Введите номер заявки!")]
        [StringLength(50)]
        [Display(Name = "№ исх.")]
        public string RequestNumber { get; set; }
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата исх.")]
        public DateTime RequestDate { get; set; }
        [Required(ErrorMessage = "Введите описание заявки!")]
        [StringLength(250)]
        [Display(Name = "Описание заявки")]

        public string Description { get; set; }
        /// <summary>
        /// Используется при обработке новой заявки
        /// </summary>
        public bool IsProceed { get; set; }
        [Display(Name = "Программа испытаний")]
        public int TestProgramID { get; set; }
        public TestProgram Program { get; set; }
        [Display(Name = "Заказчик")]
        [Required(ErrorMessage = "Укажите Заказчика!")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        /// <summary>
        /// заявка предполагает закупку ЭКБ?
        /// </summary>
        [Display(Name = "Pacчет с закупкой ЭКБ")]
        public bool UsePurchaseElements
        { 
            get
            {
                if(UseImport)
                {
                   if (this.ElementImport?.ImportElementPrice?? false)
                    {
                        return true;
                    }
               
                   
                }
                return _usePurchase;
            }
            set
            {
                _usePurchase = value; 
            }
        
        }
        /// <summary>
        /// Если = 1 то использзуется расчет на основе списка элементов
        /// </summary>
        
        [Display(Name = "Поэлементный расчёт")]
        public bool UseImport
        {
            get
            {

                // вот это все надо чтобы корректно отображались старые заявки
                if (!_useimport)
                {
                    if (this.ElementImport?.XLSXElementTypes?.Count > 0)
                    {
                        return true;
                    }
                }
                return _useimport;
            }
            set
            {
                if (this.ElementImport?.XLSXElementTypes?.Count > 0)
                {
                    _useimport = true;
                }
                else _useimport = value;
            }

        }

        #region Validation checking


        /// <summary>
        /// указывает на то что полностью введены данные по закупке
        /// </summary>
        [NotMapped]
        public bool PurchaseValid
        {
            get
            {
                if (!UsePurchaseElements) return false;

                if(ElementImport != null)
                {
                    return (ElementImport?.XLSXElementTypes?.Where(e => e.PurchaseValid == false).Count() == 0) ;
                }
                return false; 
            }
        }
        /// <summary>
        ///  колличество заполненных (валидных) элементов  в части закупки
        /// </summary>
        public int ValidPurchaseElementsCount
        {
            get
            {
                if (!UsePurchaseElements) return 0;

                if (ElementImport != null)
                {
                    return ElementImport?.XLSXElementTypes?.Where(e => e.PurchaseValid == true)?.Count() ?? 0;
                }
                return 0;
            }
        }
        /// <summary>
        ///  колличество незаполненных (невалидных) элементов в части закупки
        /// </summary>
        public int InValidPurchaseElementsCount
        {
            get
            {
                if (!UsePurchaseElements) return 0;

                if (ElementImport != null)
                {
                    return ElementImport?.XLSXElementTypes?.Where(e => e.PurchaseValid == false)?.Count()??0;
                }
                return 0;
            }
        }
        /// <summary>
        /// указывает на то что имрорт элементов проведен корректно
        /// </summary>
        public bool ImportValid
        {
            get
            {
                if (!UseImport) return false;

                if (ElementImport != null)
                {
                    return (ElementImport?.XLSXElementTypes?.Where(e => e.ElementTypeID  ==null && e.Included)?.Count() == 0);
                }
                return false;
            }
            /// <summary>
            ///  колличество незаполненных (невалидных) элементов в части импорта
            /// </summary>
        }
        public int ValidImportElementsCount
        {
            get
            {
                if (!UseImport) return 0;

                if (ElementImport != null)
                {
                    return ElementImport?.XLSXElementTypes?.Where(e => e.ElementTypeID !=null && e.Included)?.Count()??0;
                }
                return 0;
            }
        }
        /// <summary>
        ///  колличество незаполненных (невалидных) элементов в части импорта
        /// </summary>
        public int InValidImportElementsCount
        {
            get
            {
                if (!UseImport) return 0;

                if (ElementImport != null)
                {
                    return ElementImport?.XLSXElementTypes?.Where(e => e.ElementTypeID ==null && e.Included)?.Count()??0;
                }
                return 0;
            }
        }
        #endregion



        /// <summary>
        /// Стоимость выборки в цене изделия
        /// </summary
        [Display(Name = "Выборка в цене изделия")]
        public bool HideSamplePrice {  get; set; }
        /// <summary>
        /// Стоимость нормы упаковки и минимальной партии в  цене изделия
        /// </summary>
        [Display(Name = "Норма упаковки в цене изделия")]
        public bool HidePackingSample { get; set; }

        /// <summary>
        ///Коофициент сложности
        /// </summary>
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Rate
        {
            get
            {
                return rate == 0 ? 1 : rate;
            }
            set
            {
                rate = value == 0 ? 1 : value;
                if (rate<0)  rate = 0;
                if (rate>100) rate = 100;

            }
        }
        /// <summary>
        ///Коофициент закупки
        /// </summary>
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(1.02)]
        public decimal MaterialRate
        {
            get
            {
                return materialRate == 0 ? 1 : materialRate;
            }
            set
            {
                materialRate = value == 0 ? 1 : value;
                if (materialRate < 0) materialRate = 0;
                if (materialRate > 100) materialRate = 100;

            }
        }

        /// <summary>
        /// строковое значение к-та сложности для правильного отображения в форме
        /// </summary>
        [NotMapped]
        [Display(Name = "Коэффициент сложности")]
        [Required(ErrorMessage = "Введитe число с плавающей точкой")]
        [RegularExpression("^[-+]?[0-9]*[,]?[0-9]+(?:[eE][-+]?[0-9]+)?$", ErrorMessage = "Введите число в формате числа с плавающей запятой")]
        [DisplayFormat(DataFormatString = "{0:F4}")]
        public string StringRate 
        {
            get
            {
                return string.Format("{0:f4}", Rate);
               
            }
             set
            {
               decimal outputValue; 
               if ( decimal.TryParse (value,out outputValue))
                {
                    Rate = outputValue;
                }
                
            }

        }
        [NotMapped]
        [Display(Name = "Коэффициент закупки")]
        [Required(ErrorMessage = "Введитe число с плавающей точкой")]
        [RegularExpression("^[-+]?[0-9]*[,]?[0-9]+(?:[eE][-+]?[0-9]+)?$", ErrorMessage = "Введите число в формате числа с плавающей запятой")]
        [DisplayFormat(DataFormatString = "{0:F4}")]
        public string StringMaterialRate
        {
            get
            {
                return string.Format("{0:f4}", MaterialRate);

            }
            set
            {
                decimal outputValue;
                if (decimal.TryParse(value, out outputValue))
                {
                    MaterialRate = outputValue;
                }

            }

        }
       
        [NotMapped]
        public ElementImport ElementImport { get; set; }    
        public IEnumerable<RequestElementType> RequestElementTypes { get; set; }

        public void CalculateGroups()
        {

            if (RequestElementTypes != null)
            {

                //коллекция групп операций
                Dictionary<string, RequestOperationGroup> returnGroup = new Dictionary<string, RequestOperationGroup>();
                //коллекция операций 
                Dictionary<string, RequestOperationLaborSummary> returnOperations = new Dictionary<string, RequestOperationLaborSummary>();
                decimal labor;

                _operationSummary = null;
                _operationGroups = null;
                //перебираем все типы ЭКБ

                foreach (var itemRET in RequestElementTypes)
                {

                    if (itemRET.RequestOperations != null & itemRET.ItemCount > 0)
                    {
                        //перебираем операции для данного типа ЭРИ
                        foreach (var itemRO in itemRET.RequestOperations)
                        {
                            RequestOperationGroup itemROG;
                            RequestOperationLaborSummary itemROLS;
                          

                            if (itemRO.TestChainItem.Operation != null)
                            {
                                //Если нет такой группы то добавляем её в коллекцию групп
                                if (!returnGroup.ContainsKey(itemRO.TestChainItem.Operation.OperationGroup.Code))
                                {
                                    itemROG = new RequestOperationGroup(this);
                                    itemROG.OperationGroupID = itemRO.TestChainItem.Operation.OperationGroup.OperationGroupID;
                                    itemROG.Code = itemRO.TestChainItem.Operation.OperationGroup.Code;
                                    itemROG.Name = itemRO.TestChainItem.Operation.OperationGroup.Name;
                                    returnGroup.Add(itemRO.TestChainItem.Operation.OperationGroup.Code, itemROG);

                                }
                                //Если нет такой операции то добавляем её в коллекцию операций
                                if (!returnOperations.ContainsKey(itemRO.TestChainItem.Operation.OperationID.ToString()))
                                {
                                    itemROLS = new RequestOperationLaborSummary(this);
                                    itemROLS.OperationID = itemRO.TestChainItem.Operation.OperationID;
                                    itemROLS.OperationCode = itemRO.TestChainItem.Operation.Code;
                                    itemROLS.OperationName = itemRO.TestChainItem.Operation.Name;
                                    itemROLS.Order = itemRO.TestChainItem.Order;
                                    returnOperations.Add(itemRO.TestChainItem.Operation.OperationID.ToString(), itemROLS);

                                }

                                RequestQualLaborSummary itemRQLS;
                                //перебираем все специальности
                                foreach (var itemTA in itemRO.TestChainItem.TestActions)
                                {
                                    // если нет такой специальности у Групп операций то добавляем её
                                    if (!returnGroup[itemRO.TestChainItem.Operation.OperationGroup.Code].IsQualificationInList(itemTA.Qualification.Name))
                                    {
                                        itemRQLS = new RequestQualLaborSummary();
                                        itemRQLS.QualificationID = itemTA.QualificationID;
                                        itemRQLS.Name = itemTA.Qualification.Name;
                                        itemRQLS.CustomerRequest = this;
                                        returnGroup[itemRO.TestChainItem.Operation.OperationGroup.Code].QualificationLaborSummary.Add(itemRQLS);

                                    }
                                    // если нет такой специальности у  операций то добавляем её
                                    if (!returnOperations[itemRO.TestChainItem.Operation.OperationID.ToString()].IsQualificationInList(itemTA.Qualification.Name))
                                    {
                                        itemRQLS = new RequestQualLaborSummary();
                                        itemRQLS.QualificationID = itemTA.QualificationID;
                                        itemRQLS.Name = itemTA.Qualification.Name;
                                        itemRQLS.CustomerRequest = this;
                                        returnOperations[itemRO.TestChainItem.Operation.OperationID.ToString()].QualificationLaborSummary.Add(itemRQLS);

                                    }
                                   
                                    //вычисление группировки
                                    int groupOperationCount = 0;
                                    //Cкладываем трудоёмкости по специальностям
                                    if (itemRO.IsExecute)
                                    {
                                        //Вычисляем объём выборки
                                        int sampleCount;
                                        switch (itemRO.SampleCount)
                                        {
                                            case -1:
                                                //100%
                                                sampleCount = itemRO.RequestElementType.ItemCount;
                                                break;
                                            default:
                                                // берем объём выборки из заявки умнож. на кол-во партий, если 0 то с выборкой ничего не делают()
                                                sampleCount = itemRO.SampleCount* itemRO.RequestElementType.BatchCount;
                                                break;

                                        }
                                        
                                       
                                        int result = 0;
                                        groupOperationCount = Math.DivRem(sampleCount, itemRO.TestChainItem.GroupOperation, out result);
                                        
                                        if (result != 0)
                                        {
                                            groupOperationCount += 1;
                                        }
                                        if (itemRO.RequestElementType.ItemCount == 0)
                                        {
                                            groupOperationCount = 0;
                                        }
                                        ///какой - то кривой способ
                                        
                                        // добавляем трудоемкость для данной специальности;
                                        labor = ((itemRO.RequestElementType.BatchCount * itemTA.BatchLabor) +
                                           groupOperationCount * itemTA.ItemLabor +
                                            itemRO.RequestElementType.KitCount * itemTA.KitLabor) * itemRO.ExecuteCount * (itemRO.IsExecute ? 1 : 0)
                                             * CompanyHistory.TotalFactor; ;

                                

                                    }
                                    returnGroup[itemRO.TestChainItem.Operation.OperationGroup.Code].QualificationLaborSummary.Single(e => e.Name == itemTA.Qualification.Name).KitLaborSummary += (itemRO.RequestElementType.KitCount * itemTA.KitLabor) * CompanyHistory.TotalFactor * this.Rate* (itemRO.IsExecute ? 1 : 0); ;
                                    returnGroup[itemRO.TestChainItem.Operation.OperationGroup.Code].QualificationLaborSummary.Single(e => e.Name == itemTA.Qualification.Name).BanchLaborSummary += (itemRO.RequestElementType.BatchCount * itemTA.BatchLabor) * CompanyHistory.TotalFactor *this.Rate* itemRO.ExecuteCount * (itemRO.IsExecute ? 1 : 0);
                                    returnGroup[itemRO.TestChainItem.Operation.OperationGroup.Code].QualificationLaborSummary.Single(e => e.Name == itemTA.Qualification.Name).ItemLaborSummary += (groupOperationCount * itemTA.ItemLabor) * CompanyHistory.TotalFactor*this.Rate * itemRO.ExecuteCount * (itemRO.IsExecute ? 1 : 0); 

                                    returnOperations[itemRO.TestChainItem.Operation.OperationID.ToString()].QualificationLaborSummary.Single(e => e.Name == itemTA.Qualification.Name).KitLaborSummary= (itemRO.RequestElementType.KitCount * itemTA.KitLabor) * CompanyHistory.TotalFactor*this.Rate* (itemRO.IsExecute ? 1 : 0);
                                    returnOperations[itemRO.TestChainItem.Operation.OperationID.ToString()].QualificationLaborSummary.Single(e => e.Name == itemTA.Qualification.Name).BanchLaborSummary= (itemRO.RequestElementType.BatchCount * itemTA.BatchLabor) * CompanyHistory.TotalFactor * itemRO.ExecuteCount * (itemRO.IsExecute ? 1 : 0)*this.Rate;
                                    returnOperations[itemRO.TestChainItem.Operation.OperationID.ToString()].QualificationLaborSummary.Single(e => e.Name == itemTA.Qualification.Name).ItemLaborSummary= (groupOperationCount * itemTA.ItemLabor) * CompanyHistory.TotalFactor * itemRO.ExecuteCount * (itemRO.IsExecute ? 1 : 0)*this.Rate; 

                                }


                            }


                        }
                    }
                }

                _operationSummary = returnOperations.Values.OrderBy(e => e.Order).ToList();
                _operationGroups = returnGroup.Values.ToList();
            }
            else
            {
                _operationSummary = new List<RequestOperationLaborSummary>();
                _operationGroups = new List<RequestOperationGroup>();
            }

        }
        [NotMapped]
        public List<RequestQualLaborSummary> QualificationSummary
        {

            get
            {
                Dictionary<string, RequestQualLaborSummary> returnGroup = new Dictionary<string, RequestQualLaborSummary>();
                if (OperationGroups != null)
                {
                    foreach (var itemOG in OperationGroups)
                    {
                        foreach (var itemQ in itemOG.QualificationLaborSummary)
                        {
                            if (!returnGroup.ContainsKey(itemQ.QualificationID.ToString()))
                            {
                                RequestQualLaborSummary item = new ();
                              
                                item.Name = itemQ.Name;
                                item.QualificationID = itemQ.QualificationID;
                                item.CustomerRequest = this;

                                returnGroup.Add(itemQ.QualificationID.ToString(), item);
                            }
                            returnGroup[itemQ.QualificationID.ToString()].KitLaborSummary += itemQ.KitLaborSummary;
                            returnGroup[itemQ.QualificationID.ToString()].BanchLaborSummary += itemQ.BanchLaborSummary;
                            returnGroup[itemQ.QualificationID.ToString()].ItemLaborSummary += itemQ.ItemLaborSummary;

                            
                        }
                    }
                    return returnGroup.Values.ToList();
                }
                else
                { return null; }

            }
        }

        [NotMapped]
        public List<RequestOperationLaborSummary> OperationSummary
        {
            get
            {
                if (_operationSummary != null)
                {
                    CalculateGroups();
                }
                return _operationSummary;

            }
        }
        [NotMapped]
        public List<RequestOperationGroup> OperationGroups
        {
            get
            {
                if (_operationGroups == null)
                {
                    CalculateGroups();
                }
                return _operationGroups;
            }
        }

        #region Finance
        /// <summary>
        /// Материальные затраты
        /// </summary>
        [NotMapped]
        [Display(Description = "0100", Name = "Материальные затраты")]
        public decimal MaterialCost 
        {
        get
            {
                return ServicesCost + PartsCost + AccessoriesCost;
            }
        }
        /// <summary>
        /// Услуги сторонних организаций
        /// </summary>
        [NotMapped]
        [Display(Description = "0105" ,Name= "-оплата работ и услуг сторонних организаций производственного характера")]
        public decimal ServicesCost
        {
            get
            {
               decimal result = 0;
                if (this?.ElementImport?.XLSXElementTypes!=null)
                {
                    foreach(XLSXElementType type in  this?.ElementImport?.XLSXElementTypes)
                    {
                        result += type.ElementContractorPrice;
                    }
                }

                return Math.Round(result, 0);

            }
        }
        /// <summary>
        /// ПКИ и Комплектующие 
        /// </summary>
        [NotMapped]
        [Display(Description = "0104", Name = "-приобретение комплектующих изделий")]
        public decimal PartsCost
        {
            get
            {

                decimal result = 0;
                if (this?.ElementImport?.XLSXElementTypes != null)
                {
                    foreach (XLSXElementType type in this?.ElementImport?.XLSXElementTypes)
                    {
                        result += type.TotalPrice;
                    }
                }

                return Math.Round(result, 0);
            }


        }
        //
        /// <summary>
        ///Приобретение сырья, материалов и вспомогательных материалов
        /// </summary>
        [NotMapped]
        [Display(Description = "0101", Name = "-приобретение сырья, материалов и вспомогательных материалов")]
        public decimal AccessoriesCost
        {
            get 
            {
                decimal result = 0;
                if (this?.ElementImport?.XLSXElementTypes != null)
                {
                    foreach (XLSXElementType type in this?.ElementImport?.XLSXElementTypes)
                    {
                        result += type.ElementKitPrice;
                    }
                }

                return Math.Round(result, 0);
            }


        }

        /// <summary>
        /// Основная заработная плата
        /// </summary>
        [NotMapped]
        [Display(Description = "0201", Name = " основная заработная плата")]
       public decimal BasicSalary
        {
            get
            {
                decimal result;
                result = 0;

                if (OperationGroups != null)
                {
                    foreach (var itemOG in OperationGroups)
                    {
                        result += itemOG.Salary;
                    }

                }
                return Math.Round (result,0);
            }
        }
        /// <summary>
        /// Дополнительная заработная плата
        /// </summary>
        [NotMapped]
        public decimal TotalSalary
        {
            get
            {
                return AdditionalSalary + BasicSalary;
            }
        }
        /// <summary>
        /// Дополнительная заработная плата
        /// </summary>
        [NotMapped]
        public decimal AdditionalSalary
        {
            get
            {
                return Math.Round(CompanyHistory.AdditionalSalary/100 * BasicSalary,0);
            }
        }
        /// <summary>
        /// Средняя заработная плата
        /// </summary>
        [NotMapped]
        public decimal AverageSalary
        {
            get
            {
                if (TotalLabor > 0)
                {
                    return BasicSalary / (TotalLabor / 168);
                }
                else
                { return 0; }
            }
        }
        /// <summary>
        /// накладные расходы (Общехозяйственные затраты )
        /// </summary>
        [NotMapped]
        [Display(Description = "0900", Name = "Общехозяйственные затраты ")]
        public decimal OverHead
        {
            get
            {
                return Math.Round(CompanyHistory.OverHead / 100 * BasicSalary,0);
            }
        }
        /// <summary>
        /// Страховые взносы на обязательное социальное страхование
        /// </summary>
        [NotMapped]
        [Display(Description = "0300", Name = "Страховые взносы на обязательное социальное страхование")]
        public decimal PensionTax
        {
            get
            {
                return Math.Round (CompanyHistory.PensionTax / 100 * TotalSalary,0);
            }
        }

        /// <summary>
        /// собственные затраты
        /// </summary>
        ///    [NotMapped]
        [Display(Description = "0000", Name = "Собственная себестоимость")]
        public decimal OwnCost
        {
            get
            {
                return   TotalSalary + PensionTax + OverHead;
            }
        }
      
        /// <summary>
        /// производственная себестоимость 
        /// </summary>
        [NotMapped]
        [Display(Description = "1300", Name = "Произвдственная себестоимость")]
        public decimal InputCost
        {
            get
            {
                return MaterialCost+TotalSalary + PensionTax + OverHead;
            }
        }
        [NotMapped]
        [Display(Description = "1900", Name = "Цена продукции (без НДС)")]
        public decimal TotalCost
        {
            get
            {
                return InputCost + Profit;
            }
        }
        [NotMapped]
        [Display(Description = "1800", Name = "Прибыль")]
        public decimal Profit
        {
            get
            {
                return Math.Round(OwnCost * CompanyHistory.Margin / 100,0);
            }
        }
        [NotMapped]
        public decimal TotalLabor
        {
            get
            {
                decimal result;
                result = 0;

                if (OperationGroups != null)
                {
                    foreach (var itemOG in OperationGroups)
                    {
                        result += itemOG.LaborSummary;
                    }

                }
                return result / 60;
            }
        }
        /// <summary>
        /// трудоемкость изготовления оснастки для всей заявки, час
        /// </summary>
        [NotMapped]
        public decimal TotaKitlLabor
        {
            get
            {
                decimal result;
                result = 0;

                if (this.RequestElementTypes != null)
                {
                    foreach (var itemOG in RequestElementTypes)
                    {
                        result += itemOG.KitLaborSummary;
                    }
                }
                    return result;
                
            }
        }
        /// <summary>
        /// трудоемкость партии  для всей , час
        /// </summary>
        [NotMapped]
        public decimal TotalBatchLabor
        {
            get
            {
                decimal result;
                result = 0;

                if (this.RequestElementTypes != null)
                {
                    foreach (var itemOG in RequestElementTypes)
                    {
                        result += itemOG.BatchLaborSummary;
                    }

                }
                return result ;
            }
        }
        /// <summary>
        /// трудоемкость элемента  для всей заявки, час
        /// </summary>
        [NotMapped]
        public decimal TotalItemLabor
        {
            get
            {
                decimal result;
                result = 0;

                if (this.RequestElementTypes != null)
                {
                    foreach (var itemOG in RequestElementTypes)
                    {
                        result += itemOG.ItemLaborSummary;
                    }

                }
                return result;
            }
        }
        [NotMapped]
        public CompanyHistory CompanyHistory { get; set; }
        [NotMapped]
        public int TotalBanchCount
        {
            get
            {
                int result = 0;
                if (RequestElementTypes != null)
                {
                    foreach (var item in RequestElementTypes)
                    {
                        result += item.BatchCount;
                    }
                }
                return result;

            }
        }
        [NotMapped]
        public int TotalItemCount
        {
            get
            {
                int result = 0;
                if (RequestElementTypes != null)
                {
                    foreach (var item in RequestElementTypes)
                    {
                        result += item.ItemCount;
                    }
                }

                return result;

            }
        }
        [NotMapped]
        public int TotalKitCount
        {
            get
            {
                int result = 0;
                if (RequestElementTypes != null)
                {
                    foreach (var item in RequestElementTypes)
                    {
                        result += item.KitCount;
                    }
                }
                return result;

            }
        }
        [NotMapped]
        public decimal AveragePartCost
        {
            get
            {
                if (TotalBanchCount > 0)
                {
                    return (TotalCost / TotalBanchCount);
                }
                else
                {
                    return 0;

                }
            }
        }
        /// <summary>
        /// соотношение заработной платы к итоговой стоимости 
        /// </summary>
        [NotMapped]
        public decimal TotalRatio
        {
            get
            {
                return CompanyHistory.TotalRatio;
            }
        }
        /// <summary>
        /// Стоимость испытаний дочернего элемента 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public decimal GetChildElementTypeCost(XLSXElementType element)
        {
            int childElementTypeID = 0;
            decimal result = 0;

            foreach (RequestElementType requestType in this.RequestElementTypes)
            {

                if (requestType.ElementTypeID == element.ElementTypeID)
                {

                    childElementTypeID = (int)requestType.ElementType.ChildElementTypeID;


                }
            }
            foreach (RequestElementType requestType in this.ChildCustomerRequest.RequestElementTypes)
            {
                if (requestType.ElementTypeID == childElementTypeID)
                {

                    //стомость оснаски
                    decimal costKit = 0;
                    if (requestType.KitCount > 0)

                    {
                        costKit = requestType.KitCount == 0 ? 0 : (!element.IsAsuProtokolExists ? (requestType.CostKits / requestType.KitCount) : 0);
                    }

                    if (requestType.ItemCount > 0 && requestType.BatchCount > 0)
                    {
                        //стоимость испытаний данной партии
                        result = ((requestType.CostItems / requestType.ItemCount) * element.ElementCount
                            + (requestType.CostBanchs / requestType.BatchCount)
                         + costKit) * this.ChildCustomerRequest.Rate;
                    }
                    //oкругление
                    result = decimal.Round(result, 0);


                }
            }
            return result;

        }

        #endregion


        /// <summary>
        /// Ссылка на родительскую заявку ( когда заявка создана из другой заявки)
        /// </summary>
        public int? ParentCustomerRequestID
        {
            get;
            set;
        }
        /// <summary>
        /// ссылка на дочернюю заявку
        /// </summary>
        public CustomerRequest ParentCustomerRequest
        {
            get;
            set;
        }
        public int? CreateUserID { get; set; }
        public User CreateUser { get; set; }
        public DateTime CreateDate { get; set; }


        public int? LastModificateUserID { get; set; }

        public User LastModificateUser { get; set; }
        public DateTime ModificateDate { get; set; }
        /// <summary>
        /// использовать шаблон при выборе операция программы
        /// </summary>
        [NotMapped]
        public bool UseTemplate { get; set;}
        [NotMapped]
        public int TestProgramTemplateID { get; set; }
        [NotMapped]
        public int? ChildCustomerRequestID
        {
            get;
            set;
        }
        public CustomerRequest ChildCustomerRequest
        {
            get;
            set;
        }



    }
}
