using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Reflection;
namespace Estimator.Helpers
{
    public class XSLXWriter
    {
        private void CreateCell(IRow CurrentRow, int CellIndex, string Value, HSSFCellStyle Style)
        {
            ICell Cell = CurrentRow.CreateCell(CellIndex);
            Cell.SetCellValue(Value);
            Cell.CellStyle = Style;
        }
        
        public void CreateXSLXFile(System.Collections.ArrayList collection )
        {
            HSSFWorkbook workbook = new HSSFWorkbook();
            HSSFFont myFont = (HSSFFont)workbook.CreateFont();
            myFont.FontHeightInPoints = 11;
            myFont.FontName = "Tahoma";


            // Defining a border
            HSSFCellStyle borderedCellStyle = (HSSFCellStyle)workbook.CreateCellStyle();
            borderedCellStyle.SetFont(myFont);
            borderedCellStyle.BorderLeft = BorderStyle.Medium;
            borderedCellStyle.BorderTop = BorderStyle.Medium;
            borderedCellStyle.BorderRight = BorderStyle.Medium;
            borderedCellStyle.BorderBottom = BorderStyle.Medium;
            borderedCellStyle.VerticalAlignment = VerticalAlignment.Center;

            ISheet Sheet = workbook.CreateSheet("Report");
            //Creat The Headers of the excel
            IRow HeaderRow = Sheet.CreateRow(0);

            Type itemType = collection[0].GetType();
            int columnIndex = 0; 
           foreach (PropertyInfo prop in itemType.GetProperties())
            {
                CreateCell(HeaderRow, columnIndex, prop.Name, borderedCellStyle);
                columnIndex++;
            }


            // This Where the Data row starts from
            int RowIndex = 1;

            ////Iteration through some collection
            //foreach ( object item in collection)
            //{
            //    //Creating the CurrentDataRow
            //    IRow CurrentRow = Sheet.CreateRow(RowIndex);
            //    foreach (PropertyInfo prop in item.GetType().GetProperties())
            //    {
            //     //   prop.GetCustomAttribute(System.ComponentModel.DataAnnotation.Disp)
            //    }

            //    CreateCell(CurrentRow, 0, batchErrorReport.Name, borderedCellStyle);
            //    // This will be used to calculate the merge area
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
            //    RowIndex = NumberOfRules >= 1 ? RowIndex : RowIndex + 1;
            //}
            //// Auto sized all the affected columns
            //int lastColumNum = Sheet.GetRow(0).LastCellNum;
            //for (int i = 0; i <= lastColumNum; i++)
            //{
            //    Sheet.AutoSizeColumn(i);
            //    GC.Collect();
            //}
            //// Write Excel to disk 
            //using (var fileData = new FileStream(Utility.DOCUMENT_PATH + "ReportName.xls", FileMode.Create))
            //{
            //    workbook.Write(fileData);
            //}
        }
        
    }
}
