using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    /// <summary>
    /// суммарная трудоемкость для данной профессии;
    /// </summary>

    public class RequestQualLaborSummary:Qualification
    {
        [Display(Name = "Итого, час")]
        public decimal LaborSummary { get; set; }

        public decimal GetRequestQualificationLaborSummary(CustomerRequest customerRequest)
        {
            decimal returnValue = 0;

            if (customerRequest == null) { return 0; }
            
            foreach(var itemRet in customerRequest.RequestElementTypes )
            {
                foreach (var itemQLS in itemRet.QualificationLaborSummary)
                {
                    if (itemQLS.Key==this.Name)
                    {
                        returnValue += itemQLS.Value.LaborSummary;
                    }
                }
            }
            return returnValue;
        }
    }
}
