namespace Estimator.Models
{
    public class Price
    {
        public int PriceId { get; set; }
        public int PriceListId { get; set; }
        public PriceList PriceList { get; set; }    
        public int? VniirId { get; set; }
        public string Name { get; set; }
        public string Ty { get; set; }
        public double Cost { get; set; }
        public int MinPackingSize { get; set; }
        public int PackingSample { get; set; }
        public int? DeliveryTime { get; set; }

        public int? PriceItemTypeId {  get; set; }  
        public PriceItemType PriceItemType { get; set; }
        
        public string Property0 {  get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }
        public string Property4 { get; set; }
        public string Property5 { get; set; }
        public string Property6 { get; set; }
        public string Property7 { get; set; }
        public string Property8 { get; set; }
        public string Property9 { get; set; }
        public string Property10 { get; set; }
        public string Property11 { get; set; }
        public string Property12 { get; set; }
        public string Property13 { get; set; }
        public string Property14 { get; set; }
        public string Property15 { get; set; }
    }
}
