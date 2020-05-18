using System.ComponentModel.DataAnnotations.Schema;

namespace Estimator.Models
{
    /// <summary>
    /// Поправочные коофициенты
    /// </summary>
    public class CalcFactor
    {
        public int CalcFactorID { get; set; }
        public int CompanyHistoryID { get; set; }
        public CompanyHistory CompanyHistory { get; set; }
        public string FactorName { get; set; }

        [Column(TypeName = "decimal(18, 4)")]
        public decimal FactorValue { get; set; }

    }
}
