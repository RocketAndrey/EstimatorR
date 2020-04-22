using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    /// <summary>
    /// суммарная трудоемкость для данной профессии;
    /// </summary>

    public class RequestQualLaborSummary : Qualification
    {
        public CustomerRequest CustomerRequest { get; set; }
        [Display(Name = "Итого, час")]
        public decimal LaborSummary { get; set; }

        /// <summary>
        /// Зарплата данной специальности 
        /// </summary>
        public decimal RequestQualSalarySummary
        {
            get
            {
                return (LaborSummary / 60) * CustomerRequest.CompanyHistory.GetSalary(QualificationID);
            }
        }
        /// <summary>
        /// Итоговая суммарна я стоимость работ в разрезе данной специальности
        /// </summary>

        public decimal CostSummary 
        { 
            get
            {
                return RequestQualSalarySummary * CustomerRequest.TotalRatio;
            }
        }

    }
}
