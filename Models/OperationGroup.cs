using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    /// <summary>
    /// Группа Испытаний (ВК, ДИ,СИ)
    /// </summary>
    public class OperationGroup
    {
        public int OperationGroupID { get; set; }
        [Required]
        [StringLength(10)]
        public string Code { get; set; }
        [Required]
        [StringLength(100)]

        public string Name { get; set; }
    }
}
