using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Models
{
    // шаг технологической цепочки
    public class TestChainItem
    {
     
        public int TestChainItemID { get; set; }
        public int ElementTypeID { get; set; }
        /// <summary>
        /// Тип изделия
        /// </summary>
        public ElementType ElementType { get; set; }

        public int OperationID { get; set; }
        /// <summary>
        /// Операция технологической цепочки
        /// </summary>
        public Operation Operation { get; set; }

        /// <summary>
        /// порядок операции в технологической цепочке
        /// </summary>
        public int Order { get; set; }
        public IEnumerable<TestAction> TestActions { get; set; }
    }
}
