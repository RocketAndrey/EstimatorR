using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Text;
using System.IO;
using Estimator.Models;
using Estimator.Migrations;
using Microsoft.Extensions.Logging;
using NPOI.XSSF.Model;

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
        public List<Estimator.Models.XLSXElementType> Convert(Stream memStream, Estimator.Models.ElementImport importSettings, out bool result,out string errorMessage )
        {
            List<Models.XLSXElementType> returnValue = new();
            result = true;
            errorMessage = "";
            //переменные для расчета пустых сторjr
            int emptyNames = 0;
            int emptyCounts = 0;

            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(memStream, false))
            {
               

                XLSXElementType elementType;
                if (doc.WorkbookPart.WorksheetParts.Count() > 1)
                {
                    result = false;
                    errorMessage = "В импортируемой книге Эксель должен быть только 1 лист!";
                    return returnValue;
                }

                if (doc.WorkbookPart.WorksheetParts.Count() ==0)
                {
                    result = false;
                    errorMessage = "В импортируемая книга Эксель не содержит ни одного листа!";
                    return returnValue;
                }
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
                         
                            if (row.RowIndex >= importSettings.FirstRowNumber | !importSettings.FirstRowIsHeader)
                            {
                                    if(!importSettings.UseLastRowNumber |  row.RowIndex <= importSettings.LastRowNumber)
                                    {

                                        elementType = new XLSXElementType();

                                    foreach (Cell cell in row.Elements<Cell>())
                                    {
                                        string cellValue = string.Empty;

                                        string refName = importSettings.ElementNameColumn.ToString() + row.RowIndex.ToString();
                                        string refKey = importSettings.ElementTypeKeyColumn.ToString() + row.RowIndex.ToString();
                                        string refCount = importSettings.ElementCountColumn.ToString() + row.RowIndex.ToString();
                                        string refPrice = importSettings.ElementPriceColumn.ToString() + row.RowIndex.ToString();
                                        string refKitPrice = importSettings.ElementKitPriceColumn.ToString() + row.RowIndex.ToString();
                                        string refContractorPrice = importSettings.ElementContractorPriceColumn.ToString() + row.RowIndex.ToString();

                                        // запоминаем номер строки
                                        elementType.RowNum = (int)row.RowIndex.Value;

                                        //Наименование элемента
                                        if (cell.CellReference.Value.ToString() == refName)
                                        {
                                            elementType.ElementName = getCellvalue(cell, sharedStringTable);
                                        }
                                        //ключ элемента
                                        else if (cell.CellReference.Value.ToString() == refKey)
                                        {
                                            elementType.ElementTypeKey = getCellvalue(cell, sharedStringTable);
                                        }
                                        //цена 1 элемента
                                        else if(cell.CellReference.Value.ToString() ==refPrice)
                                        {
                                            decimal d= 0 ;
                                            if (importSettings.ImportElementPrice)
                                            {

                                                // если не парсится то 0.00
                                                d=ParceDecimal(cell, sharedStringTable);
                                            }

                                            elementType.ElementPrice = d;
                                        }
                                        //стоимость остнастки
                                        else if (cell.CellReference.Value.ToString() == refKitPrice)
                                        {
                                            decimal d = 0;
                                            if (importSettings.ImportElementКitPrice)
                                            {
                                                d = ParceDecimal(cell, sharedStringTable);
                                            }
                                            elementType.ElementKitPrice  = d;
                                        }
                                        //стоимость сторонних 
                                        else if (cell.CellReference.Value.ToString() == refContractorPrice)
                                        {
                                            decimal d = 0;
                                            if (importSettings.ImportElementContractorPrice)
                                            {
                                                d = ParceDecimal(cell, sharedStringTable);
                                            }
                                            elementType.ElementContractorPrice = d;
                                        }
                                        //колличество
                                        else if (cell.CellReference.Value.ToString() == refCount)
                                        {
                                            int i;
                                            int.TryParse(getCellvalue(cell, sharedStringTable), out i);
                                            elementType.ElementCount = i;
                                        }
                                        
                                    }
                                    if (elementType.ElementCount==0) { emptyCounts++; }
                                  
                                    if (String.IsNullOrEmpty(elementType.ElementName) ) {emptyNames++; }

                                    // если колличествов данной строке = 0 то нефиг его и импортировать
                                    if (elementType.ElementCount > 0 && !String.IsNullOrEmpty(elementType.ElementName))
                                    {
                                        returnValue.Add(elementType);
                                    }
    
                                    
                                }
                            }
                        }
                    }
                }

                if (emptyCounts > 0 || emptyNames > 0)
                {
                    if (returnValue.Count == 0)
                    {
                        ///ничего не импортнулось 
                        result = false;
                        errorMessage = string.Format("Не найдено ни одной строки для импорта. Строк с пустым имненем {0}. Строк с нулевым количеством {1}.", emptyNames, emptyCounts);
                    }
                    else 
                    {
                        errorMessage = string.Format("Строк с пустым именем {0}. Строк с нулевым количеством {1}.", emptyNames, emptyCounts);
                    }
                }
           
                return returnValue;
            }

       
        }
 
        private decimal ParceDecimal(Cell cell,SharedStringTable table)
        {
            decimal d;
            string svalue = getCellvalue(cell, table).Trim().Replace(".", ",");
            decimal.TryParse(svalue, out d);
            return d;
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