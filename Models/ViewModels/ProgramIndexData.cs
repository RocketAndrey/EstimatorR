using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Models.ViewModels
{
    /// <summary>
    /// класс для редактирования прграммы испытаний (
    /// </summary>
    public class ProgramIndexData
    {
        public IEnumerable<TestProgram> Programs { get; set; }

        public IEnumerable<ElementType> Elements { get; set; }
        public IEnumerable<TestChainItem> ChainItems { get; set; }
    }
}
