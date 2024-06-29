using System;

namespace Estimator.Models
{
    public class PriceList
    {
        public int PriceListId { get; set; }
        public int CompanyId { get; set; }
        public Company Manufacture { get; set; }
        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string? Description { get; set; }
        public string? ScanOfPrice { get; set; }
        public bool IsDifficult { get; set; }
    }
}
