using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Estimator.Models
{

    /// <summary>
    /// Тип согласно программы испытаний (например ПЛИС)
    /// </summary>
    public class ElementType
    {
        public int ElementTypeID { get; set; }
        [Required]
        [StringLength(150)]
        [Display(Name = "Тип ЭКБ")]
        public string Name { get; set; }
        public int Order { get; set; }
        public int ProgramID { get; set; }
        public TestProgram Program { get; set; }
        public int ClassECBID { get; set; }

        public ClassECB Class { get; set; }
        public IEnumerable<TestChainItem> ChainItems { get; set; }
    }
}
