using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{

    /// <summary>
    /// Тип согласно программы испытаний (например ПЛИС)
    /// </summary>
    public class ElementType
    {
        public int ElementTypeID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Тип")]
        public string Name { get; set; }
        public int Order { get; set; }
        public int ProgramID { get; set; }
        public TestProgram Program { get; set; }
        public int ClassECBID { get; set; }

        public ClassECB Class { get; set;  }
        public IEnumerable<TestChainItem> ChainItems { get; set;  }
    }
}
