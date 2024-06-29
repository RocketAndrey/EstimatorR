using MathNet.Numerics;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Estimator.Models.ViewModels
{
    
    public class PurchaseElementView
    {
        private decimal _elementPrice = 0; 
        public PurchaseElementView(XLSXElementType item)
        {
            Manufactory = new Company();
            ID = item.ID;
            Included = item.Included;
            ElementName = item.ElementName;
            Datasheet = item.Datasheet ?? " ";
            ElementPrice = item.ElementPrice;
            QualityLevel = item.QualificationLevel;
            PackingSample = item.PackingSample;
            MinPackingSize = item.MinPackingSize;
            SampleCount = item.SampleCount; 
            RowNum = item.RowNum??0;
            ImportedElementName = item.ImportedElementName;
            ImportedDatasheetName = item.ImportedDatasheet;
            DeliveryTime = item.DeliveryTime??0;
            PriceType= item.PriceType;
            PriceHistorySourceID= item.PriceHistorySourceID;
            PriceHistoryItem = item.PriceHistorySource;
            VniirItemId = item.VniirItemId;
            Price = item.Price;
            Manufactory = new Company { Id = item.Company?.Id ?? 0, Name = item.Company?.Name ?? "", Code = item.Company?.Code ?? "" } ;

        }
        private string _searchString = "";

        public PurchaseElementView() 
        { 
            Manufactory = new Company();
        }    
       public int ID { get; set; }  
        public bool Included { get; set; }
        public int RowNum {  get; set; }    

        public string ImportedElementName { get; set; }

        [Required(ErrorMessage ="Не указано имя изделия")]
        public string ElementName { get; set; }

        public string ImportedDatasheetName { get; set; }   
        public string Datasheet { get; set; }  
        public int? PriceHistorySourceID { get; set; }   
        public bool Valid
        {
            get
            {
                return (ElementName.Trim().Length > 0 && ElementPrice> 0 &&  Manufactory.Id > 0 && DeliveryTime> 0 
                    && MinPackingSize> 0 && PackingSample >0 );
            }
        }
        public ElementPriceHistory PriceHistoryItem { get; set; }
        public bool DataSheetChanged
        {
            get
            {
                return (Datasheet?.Trim() != ImportedDatasheetName?.Trim()); 
            }
        }

        public bool ElementNameChanged
        {
            get
            {
                return ((ElementName?.Trim()?? "") != (ImportedElementName?.Trim()??""));
            }
        }
        public string QualityLevel {  get; set; }   
        public decimal ElementPrice
        {
            get
            {
                return _elementPrice.Round(2);
            }
            set
            { 
                _elementPrice = value.Round (2);    
            }
        }

     
        [Display(Name = "Цена, 1 шт. без НДС")]
        [Required(ErrorMessage = "Введитe число с плавающей точкой")]
        [RegularExpression("^[-+]?[0-9]*[,]?[0-9]+(?:[eE][-+]?[0-9]+)?$", ErrorMessage = "Введите число в формате числа с плавающей запятой")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public string StringElementPrice
        {
            get
            {
                return string.Format("{0:f2}", ElementPrice);

            }
            set
            {
                decimal outputValue;
               
                
                if (decimal.TryParse(value, out outputValue))
                {
                    ElementPrice = outputValue;
                }

            }

        }
        /// <summary>
        /// Минимальная партия
        /// </summary>
        public int MinPackingSize { get; set; } = 1; 
        //объём выборки
        public int SampleCount { get; set; } = 1;
        /// <summary>
        /// норма упаковки
        /// </summary>
        public int PackingSample { get; set; } = 1;
        /// <summary>
        /// Производитель
        /// </summary>
        public Company Manufactory { get; set; }   
      /// <summary>
      /// Срок поставки дней
      /// </summary>
        public int DeliveryTime { get; set; }
        public string Desc { get; set; }
        /// <summary>
        /// Поле для поиска производителя вручную
        /// </summary>
        public string MаnufactorySearchString {  
            get
            {
                if (string.IsNullOrEmpty(_searchString) && Manufactory.Id==0 && !string.IsNullOrEmpty(Manufactory.Name) )
                {
                    return Manufactory.Name;

                }
                return _searchString;   
            }
            set
            {
                _searchString = value; 
            }
        }   
        /// <summary>
        /// Список предполагаемых производителей
        /// </summary>
       public  List <VniirSearchItem> SupposedManufactory { get; set; }    
        /// <summary>
        /// стока для вывода ошибки поиска 
        /// </summary>
        public string MаnufactorySearchErrorString { get; set; }

        public ElementPriceType PriceType { get; set; }

        public int? VniirItemId { get; set; }
        public RuChipsDB VniirItemID { get; set; }  

        public Price Price { get; set; }
    }
}
