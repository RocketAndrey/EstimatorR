using System.Collections.Generic;

namespace Estimator.Models
{
    /// <summary>
    /// Тип прейскуранта (резисторы , конденсаторы и т.п.)
    /// </summary>
    public class PriceItemType
    {
        public int PriceItemTypeID { get; set; }   

        public string PriceItemTypeName { get; set; }

        public List<PricePropertyName> PricePropertyNames { get; set; }


    }
}
