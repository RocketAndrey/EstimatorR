﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{
    /// <summary>
    /// Общий класс испытываемых изделий, например микросхемы
    /// </summary>
    public class ClassECB
    {
        public int ClassECBID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Наименование")]
        public string Name { get; set;  }
    }
}
