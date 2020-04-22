using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    /// <summary>
    /// Группа испытаний конкретной заявки закзчика 
    /// </summary>
    public class RequestOperationGroup : OperationGroup
    {
        public CustomerRequest CustomerRequest; 
        public RequestOperationGroup(CustomerRequest request)
        {
            CustomerRequest = request;
            QualificationLaborSummary = new List<RequestQualLaborSummary>();
        }
        /// <summary>
        /// Трудоёмкость по специальностям для данной группы испытаний (ВК, ДИ и т.д.)
        /// </summary>
        public List<RequestQualLaborSummary> QualificationLaborSummary { get; set; }
        /// <summary>
        /// Суммарная трудоёмкось по всем специальностям 
        /// </summary>
        [Display(Name = "Итого, час")]
        public decimal LaborSummary
        {
            get

            {
                decimal result;
                result = 0;
                if (QualificationLaborSummary != null)
                {
                    foreach (var itemRQLS in QualificationLaborSummary)
                    {
                        result += itemRQLS.LaborSummary;
                    }

                }
                return result;

            }
        }
        /// <summary>
        /// Суммарная стоимость по всем специальностям 
        /// </summary>
        [Display(Name = "Итого, руб")]

        public decimal CostSummary
        {
            get

            {
                decimal result;
                result = 0;
                if (QualificationLaborSummary != null)
                {
                    foreach (var itemRQLS in QualificationLaborSummary)
                    {
                        result += itemRQLS.CostSummary;
                    }

                }
                return result;

            }
        }
        public decimal Salary
        {
            get
            {
                decimal result;
                result = 0;

                if (QualificationLaborSummary != null)
                {
                    foreach (var itemRQLS in QualificationLaborSummary)
                    {
                        result += (itemRQLS.LaborSummary / 60)  * CustomerRequest.CompanyHistory.GetSalary(itemRQLS.QualificationID);
                    }

                }
                return result;

            }
        }

        public bool IsQualificationInList(string qualificationName)
        {
            foreach (var item in QualificationLaborSummary)
            {
                if (item.Name == qualificationName) { return true; }

            }
            return false;
        }


    }
}
