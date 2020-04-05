using System.ComponentModel.DataAnnotations;
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
        public string Name { get; set; }
    }
}
