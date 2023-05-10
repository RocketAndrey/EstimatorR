using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Reflection;
using System.IO;
using Estimator.Models;
using System.ComponentModel.DataAnnotations;
using NPOI.XSSF.UserModel;
using DocumentFormat.OpenXml.Drawing;

namespace Estimator.Helpers
{
    public class XSLXWriter
    {
        public XSLXWriter(string fileName) 
        {
            FileName = fileName;
        } 
        private  void CreateCell(IRow CurrentRow, int CellIndex, string Value, XSSFCellStyle Style)
        {
            NPOI.SS.UserModel.ICell Cell = CurrentRow.CreateCell(CellIndex);
            Cell.SetCellValue(Value);
            Cell.CellStyle = Style;
            
        }
        private void CreateDecimalCell(IRow CurrentRow, int CellIndex, decimal Value, XSSFCellStyle Style)
        {
            NPOI.SS.UserModel.ICell Cell = CurrentRow.CreateCell(CellIndex);
            Cell.SetCellType(CellType.Numeric);
            Cell.SetCellValue((double)Value);
            IDataFormat dataFormatCustom = CurrentRow.Sheet.Workbook.CreateDataFormat();
            XSSFCellStyle st = (XSSFCellStyle)Style.Clone();
            st.DataFormat = dataFormatCustom.GetFormat("0,00");// dataFormatCustom.GetFormat("0,00");
            Cell.CellStyle = st;
        }
    
    private void CreateIntegerCell(IRow CurrentRow, int CellIndex, decimal Value, XSSFCellStyle Style)
    {
        NPOI.SS.UserModel.ICell Cell = CurrentRow.CreateCell(CellIndex);
        Cell.SetCellType(CellType.Numeric);
        Cell.SetCellValue((double)Value);
        IDataFormat dataFormatCustom = CurrentRow.Sheet.Workbook.CreateDataFormat();

            XSSFCellStyle st = (XSSFCellStyle)Style.Clone();
            st.DataFormat = dataFormatCustom.GetFormat("0");
            Cell.CellStyle = st;
        }


    public string FileName { get; set; }
        public void CreateXSLXFileElements(ElementImport elementImport)
        {
            IWorkbook workbook = new XSSFWorkbook();
            XSSFFont myFont = (XSSFFont)workbook.CreateFont();
            myFont.FontHeightInPoints = 11;
            myFont.FontName = "Tahoma";


            // Defining a border
            XSSFCellStyle borderedCellStyle = (XSSFCellStyle)workbook.CreateCellStyle();
            borderedCellStyle.SetFont(myFont);
            borderedCellStyle.BorderLeft = BorderStyle.Medium;
            borderedCellStyle.BorderTop = BorderStyle.Medium;
            borderedCellStyle.BorderRight = BorderStyle.Medium;
            borderedCellStyle.BorderBottom = BorderStyle.Medium;
            borderedCellStyle.VerticalAlignment = VerticalAlignment.Center;
    


            ISheet Sheet = workbook.CreateSheet("Report");
            //Creat The Headers of the excel
            IRow HeaderRow = Sheet.CreateRow(0);


            Type itemType = elementImport.XLSXElementTypes[0].GetType();

            int columnIndex = 0;
            var prop = itemType.GetProperty("RowNum");
            if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
            columnIndex++;
            prop = itemType.GetProperty("ElementName");
            if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);

            columnIndex++;
            prop = itemType.GetProperty("ElementTypeName");
            if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
            columnIndex++;
          
            prop = itemType.GetProperty("ElementCount");
            if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);

