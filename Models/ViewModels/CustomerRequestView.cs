using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models.ViewModels
{
    public class CustomerRequestView
    {
        public int CustomerRequestID { get; set; }
        [Display(Name = "№ исх.")]
        public string RequestNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата исх.")]
        public DateTime RequestDate { get; set; }
        [Display(Name = "Описание заявки")]
        public string Description { get; set; }
        [Display(Name ="Программа испытаний")]
        public string ProgramName { get; set; }
        [Display(Name ="Заказчик")]
        public string CustomerName { get; set; }
        [Display(Name = "ИНН")]
        public string CustomerINN { get; set; }
    }
}
