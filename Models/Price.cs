namespace Estimator.Models
{
    public class Price
    {
        public int PriceId { get; set; }
        public int PriceListId { get; set; }
        public int VniirId { get; set; }
        public string Name { get; set; }
        public string? Ty { get; set; }
        public double Cost { get; set; }
        public int StandartDelivery { get; set; }
        public int StandartPack { get; set; }
        public int? TimeDelivery { get; set; }
    }
}