            columnIndex++;
            prop = itemType.GetProperty("ElementPrice");
            if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
            columnIndex++;
            prop = itemType.GetProperty("TotalPrice");
            if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
            columnIndex++;
            prop = itemType.GetProperty("ElementKitPrice");
            if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
            columnIndex++;
            prop = itemType.GetProperty("ElementContractorPrice");
            if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
            columnIndex++;
            prop = itemType.GetProperty("OwnCost");
            if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
            columnIndex++;
            prop = itemType.GetProperty("ElementFullCost");
            if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
            columnIndex++;
            prop = itemType.GetProperty("FullCost");
            if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);

            columnIndex++;

         
            //This Where the Data row starts from
           int RowIndex = 1;

            //Iteration through some collection
            foreach (var item in elementImport.XLSXElementTypes)
            {
                   //Creating the CurrentDataRow
                 IRow CurrentRow = Sheet.CreateRow(RowIndex);
                //    foreach (PropertyInfo prop in item.GetType().GetProperties())
                //    {
                //           prop.GetCustomAttribute(System.ComponentModel.DataAnnotation.Disp)
                //    }
   
                CreateCell(CurrentRow, 0, item.RowNum.ToString(), borderedCellStyle);
                CreateCell(CurrentRow, 1, item.ElementName, borderedCellStyle);
                CreateCell(CurrentRow, 2, item.ElementTypeName.ToString(), borderedCellStyle);
                CreateIntegerCell(CurrentRow,  3, item.ElementCount , borderedCellStyle);
                CreateDecimalCell(CurrentRow, 4, item.ElementPrice, borderedCellStyle);
                CreateDecimalCell(CurrentRow, 5, item.TotalPrice, borderedCellStyle);
                CreateDecimalCell(CurrentRow, 6, item.ElementKitPrice, borderedCellStyle);
                CreateDecimalCell(CurrentRow, 7, item.ElementContractorPrice, borderedCellStyle);
                CreateDecimalCell(CurrentRow, 8, item.OwnCost, borderedCellStyle);
                CreateDecimalCell(CurrentRow, 9, item.ElementFullCost, borderedCellStyle);
                CreateDecimalCell(CurrentRow, 10, item.FullCost, borderedCellStyle);

            
                //    int NumberOfRules = batchErrorReport.Rules.Count;
                //    if (NumberOfRules > 1)
                //    {
                //        int MergeIndex = (NumberOfRules - 1) + RowIndex;

                //        //Merging Cells
                //        NPOI.SS.Util.CellRangeAddress MergedBatch = new NPOI.SS.Util.CellRangeAddress(RowIndex, MergeIndex, 0, 0);
                //        Sheet.AddMergedRegion(MergedBatch);
                //    }
                //    int i = 0;
                //    // Iterate through cub collection
                //    foreach (BatchDataQuality batchDataQuality in batchErrorReport.Rules)
                //    {
                //        if (i > 0)
                //            CurrentRow = Sheet.CreateRow(RowIndex);
                //        CreateCell(CurrentRow, 1, batchDataQuality.RuleID, borderedCellStyle);
                //        CreateCell(CurrentRow, 2, batchDataQuality.RuleType, borderedCellStyle);
                //        CreateCell(CurrentRow, 3, batchDataQuality.CodeMessageType, borderedCellStyle);
                //        CreateCell(CurrentRow, 4, batchDataQuality.Severity, borderedCellStyle);
                //        RowIndex++;
                //        i++;
                //    }
                RowIndex ++;
            }
            // Auto sized all the affected columns
            int lastColumNum = Sheet.GetRow(0).LastCellNum;
            for (int i = 0; i <= lastColumNum; i++)
            {
                Sheet.AutoSizeColumn(i);
                GC.Collect();
            }
            if (!String.IsNullOrEmpty(FileName))
            {
                // Write Excel to disk 
                using (var fileData = new FileStream(FileName, FileMode.Create, FileAccess.Write))
                { 
            
                
                    workbook.Write(fileData);
                    fileData.Close();

                }
            }
        }
        private string GetProrertyDisplayName(PropertyInfo pInfo)
        {
            // получаем все атрибуты класса Person
            object[] attributes = pInfo.GetCustomAttributes(false);

            // проходим по всем атрибутам
            foreach (Attribute attr in attributes)
            {
                // если атрибут представляет тип DisplayAttribute
                if (attr is DisplayAttribute dAttribute)
                    // возвращаем значение свойства Имя 
                    return  dAttribute.Name;
            }
            return "";
        }
        
    }
}
