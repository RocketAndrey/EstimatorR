using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Models
{
    public class ElementKey
    {
        public int ElementKeyID { get; set; }
        public ElementType ElementType { get; set; }
        public int ElementTypeID { get; set; }

        public string Key { get; set; }
    }
}
