using System.ComponentModel.DataAnnotations;
namespace Estimator.Models.ViewModels
{

    public class AssignedRequestElementType
    {
        public int RequestElementTypeID { get; set; }

        [Display(Name = "Тип ЭКБ")]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Колличество партий это число!")]
        [Display(Name = "Партий")]
        public int BatchCount { get; set; }
        [Required]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Колличество штук это число!")]
        [Display(Name = "Штук")]
        public int ItemCount { get; set; }
        [Required]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Колличество остастки это число!")]
        [Display(Name = "Нет остнастки, типов")]
        public int MissingKitCount { get; set; }

        public int Order { get; set; }
    }
}
