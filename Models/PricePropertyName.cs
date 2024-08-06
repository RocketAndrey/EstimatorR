namespace Estimator.Models
{
    /// <summary>
    /// Для соответсвия свойсв класса Price Property0... реальным свойства элемента в прайсе (сопротивление и тп.)
    /// </summary>
    public class PricePropertyName
    {
        public int PricePropertyNameId { get; set; }    
        public int PriceItemTypeId { get; set; }
        public PriceItemType PriceItemType { get; set; }
        /// <summary>
        ///  Property0...Property 9  класса Price
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        ///   наименование  реального свойства элемента в прайсе(сопротивление и тп.)
        /// </summary>

        public string ElementPropertyName { get; set; }
    }
}
