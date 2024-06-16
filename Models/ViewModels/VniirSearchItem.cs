using System;

namespace Estimator.Models.ViewModels
{
    public class VniirSearchItem
    {
        public int VniirItemID {  get; set; }   
        public bool IsSelected { get; set; }    
        public string VniirItemName { get; set; } = string.Empty;
        public string ManufactutureCode { get; set; }
        public string ManufactutureName { get; set; }   
        public string Key { get; set; }
        public int KeyLenght {  get; set; }
        public override bool Equals(object? obj)
        {
            
            if (obj is VniirSearchItem item) return VniirItemID == item.VniirItemID;
            return false;
        }
        public override int GetHashCode() => VniirItemID.GetHashCode();
    }
}
