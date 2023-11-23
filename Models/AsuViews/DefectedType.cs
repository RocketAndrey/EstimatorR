
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Estimator.Models.AsuViews
{

    public class DefectedType
    {
        public Int64 ID { get; set;}
        [Display(Name = "Тип:")]
        public string TypeNominal { get; set; }
        [Display(Name = "№ протокола")]
        public string ProtokolNumber { get; set; }
        public string TY { get; set; }
        [Display(Name = "Причина забракования:")]
        public string Description  {get;set;}
        public bool NormTY { get; set; }
        public bool Unrecommend { get; set; }
        public bool RFA { get; set; }
        [Display(Name = "Забраковано, шт:")]
        public Int64 DefectCount { get; set; }
    }
}
