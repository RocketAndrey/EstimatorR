using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Models
{
    /// <summary>
    /// Элемент шаблона программы (делается/неделается эта операция)
    /// </summary>
    public class TestProgramTemplateItem
    {
        public int TestProgramTemplateItemID { get; set; }
        public int TestProgramTemplateID { get; set; }

        public TestProgramTemplate ProgramTemplate { get; set; }
        public int? OperationID { get; set; }

        public Operation Operation { get; set; }
        /// <summary>
        /// Надо делать или не надо
        /// </summary>
        public bool IsExecute { get; set; }
        /// <summary>
        /// Сколько раз делать, например 2 давления
        /// </summary>
        public int ExecuteCount { get; set; }

    }
}
