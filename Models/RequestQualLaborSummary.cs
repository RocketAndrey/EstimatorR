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
        public decimal LaborSummary 
        {
            get
            {
                return KitLaborSummary + BanchLaborSummary + ItemLaborSummary;
            }
        }

        /// <summary>
        /// трудоёмкость на создание оснастки для  данной специальности
        /// </summary>
        public decimal KitLaborSummary { get; set; }
        /// <summary>
        /// трудоёмкость по партиям для данной специальности
        /// </summary>
        public decimal BanchLaborSummary { get; set; }
        /// <summary>
        /// трудоемкость по позициям для данной специальности
        /// </summary>
        public decimal ItemLaborSummary { get; set; }
        /// <summary>
        /// Зарплата данной специальности 
        /// </summary>
        public decimal SalarySummary
        {
            get
            {
                return (LaborSummary / 60) * CustomerRequest.CompanyHistory.GetSalary(QualificationID);
            }
        }
        /// <summary>
        /// Итоговая суммарная стоимость работ в разрезе данной специальности
        /// </summary>
        public decimal CostSummary 
        { 
            get
            {
                return SalarySummary * CustomerRequest.TotalRatio;
            }
        }
        /// <summary>
        /// стоимость создания оснастки в разрезе данной специальности 
        /// </summary>
        public decimal KitCostSummary 
        {
            get
            {
                return (KitLaborSummary / 60) * CustomerRequest.CompanyHistory.GetSalary(QualificationID) * CustomerRequest.TotalRatio; ;
            }
        }
        /// <summary>
        /// стоимость на партии разрезе данной специальности 
        /// </summary>
        public decimal BanchCostSummary
        {
            get
            {
                return (BanchLaborSummary / 60) * CustomerRequest.CompanyHistory.GetSalary(QualificationID) * CustomerRequest.TotalRatio; ;
            }
        }
        /// <summary>
        /// стоимость для элементов в разрезе данной специальности 
        /// </summary>
        public decimal ItemCostSummary
        {
            get
            {
                return (ItemLaborSummary / 60) * CustomerRequest.CompanyHistory.GetSalary(QualificationID) * CustomerRequest.TotalRatio; ;
            }
        }


    }
}
