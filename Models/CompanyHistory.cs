using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    /// <summary>
    /// Описывае компанию
    /// </summary>
    public class CompanyHistory
    {
        public int CompanyHistoryID { get; set; }
        public string CompanyName 
        {
            get
            {
                return "АО КБ Ракета";

            }
         }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Процент накладных расходов
        /// </summary>
        public double OverHead { get; set; }
        /// <summary>
        /// Процент прибыли
        /// </summary>
        public double Margin { get; set; }
        /// <summary>
        /// Налог  на социальное страхование
        /// </summary>
        public double PensionTax { get; set; }
        public ICollection<StaffItem> Staff { get; set; }
        /// <summary>
        /// Трудопотери 5%
        /// </summary>
        public double FactorLaborLoss 
        {
            get { return 1.05; }
        }
        /// <summary>
        /// Ежедневнная подготовка/уборка рабочего места (20 мин.день) 
        /// </summary>
        public double FactorWorkplace
        {
            get  { return 1.043; }
        }
        /// <summary>
        /// Технологические перерываы согласно СанПиН 2.2.2.542-96 10 мин/час
        /// </summary>
        public double FactorBreak
        {
            get { return 1.05; }
        }
    }
}
