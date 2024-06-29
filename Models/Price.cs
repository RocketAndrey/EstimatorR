namespace Estimator.Models
{
    public class Price
    {
        public int PriceId { get; set; }
        public int PriceListId { get; set; }
        public PriceList PriceList { get; set; }    
        public int? VniirId { get; set; }
        public string Name { get; set; }
        public string? Ty { get; set; }
        public double Cost { get; set; }
        public int MinPackingSize { get; set; }
        public int PackingSample { get; set; }
        public int? DeliveryTime { get; set; }
    }
}
