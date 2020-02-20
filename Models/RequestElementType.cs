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

        public int BatchCount { get; set; }
        public int ItemCount { get; set; }
        public int KitCount { get; set; }
        public int Order { get; set; }

        public IEnumerable<RequestOperation > RequestOperations  { get; set; }
    }
}
