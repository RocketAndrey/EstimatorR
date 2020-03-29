using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    /// <summary>
    /// Группа испытаний конкретной заявки закзчика 
    /// </summary>
    public class RequestOperationGroup:OperationGroup
    {
        public RequestOperationGroup()
        {
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
       
        public decimal  LaborSummary
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
                return result / 60;

            }
        }

        public bool IsQualificationInList(string qualificationName)
        {
            foreach (var item in QualificationLaborSummary)
            {
                if (item.Name== qualificationName) { return true; }

            }
            return false;
        }

 
    }
}
