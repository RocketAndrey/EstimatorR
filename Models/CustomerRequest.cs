using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{
    /// <summary>
    /// заявка на проведение испытаний 
    /// </summary>
    public class CustomerRequest

    {
        public int CustomerRequestID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "№ исх.")]
        public string RequestNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата исх.")]
        public DateTime RequestDate { get; set; }
        [Required]
        [StringLength(250)]
        [Display(Name = "Описание заявки")]
        public string Description { get; set; }
      /// <summary>
      /// Используется при обработке новой заявки
      /// </summary>
        public bool IsProceed { get; set; }
        public int TestProgramID { get; set; }
        public TestProgram Program { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public ICollection<RequestElementType> RequestElementTypes { get; set; }
    }
}
