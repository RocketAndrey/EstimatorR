using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Text;
using System.IO;
using Estimator.Models;

namespace Estimator.Helpers
{
    public class XLSXhelper
    {
        /// <summary>
        /// https://habr.com/ru/post/491090/
        /// </summary>
        /// <param name="memStream"></param>
        /// <returns></returns>
        public string Convert(Stream memStream)
        {
            return SpreadsheetProcess(memStream);
        }
        public List<Estimator.Models.XLSXElementType> Convert(Stream memStream, Estimator.Models.ElementImport importSettings)
        {
            List<Models.XLSXElementType> returnValue = new List<XLSXElementType>();
            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(memStream, false))
            {
        
                XLSXElementType elementType;

                memStream.Position = 0;
                ///shared ячейки (в которых хранятся повторяемые значения). Так вот, из объекта класса SpreadsheetDocument их можно получить так:
                SharedStringTable sharedStringTable = doc.WorkbookPart.SharedStringTablePart.SharedStringTable;
                //используем только первый лист!
                WorksheetPart worksheetPart = doc.WorkbookPart.WorksheetParts.First();
                //перебираем все строки
                foreach (SheetData sheetData in worksheetPart.Worksheet.Elements<SheetData>())
                {
                    if (sheetData.HasChildren)
                    {

                        foreach (Row row in sheetData.Elements<Row>())
                        {
                         
                            if (row.RowIndex > 1 | !importSettings.FirstRowIsHeader)
                            {
                                    if(!importSettings.UseLastRowNumber | importSettings.UseLastRowNumber & row.RowIndex>importSettings.LastRowNumber)
                                    {

                               
                                        elementType = new XLSXElementType();

                                    foreach (Cell cell in row.Elements<Cell>())
                                    {
                                        string cellValue = string.Empty;

                                        string refName = importSettings.ElementNameColumn.ToString() + row.RowIndex.ToString();
                                        string refKey = importSettings.ElementTypeKeyColumn.ToString() + row.RowIndex.ToString();
                                        string refCount = importSettings.ElementCountColumn.ToString() + row.RowIndex.ToString();
                                        // запоминаем номер строки
                                        elementType.RowNum = (int)row.RowIndex.Value;


                                        if (cell.CellReference.Value.ToString() == refName)
                                        {
                                            elementType.ElementName = getCellvalue(cell, sharedStringTable);
                                        }
                                        else if (cell.CellReference.Value.ToString() == refKey)
                                        {
                                            elementType.ElementTypeKey = getCellvalue(cell, sharedStringTable);
                                        }
                                    
                                        else if (cell.CellReference.Value.ToString() == refCount)
                                        {
                                            int i;
                                            int.TryParse(getCellvalue(cell, sharedStringTable), out i);
                                            elementType.ElementCount = i;
                                        }
                                        
                                    }
                                    // если колличествов данной строке = 0 то нефиг его и импортировать
                                    if (elementType.ElementCount > 0)
                                    {
                                        returnValue.Add(elementType);
                                    }

                                }
                            }
                        }
                    }
                }
                
            }
            return returnValue;
        }
 


        private string getCellvalue(Cell cell, SharedStringTable sharedStringTable)
        {
            string cellValue = string.Empty;

            if (cell.CellFormula != null)
            {
                cellValue = cell.CellValue.InnerText;
            }
            else
            {
                cellValue = cell.InnerText;
                if (cell.DataType != null && cell.DataType == CellValues.SharedString)
                {
                    cellValue = sharedStringTable.ElementAt(Int32.Parse(cellValue)).InnerText;
                }
            }

            return cellValue;
        }
        string SpreadsheetProcess(Stream memStream)
        {
            ///открываем xlsx документ из потока
            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(memStream, false))
            {
                memStream.Position = 0;
                StringBuilder sb = new StringBuilder(1000);


                sb.Append("<?xml version=\"1.0\"?><documents><document>");
                ///shared ячейки (в которых хранятся повторяемые значения). Так вот, из объекта класса SpreadsheetDocument их можно получить так:
                SharedStringTable sharedStringTable = doc.WorkbookPart.SharedStringTablePart.SharedStringTable;
                int sheetIndex = 0;
                // перебираем все листы

                foreach (WorksheetPart worksheetPart in doc.WorkbookPart.WorksheetParts)
                {
                    WorkSheetProcess(sb, sharedStringTable, worksheetPart, doc, sheetIndex);
                    sheetIndex++;
                }
                sb.Append(@"</document></documents>");
                
                return sb.ToString();
            }
        }


        private void WorkSheetProcess(StringBuilder sb, SharedStringTable sharedStringTable, WorksheetPart worksheetPart, SpreadsheetDocument doc,
                int sheetIndex)
        {
            string sheetName = doc.WorkbookPart.Workbook.Descendants<Sheet>().ElementAt(sheetIndex).Name.ToString();
            sb.Append($"<sheet name=\"{sheetName}\">");

            foreach (SheetData sheetData in worksheetPart.Worksheet.Elements<SheetData>())
            {
                if (sheetData.HasChildren)
                {
                    foreach (Row row in sheetData.Elements<Row>())
                    {
                        RowProcess(row, sb, sharedStringTable);
                    }
                }
            }

            sb.Append($"</sheet>");
        }
        void RowProcess(Row row, StringBuilder sb, SharedStringTable sharedStringTable)
        {
            sb.Append("<row>");
            foreach (Cell cell in row.Elements<Cell>())
            {
                string cellValue = string.Empty;
                sb.Append("<cell>");
                if (cell.CellFormula != null)
                {
                    cellValue = cell.CellValue.InnerText;
                    sb.Append(cellValue);
                    sb.Append("</cell>");
                    continue;
                }
                cellValue = cell.InnerText;
                if (cell.DataType != null && cell.DataType == CellValues.SharedString)
                {
                    sb.Append(sharedStringTable.ElementAt(Int32.Parse(cellValue)).InnerText);
                }
                else
                {
                    sb.Append(cellValue);
                }
                sb.Append("</cell>");
            }
            sb.Append("</row>");
        }
    }
}