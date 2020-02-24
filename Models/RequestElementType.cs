using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Models
{
    /// <summary>
    /// Описфвает колличество партий и штук ЭКБ по типам в заявке 
    /// </summary>
    public class RequestElementType
    {
        public int RequestElementTypeID { get; set; }

        public int? ElementTypeID { get; set; }
        public ElementType ElementType { get; set; }

        public int CustomerRequestID { get; set; }
        public CustomerRequest CustomerRequest { get; set; }
        /// <summary>
        /// Колличество партиий
        /// </summary>
        public int BatchCount { get; set; }
        /// <summary>
        /// Коилличестово изделий
        /// </summary>
        public int ItemCount { get; set; }
        /// <summary>
        /// Количество недостающей оснастки
        /// </summary>
        public int KitCount { get; set; }
       
        /// <summary>
        /// 
        /// </summary>
        public int Order { get; set; }

        public IEnumerable<RequestOperation > RequestOperations  { get; set; }
    }
}
