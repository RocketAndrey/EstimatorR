using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    /// <summary>
    /// Трудоёмкости по операциям 
    /// </summary>
    public class RequestOperationLaborSummary
    {
        public CustomerRequest CustomerRequest;
        public RequestOperationLaborSummary(CustomerRequest request)
        {
            CustomerRequest = request;
            QualificationLaborSummary = new List<RequestQualLaborSummary>();
        }
        /// <summary>
        /// Трудоёмкость по специальностям для данной операции
        /// </summary>
        public List<RequestQualLaborSummary> QualificationLaborSummary { get; set; }

        public int OperationID { get; set; }
        [Display(Name = "Код")]
        public string OperationCode { get; set; }
        [Display(Name = "Операция")]
        public string OperationName { get; set; }

        public int Order { get; set; }
        public bool IsQualificationInList(string qualificationName)
        {
            foreach (var item in QualificationLaborSummary)
            {
                if (item.Name == qualificationName) { return true; }

            }
            return false;
        }
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
                        result += (itemRQLS.LaborSummary / 60) * CustomerRequest.CompanyHistory.GetSalary( itemRQLS.QualificationID);
                    }

                }
                return result;

            }
        }
    }
}
