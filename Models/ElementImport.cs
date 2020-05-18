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
        A=1,B=2,C=3,D=4,E=5,F=6,G=7,H=8,I=9,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z
    }
    public class ElementImport
    {
        public ElementImport ()
        {
            ElementNameColumn = ColumnNames.B;
            ElementTypeKeyColumn = ColumnNames.C;
            ElementCountColumn = ColumnNames.D;
            FirstRowIsHeader = true;

        }
        public int ElementImportID { get; set; }
        public int CustomerRequestID { get; set; }
        public CustomerRequest CustomerRequest { get; set; }
        public bool FirstRowIsHeader { get; set; }

        [Display(Name = "Наименование")]
        public ColumnNames ElementNameColumn { get; set; }
      
        [Display(Name = "Ключ")]
        public ColumnNames ElementTypeKeyColumn { get; set; }
        [Display(Name = "Колличество")]
        public ColumnNames ElementCountColumn { get; set; }
        public List<XLSXElementType> XLSXElementTypes { get; set; }

        public bool FileUploaded { get; set; }

        public string FileWWWPath
        {
            get
            {
                return "../files/" + CustomerRequestID.ToString() + ".xlsx";
            }
        }
    }
}
