using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text;
using System.IO;
using Estimator.Models;
using Estimator.Migrations;
using Microsoft.Extensions.Logging;
using NPOI.XSSF.Model;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using System.Data;

namespace Estimator.Helpers
{
    public class XLSXhelper
    {
        /// <summary>
        /// https://stackoverflow.com/questions/5855813/how-to-read-file-using-npoi
        /// </summary>
        /// <param name="memStream"></param>
        /// <returns></returns>
        public List<Estimator.Models.XLSXElementType> Convert(Stream memStream, Estimator.Models.ElementImport importSettings, out bool result, out string errorMessage)
        { 
            XLSXElementType elementType;
                List<Models.XLSXElementType> returnValue = new();
                result = true;
                errorMessage = "";

                //переменные для расчета пустых сторок
                int emptyNames = 0;
                int emptyCounts = 0;
            //для идентификации ошибочноий строки 
                int currentRowIndex = 0  ; 

                IWorkbook workbook = null;  //IWorkbook determina si es xls o xlsx              
                ISheet worksheet = null;

            try
            {

                currentRowIndex = 0;
                workbook = WorkbookFactory.Create(memStream);          //Abre tanto XLS como XLSX
                worksheet = workbook.GetSheetAt(0);

                if (workbook.NumberOfSheets > 1)
                {
                    result = false;
                    errorMessage = "В импортируемой книге Эксель должен быть только 1 лист!";
                    return returnValue;
                }

                if (workbook.NumberOfSheets == 0)
                {
                    result = false;
                    errorMessage = "В импортируемая книга Эксель не содержит ни одного листа!";
                    return returnValue;
                }


                for (int rowIndex = 1; rowIndex <= worksheet.LastRowNum + 1; rowIndex++)
                {
                    currentRowIndex=rowIndex;   
                    IRow row = worksheet.GetRow(rowIndex);

                    if (row != null) //null is when the row only contains empty cells 
                    {
                        int rowindex = row.RowNum + 1;
                        string refName = importSettings.ElementNameColumn.ToString() + rowindex.ToString();
                        string refKey = importSettings.ElementTypeKeyColumn.ToString() + rowindex.ToString();
                        string refCount = importSettings.ElementCountColumn.ToString() + rowindex.ToString();
                        string refPrice = importSettings.ElementPriceColumn.ToString() + rowindex.ToString();
                        string refKitPrice = importSettings.ElementKitPriceColumn.ToString() + rowindex.ToString();
                        string refContractorPrice = importSettings.ElementContractorPriceColumn.ToString() + rowindex.ToString();
                        string refDeliveryTime = importSettings.DeliveryTimeColumn.ToString() + rowindex.ToString();
                        if (row.RowNum >= (importSettings.FirstRowNumber - 1) | !importSettings.FirstRowIsHeader)
                        {
                            if (!importSettings.UseLastRowNumber | row.RowNum <= (importSettings.LastRowNumber - 1))
                            {

                                elementType = new XLSXElementType();

                                foreach (ICell cell in row.Cells)
                                {
                                    string cellValue = string.Empty;

                                    // запоминаем номер строки
                                    elementType.RowNum = (int)row.RowNum + 1;

                                    //Наименование элемента
                                    if (cell.Address.ToString() == refName) elementType.ElementName = GetCellvalue(cell);

                                    //ключ элемента
                                    else if (cell.Address.ToString() == refKey) elementType.ElementTypeKey = GetCellvalue(cell);
                                    //колличество
                                    else if (cell.Address.ToString() == refCount)
                                    {
                                        string strValue = GetCellvalue(cell).Replace(" ", "").Trim();

                                        if (int.TryParse(strValue, out int i))
                                        {
                                            elementType.ElementCount = i;
                                        }

                                    }
                                    //цена 1 элемента
                                    else if (cell.Address.ToString() == refPrice && importSettings.ImportElementPrice)
                                    {
                                        decimal d = 0;
                                        if (importSettings.ImportElementPrice)
                                        {

                                            // если не парсится то 0.00
                                            d = ParceDecimal(cell);
                                        }

                                        elementType.ElementPrice = d;
                                    }
                                    //стоимость остнастки
                                    else if (cell.Address.ToString() == refKitPrice && importSettings.ImportElementКitPrice)
                                    {
                                        decimal d = 0;
                                        if (importSettings.ImportElementКitPrice)
                                        {
                                            d = ParceDecimal(cell);
                                        }
                                        elementType.ElementKitPrice = d;
                                    }
                                    //стоимость сторонних 
                                    else if (cell.Address.ToString() == refContractorPrice && importSettings.ImportElementContractorPrice)
                                    {
                                        decimal d = 0;
                                        if (importSettings.ImportElementContractorPrice)
                                        {
                                            d = ParceDecimal(cell);
                                        }
                                        elementType.ElementContractorPrice = d;
                                    }
                                    //срок закупки (поставки)
                                    else if (cell.Address.ToString() == refDeliveryTime && importSettings.ImportDeliveryTime)
                                    {
                                        if (importSettings.ImportDeliveryTime)
                                        {
                                            string strValue = GetCellvalue(cell).Replace(" ", "").Trim();

                                            if (int.TryParse(strValue, out int i))
                                            {

                                                elementType.DeliveryTime = i;
                                            }

                                        }
                                    }


                                }
                                if (elementType.ElementCount == 0) { emptyCounts++; }

                                if (String.IsNullOrEmpty(elementType.ElementName)) { emptyNames++; }

                                bool elementExist = false;

                                //услли такой элемент уже есть то просто добавляем колличествою 
                                foreach (var element in returnValue)
                                {
                                    if (element.ElementName ==  elementType.ElementName)
                                    {
                                        elementExist= true;
                                        element.ElementCount += elementType.ElementCount;
                                        break; 
                                    }
                                }

                                // если колличествов данной строке = 0 то нефиг его и импортировать
                                if (!elementExist && elementType.ElementCount > 0 && !String.IsNullOrEmpty(elementType.ElementName))
                                {
                                    returnValue.Add(elementType);
                                }
                                elementExist = false;

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


                    }

                }

            }
            catch (Exception ex)

            {
                 result = false;
                errorMessage = ex.Message + " строка " + currentRowIndex;
                
            }
            return returnValue;
        }
  
        private decimal ParceDecimal(ICell cell)
        {
            decimal d;
            string svalue = GetCellvalue(cell).Trim().Replace(".", ",");
           if ( decimal.TryParse(svalue, out d))  return d;
            return 0;
        }

        private string GetCellvalue(ICell cell)
        {
            string result=""; 
            switch (cell.CellType)
            {
                case CellType.Blank: result = ""; break;
                case CellType.Boolean: result = cell.BooleanCellValue.ToString(); break;
                case CellType.String: result = cell.StringCellValue; break;
                case CellType.Numeric:
                    if (HSSFDateUtil.IsCellDateFormatted(cell)) { result = cell.DateCellValue.ToString(); }
                    else { result = cell.NumericCellValue.ToString(); }
                    break;
                case CellType.Formula:
                    switch (cell.CachedFormulaResultType)
                    {
                        case CellType.Blank: result = ""; break;
                        case CellType.String: result = cell.StringCellValue; break;
                        case CellType.Boolean: result = cell.BooleanCellValue.ToString(); break;
                        case CellType.Numeric:
                            if (HSSFDateUtil.IsCellDateFormatted(cell)) { result = cell.DateCellValue.ToString(); }
                            else { result = cell.NumericCellValue.ToString(); }
                            break;
                    }
                    break;
                default: result = cell.StringCellValue; break;
                    
            }
            return result;
        }

    }
}