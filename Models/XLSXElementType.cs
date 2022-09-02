using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{
    public class XLSXElementType
    {
        public XLSXElementType()
        {
            InList = true;
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
        public decimal  Cost { get; set; }
        public int? RowNum { get; set; }
        /// <summary>
        /// Цена закупки,1 шт без НДС
        /// </summary>
        [Display(Name = "Цена, руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal ElementPrice { get; set; }
    }
}
