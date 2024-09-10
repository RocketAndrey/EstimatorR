using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    public class RuChipsDB
    {
        public int Id { get; set; }
        [Display(Name = "Группа")]

        public string Group { get; set; }
        [Display(Name = "Подгруппа")]
        public string Subgroup { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Производитель")]
        public string Manufacturer { get; set; }
        public string CodeManufacturer { get; set; }
        [Display(Name = "Уровень качества")]
        public string QLevel { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "ТУ")]
        public string TechCondition { get; set; }
    }
}
