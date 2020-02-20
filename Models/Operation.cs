using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{
    /// <summary>
    /// Описывает операцию программы испытаний
    /// </summary>

    public class Operation
    {
       
        public int OperationID { get; set; }
        [Required]
        [StringLength(150)]
        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [Required]
        [StringLength(4)]
        [Display(Name = "Код операции")]
        public string Code { get; set; }

        [Required]
        [Display(Name = "ДПО")]
        public bool DPO { get; set; }
        /// <summary>
        ///  выполняется по умолчанию
        /// </summary>
        public bool IsExecuteDefault { get; set; }
    }
}
