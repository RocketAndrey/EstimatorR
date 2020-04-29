using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{
    /// <summary>
    /// Описывае компанию
    /// </summary>

    public class CompanyHistory
    {
        public CompanyHistory()
        {
            //YearOfNorms = 2019;

            //OverHead = 1.8636M;
            //PensionTax = 0.302M;
            //Margin = 0.198M;

            //CalcFactors = new List<CalcFactor>(3);
            ///// Трудопотери 5%
            //CalcFactors.Add(new CalcFactor() { CompanyHistory = this, FactorName = "FactorLaborLoss", FactorValue = 1.05M });
            ///// Ежедневнная подготовка/уборка рабочего места (20 мин.день) 
            //CalcFactors.Add(new CalcFactor() { CompanyHistory = this, FactorName = "FactorWorkplace", FactorValue = 1.043M });
            ///// Технологические перерываы согласно СанПиН 2.2.2.542-96 10 мин/час
            //CalcFactors.Add(new CalcFactor() { CompanyHistory = this, FactorName = "FactorLaborLoss", FactorValue = 1.05M });
        }
        public int CompanyHistoryID { get; set; }
        public string CompanyName
        {
            get;set;
        }
        /// <summary>
        /// Год для которого используются нормативы при расчёте;
        /// </summary>
        public int YearOfNorms { get; set; }
        /// <summary>
        /// Накладные расходы (в % от основной заработной платы)
        /// </summary>
        public decimal OverHead { get; set; }
        /// <summary>
        ///  Рентабельность (в %) от собственной себестоимости  
        /// </summary>
        public decimal Margin { get; set; }
        /// <summary>
        ///Страховые взносы (в % от основной и дополнительной заработной платы) 
        /// </summary>
        public decimal PensionTax { get; set; }
        /// <summary>
        /// Дополнительная заработная плата (в % от основной заработной платы)
        /// </summary>
        public decimal AdditionalSalary { get; set;  }
        public List<StaffItem> Staff { get; set; }
        /// <summary>
        /// Трудопотери 5%
        /// </summary>
        public List<CalcFactor> CalcFactors { get; set; }

        public decimal TotalFactor
        {
            get
            {
                decimal result;
                result = 1;
                if (CalcFactors != null)
                {
                    foreach (var it in CalcFactors)
                    {
                        result *= it.FactorValue;
                    }
                }
                return result;
            }
        }

        public decimal GetSalary(int qualID)
        {
            if (Staff != null)
            {
                foreach (var item in Staff)
                {
                    if (item.QualificationID == qualID)
                    {
                        return item.Salary;
                    }
                }
            }
            return 0;
        }
        /// <summary>
        /// Cоотношение заработной платы к итоговой стоимости 
        /// </summary>
        [NotMapped]
        public decimal TotalRatio
        {
            get
            {
                return (1 + AdditionalSalary / 100 + (1 + AdditionalSalary / 100) * PensionTax / 100 + OverHead / 100) * (1 + Margin / 100);
            }
        }
    }
}
