using System.ComponentModel.DataAnnotations;

namespace Estimator.Models.ViewModels
{
    public class TestActionView
    {
        public int TestChainItemID { get; set; }
        public int TestActionID { get; set; }
        [Display(Name = "Квалификация")]
        public string QualificationName { get; set; }
        [Display(Name = "Партия")]
        public int BatchLabor { get; set; }
        /// <summary>
        /// трудоёмкость в минутах для одного изделия
        /// </summary>
        [Display(Name = "Шт.")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public string ItemLabor { get; set; }
        /// <summary>
        /// Торудоемкость изготовления оснастки (для операций изготовления оснастки)
        /// </summary>
        [Display(Name = "Оснастка")]
        public int KitLabor { get; set; }
    }
}
