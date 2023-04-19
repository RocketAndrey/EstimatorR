using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Estimator.Models.ViewModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Estimator.Models
{
    public enum ColumnNames
    {
        
        A=1,B=2,C=3,D=4,E=5,F=6,G=7,H=8,I=9,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z
    }
    public class ElementImport
    {
        public ElementImport()
        {
            ElementNameColumn = ColumnNames.B;
            ElementTypeKeyColumn = ColumnNames.C;
            ElementCountColumn = ColumnNames.D;
            ElementPriceColumn = ColumnNames.E;
            ElementKitPriceColumn = ColumnNames.F;
            ElementContractorPriceColumn = ColumnNames.G;
        
            FirstRowIsHeader = true;
            ImportElementPrice = true;

            FirstRowNumber = 2;
            UseLastRowNumber = false;
            LastRowNumber = 3;
        }
      
        public int ElementImportID { get; set; }
        public int CustomerRequestID { get; set; }
        public CustomerRequest CustomerRequest { get; set; }



        public bool FirstRowIsHeader { get; set; }


        /// <summary>
        /// Номер первой строки Эксель при импортировании
        /// </summary>
        [Display(Name = "Номер первой строки")]
        public int FirstRowNumber { get; set; }

        /// <summary>
        /// Импортировать до конкретной строки или до последней
        /// </summary>

        [Display(Name = "Импортировать до строки")]
        public bool UseLastRowNumber { get; set; } = false;
        /// <summary>

        /// Номер последней строки Эксель при импортировании
        /// </summary>
        [Display(Name = "Номер последней строки")]
        public int LastRowNumber { get; set; }
        /// <summary>
        /// использовать предыдущие расчёты для определения типа элемента
        /// </summary>

        [Display(Name = "Использовать предыдущие расчёты")]
        public bool UseLastCalculation { get; set; }

        [Display(Name = "Наименование")]
        public ColumnNames ElementNameColumn { get; set; }

        [Display(Name = "Ключ")]
        public ColumnNames ElementTypeKeyColumn { get; set; }
        [Display(Name = "Колличество")]

        public ColumnNames ElementCountColumn { get; set; }

        [Display(Name = "Импортировать цену элементов")]
        public bool ImportElementPrice { get; set; }
        [Display(Name = "Цена закупки")]
        public ColumnNames ElementPriceColumn { get; set; }

        [Display(Name = "Импортировать цену оснастки")]
        public bool ImportElementКitPrice { get; set; }
        [Display(Name = "Цена оснастки")]
        public ColumnNames ElementKitPriceColumn { get; set; }


        [Display(Name = "Импортировать цену оснастки")]
        public bool ImportElementContractorPrice { get; set; }
        [Display(Name = "Цена соисполнитель")]
        public ColumnNames ElementContractorPriceColumn { get; set; }

        public List<XLSXElementType> XLSXElementTypes { get; set; }
        /// <summary>
        /// файл загружен?
        /// </summary>
        public bool FileUploaded { get; set; }

        public string FileWWWPath
        {
            get
            {
                return "../files/" + CustomerRequestID.ToString() + ".xlsx";
            }
        }
        /// <summary>
        /// Найденные в АСУ ИЦ браки
        /// </summary>
        public List<AsuViews.DefectedType> DefectedTypes { get; set; }
        /// <summary>
        /// Cумма ранее забракованных по РФА партий
        /// </summary>
        public int DefectedRfaBanchCount
        {
            get
            {
                if (DefectedTypes == null)
                {
                    return 0;
                }
                return DefectedTypes.Where(e => e.RFA).Count();

            }
        }
        /// <summary>
        /// Cумма ранее забракованных по ТУ изделий
        /// </summary>
        public Int64 DefectedTYItemCount
        {
            get
            {
                if (DefectedTypes == null)
                {
                    return 0;
                }
                return DefectedTypes.Where(e => e.NormTY).Sum(n => n.DefectCount);

            }
        }
        /// <summary>
        /// Cумма  нерекомендованных изделий из ранее проведенных испытаний
        /// </summary>
        public Int64 DefectedUnrecommendCount
        {
            get
            {
                if (DefectedTypes == null)
                {
                    return 0;
                }
                return DefectedTypes.Where(e => e.Unrecommend).Sum(n => n.DefectCount);

            }
        }

        /// <summary>
        /// расчет стоимости поэлементно
        /// </summary>
        public void CalculateXLSXCosts()
        {

            this.XLSXElementTypes = this.XLSXElementTypes.OrderBy(s => s.RowNum).ToList();
            // вычисляем стоимость испытаний 1 шт
            foreach (XLSXElementType type in this.XLSXElementTypes)
            {
                foreach (RequestElementType requestType in CustomerRequest.RequestElementTypes)
                {
                    if (requestType.ElementTypeID == type.ElementTypeID)
                    {
                        type.ElementTypeName = requestType.ElementType.Name;
                        if (requestType.ItemCount > 0 & requestType.BatchCount > 0)
                        {
                            decimal costKit = requestType.KitCount == 0 ? 0 : (!type.IsAsuProtokolExists ? (requestType.CostKits / requestType.KitCount) : 0);
                            //стоимость испытаний данной партии
                            type.OwnCost = ((requestType.CostItems / requestType.ItemCount) * type.ElementCount
                                + (requestType.CostBanchs / requestType.BatchCount)
                                + costKit) * this.CustomerRequest.Rate;

                        }
                    }
                }
            }

        }
        /// <summary>
        /// Равно true все элементы распознаны.
        /// </summary>
        public bool Valid
        {
            get
            {
                bool returnValue = false;
                if (XLSXElementTypes != null)
                {
                    returnValue = true;
                    foreach (XLSXElementType type in this.XLSXElementTypes)
                    {
                        if (!type.Valid)
                        {
                            returnValue = false;
                            break;
                        }
                    }
                }
                return returnValue;
            }
        }
        /// <summary>
        /// Цена закупки,итого шт без НДС
        /// </summary>
        [Display(Name = "Цена закупки, итого/руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal ElementPriceTotal
        {
            get
            { 
                decimal returnValue = 0;
                if (XLSXElementTypes != null)
                {
        
                    foreach (XLSXElementType type in this.XLSXElementTypes)
                    {
                        returnValue += type.TotalPrice;
                    }
                }
                return returnValue;
            }
        }
        /// <summary>
        /// Цена оснастки,итого шт без НДС
        /// </summary>
        [Display(Name = "Цена оснастки, итого/руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal ElementKitPriceTotal
        {
            get
            {
                decimal returnValue = 0;
                if (XLSXElementTypes != null)
                {

                    foreach (XLSXElementType type in this.XLSXElementTypes)
                    {
                        returnValue += type.ElementKitPrice;
                    }
                }
                return returnValue;
            }
        }
        /// <summary>
        /// Цена сторонних работ, итого НДС
        /// </summary>
        [Display(Name = "Цена сторонних работ, итого/руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal ElementContractorPriceTotal
        {
            get
            {
                decimal returnValue = 0;
                if (XLSXElementTypes != null)
                {

                    foreach (XLSXElementType type in this.XLSXElementTypes)
                    {
                        returnValue += type.ElementContractorPrice;
                    }
                }
                return returnValue;
            }
        }

        /// <summary>
        /// Стоимость испытаний, итого/руб
        /// </summary>
        [Display(Name = "Стоимость испытаний, итого/руб.")]
            [Column(TypeName = "decimal(18, 4)")]
            [DefaultValue(0)]
            public decimal CostTotal
            {
                get
                {
                    decimal returnValue = 0;
                    if (XLSXElementTypes != null)
                    {

                        foreach (XLSXElementType type in this.XLSXElementTypes)
                        {
                            returnValue += type.OwnCost;
                        }
                    }
                    return returnValue;
                }
        }  
        /// <summary>
           /// Цена полная,весь перечень без НДС
           /// </summary>
        [Display(Name = "Цена полная,/руб.")]
        [Column(TypeName = "decimal(18, 4)")]
        [DefaultValue(0)]
        public decimal FullCost
        {
            get
            {
                decimal returnValue = 0;
                if (XLSXElementTypes != null)
                {

                    foreach (XLSXElementType type in this.XLSXElementTypes)
                    {
                        returnValue += type.FullCost;
                    }
                }
                return returnValue;
            }
        }

    }
}
