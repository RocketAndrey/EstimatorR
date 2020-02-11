using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int ItemLabor { get; set; }
        /// <summary>
        /// Торудоемкость изготовления оснастки (для операций изготовления оснастки)
        /// </summary>
        [Display(Name = "Оснастка")]
        public int KitLabor { get; set; }
    }
}
