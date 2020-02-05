using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models.ViewModels
{
    public class AssignedRequestElementType
    {
        public int RequestElementTypeID { get; set; }

        [Display(Name = "Тип ЭКБ")]
        public  string Name { get; set; }
        [Required]
        [RegularExpression("#^[0-9]+$#", ErrorMessage = "Колличество партий это число!")]
        [Display(Name = "Партий")]
        public int BatchCount { get; set; }
        [Required]
        [RegularExpression("#^[0-9]+$#", ErrorMessage = "Колличество штук это число!")]
        [Display(Name = "Штук")]
        public int ItemCount { get; set; }
        public int Order { get; set; }
    }
}
