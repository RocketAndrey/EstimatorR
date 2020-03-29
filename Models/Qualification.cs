using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{
    /// <summary>
    /// Описывает квалификацию сотрудника выполняющего операцию (ведущий инженер, инженер 1 кат)
    /// </summary>
    public class Qualification
    {
        public int QualificationID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Специальность")]
        public string Name { get; set; }
       
    }
}
