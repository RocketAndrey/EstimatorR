using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Estimator.Models.AsuViews
{
  
    public class TestedType
    {
        public Int64  ID { get; set; }
        
        public string TypeNominal { get; set; }
        public string ProtokolNumber {get;set;}
    }
}
