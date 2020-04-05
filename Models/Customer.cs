using System.ComponentModel.DataAnnotations;
namespace Estimator.Models
{
    /// <summary>
    /// заказчик испытаний 
    /// </summary>
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Заказчик:")]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        [RegularExpression("[0-9]{10}", ErrorMessage = "ИНН организации состоит из 10 цифр!")]
        [Display(Name = "ИНН")]
        public string INN { get; set; }


    }
}
