using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Estimator.Models.AsuViews
{
 
    public class DefectedType
    {
        public Int64 ID { get; set; }

        public string TypeNominal { get; set; }
        public string ProtokolNumber { get; set; }
        public string TY { get; set; }
        public string ManufacturingDate { get; set; }
        public string Description  {get;set;}
        public bool NormTY { get; set; }
        public bool Unrecommend { get; set; }
        public bool RFA { get; set;  }
    }
}
