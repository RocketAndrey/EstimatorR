using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{
    public class TestProgram
        // Программа испытаний
    {
        public int TestProgramID { get; set; }

        /// <summary>
        /// Программа испытаний
        /// </summary>
     
        [Required]
        [StringLength(50, ErrorMessage = "Наименование не может быть более 50 символов.")]
        [Display(Name = "Программа")]
        public string Name { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Описание программы не может быть более 250 символов.")]
        [Display(Name = "Описание программы")]
        public string Description { get; set; }

        public bool AllowEditChain { get; set; }
        /// <summary>
        /// типы элементов программы испытний
        /// </summary>
        public ICollection<ElementType> ElementntTypes { get; set; }
       

    }
}
