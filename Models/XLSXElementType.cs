using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Estimator.Models
{
    public class XLSXElementType
    {
       
        public XLSXElementType()
        {
            InList = true;
            ElementKitPrice  =0;
            ElementPrice   = 0;
            ElementContractorPrice  = 0;
        }
        public int ID { get; set; }
        public int ElementImportID { get; set; }
        public ElementImport ElementImport { get; set; }
        [Display(Name = "Типономинал")]
        public string ElementName { get; set; }

        public string ElementTypeKey { get; set; }
        [Display(Name = "Кол-во,шт")]
        public int ElementCount { get; set; }

        [NotMapped]
        public bool InList { get; set; }

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
        /// <summary>
        /// стоимость испытаний партии 
        /// </summary>
        [NotMapped]
        [Display(Name = "Стоимость испытаний, руб.")]
        public decimal  OwnCost { get; set; }

        [Display(Name = "Строка")]
        public int? RowNum { get; set; }
        /// <summary>
        /// срок поставки изделий от завода изготовителя 
        /// измеряется в календарных днях
        /// </summary>
        [Display(Name = "Срок закупки, дней")]
        [DefaultValue(0)]
        public int? DeliveryTime { get; set; }
        /// <summary>
        /// Цена закупки,1 шт без НДС
        /// </summary>
        [Display(Name = "Цена закупки, шт/руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal ElementPrice { get; set; }

        [Display(Name = "Цена закупки партии,руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal TotalPrice 
        {
            get
            {
                return ElementPrice * ElementCount; 
                
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
                return ElementFullCost*ElementCount;
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
                decimal result; 
                if (ElementCount != 0)
                {

                    result=  (ElementPrice * ElementCount + ElementKitPrice + ElementContractorPrice + OwnCost) ;
                    /// добавляем с стоимоcть дочернего элемента
                    if (this?.ElementImport?.CustomerRequest?.ChildCustomerRequest != null  )
                    {
                        result = result + this.ElementImport.CustomerRequest.GetChildElementTypeCost(this);
                    }

                    return result / ElementCount;
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
    }
}
