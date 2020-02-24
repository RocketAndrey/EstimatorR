using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Models
{
    public class StaffItem
    {
        public int StaffItemID { get; set; }
        public int CompanyHistoryID { get; set; }
        public CompanyHistory Company { get; set; }
        public int QualificationID { get; set; }
        /// <summary>
        /// специальность
        /// </summary>
        public Qualification Qualification { get; set; }
        /// <summary>
        /// Колличество сотрдников по специальности
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Средняя зарплата специалиста за 1 час работы
        /// </summary>
        public float Salary { get; set; }
    }
}
