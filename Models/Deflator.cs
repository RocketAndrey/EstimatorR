using System.ComponentModel.DataAnnotations.Schema;

namespace Estimator.Models
{
    public class Deflator
    {
        public int DeflatorID {  get; set; } 
        public int Year {  get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Value { get; set; }  
    }
}
