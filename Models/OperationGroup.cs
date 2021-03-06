﻿using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Группа испытаний")]
        public string Name { get; set; }
    }
}
