using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Models
{
    /// <summary>
    /// Описывает 1 шаг технологической цепочки т.е. трудоемкость конкретной  квалификации работника
    /// привыполнении данной операции
    /// </summary>
    public class TestAction
    {
       public int TestActionID { get; set; }
        public int QualificationID { get; set; }
        /// <summary>
        /// Квалификация работника выполняющего операцию
        /// </summary>
        public Qualification Qualification { get; set; }
        ///
        public int TestChainItemID { get; set; }
        /// <summary>
        /// Шаг технологической цепочки
        /// </summary>
        public TestChainItem TestChainItem { get; set; }
        
        /// <summary>
        /// трудоёмкость в минутах для партии
        /// </summary>
        public int BatchLabor { get; set; }
        /// <summary>
        /// трудоёмкость в минутах для одного изделия
        /// </summary>
        public int ItemLabor { get; set; }

    }
}
