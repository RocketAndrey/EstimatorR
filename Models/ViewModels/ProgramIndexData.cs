using System.Collections.Generic;

namespace Estimator.Models.ViewModels
{
    /// <summary>
    /// класс для редактирования программы испытаний (
    /// </summary>
    public class ProgramIndexData
    {
        public IEnumerable<TestProgram> Programs { get; set; }

        public IEnumerable<ElementType> Elements { get; set; }
        public IEnumerable<TestChainItem> ChainItems { get; set; }
    }
}
