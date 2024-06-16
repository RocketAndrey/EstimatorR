using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Models.ViewModels
{
    /// <summary>
    /// Класс для организации фильтра заявок
    /// </summary>
    public class CustomerRequestFilter
    {
        public CustomerRequestFilter ()
        {
            ProgramID = 0;
            CustomerID = 0;
            DescFilter = "";
        }
        public int ProgramID { get; set; }
        public Program Program { get; set; }
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
        public int CustomerRequestID { get; set; }
        public string DescFilter { get; set; }

        public bool Empty
        {
            get
            {
                return ProgramID == 0 && CustomerID == 0 && CustomerRequestID == 0 &&  String.IsNullOrEmpty(DescFilter);
            }
        }
    }
}
