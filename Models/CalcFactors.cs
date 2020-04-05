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
        public decimal FactorValue { get; set; }

    }
}
