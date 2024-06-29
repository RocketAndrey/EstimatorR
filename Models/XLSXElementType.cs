using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Estimator.Migrations;
using MathNet.Numerics;
using NuGet.Packaging.Signing;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Estimator.Models
{
    public enum ElementPriceType
    {
        ImportedfromExcel = 0,
        AddByUser= 1,
        FromPreviosCustomerRequest= 2,
        Price= 3 

    }
    public class XLSXElementType
    {
        private decimal  _elementPrice;
        private string _elementName;
        private string _datasheet;
        private string _qualificationLevel; 
        private bool  _priceHistoryCalculated; 

        public XLSXElementType()
        {
            
            ElementKitPrice  =0;
            ElementPrice   = 0;
            ElementContractorPrice  = 0;
            _elementName = String.Empty;
            _datasheet = String.Empty;
            _qualificationLevel= String.Empty;
            SampleCount = 0;
            Included = true;
            MinPackingSize = 1;
            PackingSample = 1;
            _priceHistoryCalculated = false;
          
        }
        public int ID { get; set; }
        public int ElementImportID { get; set; }
        public ElementImport ElementImport { get; set; }
        
        [Display(Name = "Типономинал")]
        public string ElementName
        {
            get
            {
                if (String.IsNullOrEmpty(_elementName ))
                {
                    return ImportedElementName;
                }
                
                    return _elementName;
                
            }
            set
            {
                _elementName = value;
            }
        }

        public string ElementTypeKey { get; set; }

        [Display(Name = "Кол-во,шт")]
        public int ElementCount { get; set; }
        /// <summary>
        /// Закупаемое колличество  не равно количеству из-за норм упаковок  и выборки
        /// 
        /// </summary>
        /// 
        [Display(Name = "Кол-во к закупке,шт")]
        public int PurchasedCount
        {
            get
            {
                //для исключенных позиций ничего не покупаем
                if (!Included) return 0; 

                int returnValue = ElementCount;

                returnValue += SampleCount >0? SampleCount:0;

                if (PackingSample < 1) PackingSample = 1;//проверка корректности 
                if (MinPackingSize < 1) MinPackingSize = 1;
                if (MinPackingSize > returnValue) returnValue = MinPackingSize; 
                
                if (PackingSample > 1)
                {
                    decimal output = ((decimal)returnValue / (decimal)PackingSample) -  (Math.Truncate((decimal)returnValue / (decimal)PackingSample));

                    decimal multiplier = (decimal)returnValue / (decimal)PackingSample;

                    multiplier = Math.Truncate(multiplier + (output == 0 ? 0:1));

                    returnValue = PackingSample * (int)multiplier;


                }

                return returnValue; 

            }
        }
        /// <summary>
        /// Количество элементов поставляемое Заказчику 
        /// </summary>
        [Display(Name = "Кол-во к поставке,шт")]
        public int SuppliedCount
        {
            get
            {
                if (ElementImport==null) return 0;
                //для исключенных  позиций ничего не поставляем 
                if (!Included) return 0;
                int returnValue = ElementCount;
                //если ввыборка не в цене  то:
                if (!ElementImport.CustomerRequest.HideSamplePrice) returnValue += SampleCount; 
                //нормы упаковки не прячем цену 
                if (!ElementImport.CustomerRequest.HidePackingSample )
                {
                    if (PackingSample < 1) PackingSample = 1;//проверка корректности 
                    if (MinPackingSize < 1) MinPackingSize = 1;
                    if (MinPackingSize > returnValue) returnValue = MinPackingSize;
                    
                    if (PackingSample > 1)
                    {
                        decimal output = ((decimal)returnValue / (decimal)PackingSample) - (Math.Truncate((decimal)returnValue / (decimal)PackingSample));

                        decimal multiplier = (decimal)returnValue / (decimal)PackingSample;

                        multiplier = Math.Truncate(multiplier + (output == 0 ? 0 : 1));

                        returnValue = PackingSample * (int)multiplier;
                    }
                }
                
                return returnValue; 

            }
        }

        [Display(Name = "Выборка ,шт")]
        [DefaultValue(0)]
        public int SampleCount { get; set; }

        [Display(Name = "ТУ")]
        [DefaultValue("")]
        public string Datasheet
        { 
            get
            {
                if (String.IsNullOrEmpty(_datasheet))
                {
                    return ImportedDatasheet;
                }
                {
                    return _datasheet;
                }
            }
            set
            {
                _datasheet = value;
            }
        }

        [Display(Name = "Уровень качества")]
        [DefaultValue("")]
        public string QualificationLevel
        {
            get
            {
                //если руками ничего не задали 
                if ( String.IsNullOrEmpty(_qualificationLevel))
                {
                    // если в импортированном значении пусто 
                    if (String.IsNullOrEmpty(ImportedQualificationLevel))
                    {
                        if (ElementName != null)
                        { 
                        //ищем в названии
                        string[] words = ElementName.Split(" ");

                        foreach (string word in words)
                        {
                            if (word.Trim() == "ОС" || word.Trim() == "ОСМ" || word.Trim() == "ОТК" || word.Trim() == "ВП")
                                return word;
                        }
                    }

                    }

                    return ImportedQualificationLevel;
                }
                {
                    return _qualificationLevel;
                }
            }
            set
            {
                _qualificationLevel = value;
            }
        }


        /// <summary>
        /// ТУ импортировнное из экселя
        /// </summary>

        [Display(Name = "ТУ")]
        [DefaultValue("")]
        public string ImportedDatasheet { get; set; }

        [Display(Name = "Типономинал в заявке")]
        /// <summary>
        /// наименование элемента импортирванное из Excel
        /// </summary>
        public string ImportedElementName { get; set; }
        /// <summary>
        /// Стоимость изделия импортированння в эксель
        /// </summary>
        [DefaultValue(0)]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal ImportedPrice { get; set; }
        /// <summary>
        /// Уровень качества импортированный из Эксель
        /// </summary>
        public string ImportedQualificationLevel { get; set; }
        /// <summary>
        /// Производитель ИД
        /// </summary>
        public int? CompanyId { get; set; }
        /// <summary>
        /// Производитель 
        /// </summary>(
        public Company? Company { get; set; }
        /// <summary>
        /// ID Элемента найденного в справочник
        /// </summary>
        public int? VniirItemId { get; set; }
        /// <summary>
        /// ID элемента из прейскуранта
        /// </summary>
        public RuChipsDB VniirItem { get; set; }

        public int? PriceId { get; set; }   
        public Price Price {  get; set; }    
        
        /// <summary>
        /// Если = false то позиция исключена
        /// </summary>
        [DefaultValue(true)]
        public bool Included { get; set; }
        
        /// <summary>
        /// Минимаьная партия
        /// </summary>
        [DefaultValue(1)]
        public int MinPackingSize { get; set; }
        /// <summary>
        /// норма упаковки
        /// </summary>
        [DefaultValue(1)]
        public int PackingSample { get; set; }
        public int? ElementTypeID { get; set; }

        [NotMapped]
        public bool Valid { get; set; }
        [NotMapped]
        public string ErrorMessage
        {
            get;
            set;
        }
        [NotMapped]
        [Display(Name = "Тип")]
        public string ElementTypeName { get; set; }
        /// <summary>
        /// Код протокола из АСУ
        /// </summary>

        public string? AsuProtokolCode { get; set; }
        /// <summary>
        /// Найдена запись в АСУ о испытания такого типа
        /// </summary>
        public bool IsAsuProtokolExists
        {
            get
            {
                if (!String.IsNullOrEmpty(AsuProtokolCode))
                {
                    return AsuProtokolCode.Length > 0;
                }
                else
                {
                    return false;
                }

            }

        }
        /// <summary>
        /// ID  элемента загруженного ранее, если он есть то тип элемента можно взять из него и не париться с ключом
        /// </summary>
        public int BeforeUploadedXLSXElementTypeID { get; set; }
        

        [Display(Name = "Строка")]
        public int? RowNum { get; set; }
        /// <summary>
        /// срок поставки изделий от завода изготовителя 
        /// измеряется в календарных днях
        /// </summary>
        [Display(Name = "Срок закупки, дней")]
        [DefaultValue(0)]
        public int? DeliveryTime { get; set; }

        [DefaultValue(0)]
        public ElementPriceType PriceType { get; set; }

       

        /// <summary>
        /// информация о ценообразовании
        /// </summary>
        public List<ElementPriceHistory> PriceHistory { get; set; } = new ();
     
        /// <summary>
        /// если цена была импротирована  из  предыдущей заявки,  хранит ID
        /// элемента Price Historу откуда взаялась цена. 
        /// </summary>
        public int? PriceHistorySourceID {  get; set; }

      
        public ElementPriceHistory PriceHistorySource { get; set; }

        #region PriceCalculation

        /// <summary>
        /// стоимость испытаний партии 
        /// </summary>
        [NotMapped]
        [Display(Name = "Стоимость испытаний, руб.")]
        public decimal OwnCost { get; set; }
        /// <summary>
        /// Цена закупки,1 шт без НДС
        /// </summary>
        [Display(Name = "Цена закупки, шт/руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal ElementPrice {
            get
            {
                if (PriceType ==ElementPriceType.ImportedfromExcel)
                {
                    return ImportedPrice ;
                }
                else
                {

                    return _elementPrice;
                }
            }
            set
            {
                _elementPrice = value;
            } 
        }

        [Display(Name = "Цена закупки партии,руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal TotalPrice 
        {
            get
            {
                return ElementPrice * PurchasedCount * (ElementImport?.CustomerRequest?.MaterialRate ?? 1); 
                
            }
                
         }
        /// <summary>
        /// Цена оснастки,1 шт без НДС
        /// </summary>
        [Display(Name = "Цена оснастки, партия/руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal ElementKitPrice 
        {
            get;set;
        }
        /// <summary>
        /// Цена оснастки,1 шт без НДС
        /// </summary>
        [Display(Name = "Цена сторонних работ, партия/руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal ElementContractorPrice { get; set; }
        /// <summary>
        /// Цена полная,партия без НДС
        /// </summary>
        [Display(Name = "Сумма полная, руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal FullCost 
        { 
            get
            {
                return ElementFullCost * SuppliedCount;
            }
        }
        /// <summary>
        /// Цена полная,1 шт без НДС
        /// </summary>
        [Display(Name = "Цена полная, шт/руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal ElementFullCost
        {
            get
            {
                if (!Included) return 0;
                decimal result; 
                if (ElementCount != 0)
                {

                    result=  (TotalPrice + ElementKitPrice + ElementContractorPrice + OwnCost) ;
                    /// добавляем и стоимоcть дочернего элемента
                    if (this?.ElementImport?.CustomerRequest?.ChildCustomerRequest != null  )
                    {
                        result = result + this.ElementImport.CustomerRequest.GetChildElementTypeCost(this);
                    }

                    return result / (SuppliedCount==0?PurchasedCount:SuppliedCount);
                }
                else
                { return 0; }
            }
        }
        /// <summary>
        /// стоимость работ дочернего элемента ,1 шт без НДС
        /// </summary>
        [Display(Name = "Стоимость работ элемента дочерней заявки, шт/руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal ChildElementOwnCost
        {
            get
                
            {
                
                if(ElementImport?.CustomerRequest?.ChildCustomerRequest!=null)
                {
                    ElementImport?.CustomerRequest?.ChildCustomerRequest?.CalculateGroups();
                    return ElementImport.CustomerRequest.GetChildElementTypeCost(this);
                }
                return 0;
            }
        }
        #endregion
        /// <summary>
        /// Указывает корректно ли введены данные для элемнта в части закупки
        /// </summary>
        public bool PurchaseValid
        {
            get
            {
                //если элемент исключен то он валидный
                if (!Included) return true;

                return (ElementName.Trim().Length > 0 && ElementPrice > 0 && (CompanyId??0) > 0 && (DeliveryTime??0) > 0
                    && MinPackingSize > 0 && PackingSample > 0);
            }
        }

    }
}
