using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Estimator.Models.ViewModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estimator.Models
{
    public enum ColumnNames
    {
        A=1,B=2,C=3,D=4,E=5,F=6,G=7
    }
    public class ElementImport
    {
        public ElementImport ()
        {
            ElementNameColumn = ColumnNames.A;
            ElementDatasheetColumn = ColumnNames.B;
            ElementManufacturingColumn = ColumnNames.C;
            ElementTypeKeyColumn = ColumnNames.D;
            ElementCountColumn = ColumnNames.E;
            FirstRowIsHeader = true;

        }
        public int ElementImportID { get; set; }
        public int CustomerRequestID { get; set; }
        public CustomerRequest CustomerRequest { get; set; }
        public bool FirstRowIsHeader { get; set; }

        [Display(Name = "Наименование")]
        public ColumnNames ElementNameColumn { get; set; }
        [Display(Name = "ТУ (datasheet)")]
        public ColumnNames ElementDatasheetColumn {get;set;}
        [Display(Name = "Производитель")]
        public ColumnNames ElementManufacturingColumn { get; set; }

        [Display(Name = "Ключ")]
        public ColumnNames ElementTypeKeyColumn { get; set; }
        [Display(Name = "Колличество")]
        public ColumnNames ElementCountColumn { get; set; }
        public List<XLSXElementType> XLSXElementTypes { get; set; }
    }
}
