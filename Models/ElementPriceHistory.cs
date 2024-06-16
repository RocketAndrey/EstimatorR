
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estimator.Models
{
    /// <summary>
    /// Для хранения информации о цене изделия, даже в том случае если заявку удалили 
    /// </summary>
    public class ElementPriceHistory
    {
        public int ElementPriceHistoryID { get; set; }  
        public int? XLSXElementTypeID { get; set; }

        public XLSXElementType? XLSXElementType { get; set; }
        public int? CustomerRequestID { get; set; }

        [DefaultValue("")]
        public string ElementName { get; set; }    
        public ElementPriceType PriceType { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? PriceAmount { get; set; } = 0;
        /// <summary>
        /// дата создания записи
        /// </summary>
        public DateTime CreateDate {get; set; }
        [DefaultValue(1)]
        public int MinPackingSize { get; set; } = 1;
        /// <summary>
        /// норма упаковки
        /// </summary>
         [DefaultValue(1)]
        public int PackingSample { get; set; } = 1;

        [DefaultValue(0)]
        public int DeliveryTime { get; set; } = 0;

      
    }
}
