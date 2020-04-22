using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{
    public class XLSXElementType
    {
        public XLSXElementType()
        {
            Deleted = false;
        }
        public int ID { get; set; }
        public int ElementImportID { get; set; }
        public ElementImport ElementImport { get; set; }
        public string ElementName { get; set; }
        public string ElementDatasheet { get; set; }
        public string ElementManufacturing { get; set;}
        public string ElementTypeKey { get; set; }

        public int ElementCount { get; set; }

        [NotMapped]
        public bool Deleted { get; set; }


    }
}
