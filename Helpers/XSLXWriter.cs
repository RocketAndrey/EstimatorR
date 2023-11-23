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
using NPOI.XWPF.UserModel;
using Estimator.Migrations;


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
           // Cell.fo
            
        }
        private void CreateFormulaCell(IRow CurrentRow, int CellIndex, string formulaValue, XSSFCellStyle Style)
        {
            NPOI.SS.UserModel.ICell Cell = CurrentRow.CreateCell(CellIndex);
            Cell.SetCellType(CellType.Formula);
            Cell.CellFormula= formulaValue; 
          
            IDataFormat dataFormatCustom = CurrentRow.Sheet.Workbook.CreateDataFormat();
            XSSFCellStyle st = (XSSFCellStyle)Style.Clone();
            st.DataFormat = dataFormatCustom.GetFormat("0.00");// dataFormatCustom.GetFormat("0,00");
            Cell.CellStyle = st;

        }
        private void CreateDecimalCell(IRow CurrentRow, int CellIndex, decimal Value, XSSFCellStyle Style)
        {
            NPOI.SS.UserModel.ICell Cell = CurrentRow.CreateCell(CellIndex);
            Cell.SetCellType(CellType.Numeric);
            Cell.SetCellValue((double)Value);
            IDataFormat dataFormatCustom = CurrentRow.Sheet.Workbook.CreateDataFormat();
            XSSFCellStyle st = (XSSFCellStyle)Style.Clone();
            st.DataFormat = dataFormatCustom.GetFormat("0.00");// dataFormatCustom.GetFormat("0,00");
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
        /// <summary>
        /// Добавяет в раннее загруженнй файл колонку с данными рассчёта
        /// </summary>
        /// <param name="elementImport"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool AddReportDataToXLSX(ElementImport elementImport, out string errorMessage)

        {
            if(elementImport==null)
            {
                errorMessage = "ElementImport не найден!";
                return false;   
            }

            errorMessage = ""; 
            if (System.IO.File.Exists(FileName))
            {
                try
                {


                    FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);

                    IWorkbook workbook = new XSSFWorkbook(stream);
                    ISheet sheet = workbook.GetSheetAt(0);
                    //font 
                    XSSFFont myFont = (XSSFFont)workbook.CreateFont();
                    myFont.FontHeightInPoints = 11;
                    myFont.FontName = "Calibri";
                    // Defining a border
                    XSSFCellStyle cellStyle = (XSSFCellStyle)workbook.CreateCellStyle();
               
                    cellStyle.SetFont(myFont);
                    ///высчитываем максимальное число колонок 
                    int maxColimnCount = 0;
                    for (int i = 0; i <= sheet.LastRowNum; i++)

                    {
                        int colIndex = 0;
                        IRow row = sheet.GetRow(i);
                        if (row != null)
                        {
                            
                            foreach (NPOI.SS.UserModel.ICell cell in row.Cells)
                            {
                                colIndex++;
                            }
                        }
                        if (colIndex > maxColimnCount) maxColimnCount=colIndex;
                    }
                    // добавляем заголовок 
                    if (elementImport.FirstRowNumber > 1)
                    {
                        var prop = elementImport.XLSXElementTypes[0].GetType().GetProperty("OwnCost");

                        if (prop != null) CreateCell(sheet.GetRow(0), maxColimnCount, GetProrertyDisplayName(prop), cellStyle);

                    }
                    // а теперь добвавляем колонку с данными 
                    for (int i = 0; i <= sheet.LastRowNum; i++)

                    {
                        IRow row = sheet.GetRow(i);
                        if (row != null)
                        {
                            foreach (var item in elementImport.XLSXElementTypes)
                            { 
                                if (item.RowNum  == i+1)
                                {
                                    CreateDecimalCell(row, maxColimnCount, item.OwnCost, cellStyle);
                                }
                            }
                        }
                      
                    }
                   
                    stream.Close();

                    if (!String.IsNullOrEmpty(FileName))
                    {
                        string path = Path.GetDirectoryName(FileName) + "/FillElementList" + elementImport.CustomerRequestID.ToString() + ".xlsx";
                        // Write Excel to disk 
                        var fileData = new FileStream(path, FileMode.Create, FileAccess.Write);
                        workbook.Write(fileData);
                        fileData.Close();

                    }
                    return true;
                }
                catch (Exception e)
                {
                    errorMessage = e.Message;
                    return false;
                }
            }
            else
            {
                errorMessage = "Файл " + FileName +" не найден";
                return false;   
            }
          
        }
        /// <summary>
        /// выводит весь список с даннми для рассчета в Excel  файл 
        /// </summary>
        /// <param name="elementImport"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool CreateXSLXFileElements(ElementImport elementImport,out string errorMessage)
        {
            errorMessage = "";
            if (elementImport == null)
            {
                errorMessage = "ElementImport не найден!";
                return false;
            }
            try
            {
                IWorkbook workbook = new XSSFWorkbook();
                XSSFFont myFont = (XSSFFont)workbook.CreateFont();
                myFont.FontHeightInPoints = 11;
                myFont.FontName = "Calibri";


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
                if (elementImport.ImportElementPrice)
                {
                    prop = itemType.GetProperty("ElementPrice");
                    if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
                    columnIndex++;
                    prop = itemType.GetProperty("TotalPrice");
                    if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
                    columnIndex++;
                }
                if (elementImport.ImportElementКitPrice)
                { 
                     prop = itemType.GetProperty("ElementKitPrice");
                    if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
                    columnIndex++;
                }
                if (elementImport.ImportElementContractorPrice)
                {
                    prop = itemType.GetProperty("ElementContractorPrice");
                    if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
                    columnIndex++;
                }
                if (elementImport.CustomerRequest.ChildCustomerRequest != null)
                {
                    // есть  дочерняя заявка 
                    prop = itemType.GetProperty("ChildElementOwnCost");
                    if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), borderedCellStyle);
                    columnIndex++;
                }
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
                    int colIndex = 0;

                    CreateCell(CurrentRow, colIndex++, item.RowNum.ToString(), borderedCellStyle);
                 
                    CreateCell(CurrentRow, colIndex++, item.ElementName, borderedCellStyle);
              
                    CreateCell(CurrentRow, colIndex++, item.ElementTypeName.ToString(), borderedCellStyle);
           
                    CreateIntegerCell(CurrentRow, colIndex++, item.ElementCount, borderedCellStyle);
           
                    if (elementImport.ImportElementPrice) CreateDecimalCell(CurrentRow, colIndex++, item.ElementPrice, borderedCellStyle);
                    
                    if (elementImport.ImportElementPrice) CreateDecimalCell(CurrentRow, colIndex++, item.TotalPrice, borderedCellStyle);
                  
                    if (elementImport.ImportElementКitPrice)CreateDecimalCell(CurrentRow, colIndex++, item.ElementKitPrice, borderedCellStyle);
                 
                    if (elementImport.ImportElementContractorPrice) CreateDecimalCell(CurrentRow, colIndex++, item.ElementContractorPrice, borderedCellStyle);

                    if (elementImport.CustomerRequest.ChildCustomerRequest != null) CreateDecimalCell(CurrentRow, colIndex++, item.ChildElementOwnCost, borderedCellStyle);

                    CreateDecimalCell(CurrentRow, colIndex++, item.OwnCost, borderedCellStyle);
                    
                    CreateDecimalCell(CurrentRow, colIndex++, item.ElementFullCost, borderedCellStyle);
                   
                    CreateDecimalCell(CurrentRow, colIndex++, item.FullCost, borderedCellStyle);
                    RowIndex++;
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
                    using var fileData = new FileStream(FileName, FileMode.Create, FileAccess.Write);


                    workbook.Write(fileData);
                    fileData.Close();
                }
                return true;
            }
            catch (Exception ex) 
            { 
                errorMessage = ex.Message;
                return false;
            }
        }
        /// <summary>
        /// Формирует коммерческое предложение 
        /// </summary>
        /// <param name="elementImport"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool CreateInvoce(ElementImport elementImport,out string errorMessage)
        {
            errorMessage = "";
            if (elementImport == null)
            {
                errorMessage = "ElementImport не найден!";
                return false;
            }
            try
            {
                IWorkbook workbook = new XSSFWorkbook();

                XSSFFont cellFont = (XSSFFont)workbook.CreateFont();
                cellFont.FontHeightInPoints = 11;
                cellFont.FontName = "Calibri";

                XSSFFont headerFont = (XSSFFont)workbook.CreateFont();
                headerFont.FontHeightInPoints = 11;
                headerFont.FontName = "Calibri";
                headerFont.IsBold = true;   

                // Defining a border
                XSSFCellStyle borderedCellStyle = (XSSFCellStyle)workbook.CreateCellStyle();
                borderedCellStyle.SetFont(cellFont);
                borderedCellStyle.BorderLeft = BorderStyle.Medium;
                borderedCellStyle.BorderTop = BorderStyle.Medium;
                borderedCellStyle.BorderRight = BorderStyle.Medium;
                borderedCellStyle.BorderBottom = BorderStyle.Medium;
                borderedCellStyle.VerticalAlignment = VerticalAlignment.Center;
                // Defining a border для заголовка 
                XSSFCellStyle headerCellStyle = (XSSFCellStyle)workbook.CreateCellStyle();
                headerCellStyle.SetFont(headerFont);
                headerCellStyle.BorderLeft = BorderStyle.Medium;
                headerCellStyle.BorderTop = BorderStyle.Medium;
                headerCellStyle.BorderRight = BorderStyle.Medium;
                headerCellStyle.BorderBottom = BorderStyle.Medium;
                headerCellStyle.VerticalAlignment = VerticalAlignment.Center;


                ISheet Sheet = workbook.CreateSheet("Invoce");
                //Creat The Headers of the excel
                IRow HeaderRow = Sheet.CreateRow(0);


                Type itemType = elementImport.XLSXElementTypes[0].GetType();

                int columnIndex = 0;
                //A
                var prop = itemType.GetProperty("RowNum");
                if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), headerCellStyle);
                columnIndex++;
               //B
                prop = itemType.GetProperty("ElementName");
                if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), headerCellStyle);
                columnIndex++;
                //C
                prop = itemType.GetProperty("ElementCount");
                if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), headerCellStyle);
                columnIndex++;
                //D
                prop = itemType.GetProperty("ElementFullCost");
                if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), headerCellStyle);
                columnIndex++;
                //F
                prop = itemType.GetProperty("FullCost");
                if (prop != null) CreateCell(HeaderRow, columnIndex, GetProrertyDisplayName(prop), headerCellStyle);

                columnIndex++;

                decimal totalCost = 0;

                //This Where the Data row starts from
                int RowIndex = 1;
                IRow CurrentRow; 
                //Iteration through some collection
                foreach (var item in elementImport.XLSXElementTypes)
                {
                    //Creating the CurrentDataRow
                    CurrentRow = Sheet.CreateRow(RowIndex);
                    int colIndex = 0;

                    CreateCell(CurrentRow, colIndex++, item.RowNum.ToString(), borderedCellStyle);

                    CreateCell(CurrentRow, colIndex++, item.ElementName, borderedCellStyle);

                    CreateIntegerCell(CurrentRow, colIndex++, item.ElementCount, borderedCellStyle);

                    CreateDecimalCell(CurrentRow, colIndex++, item.ElementFullCost, borderedCellStyle);

                    ////CreateDecimalCell(CurrentRow, colIndex++, item.ElementFullCost, borderedCellStyle);
                    //if (elementImport.CustomerRequest.ChildCustomerRequest != null)
                    //{
                    //    string colNameChild = elementImport.CustomerRequest.ChildCustomerRequest.Program.Name + " " + Html.DisplayNameFor(model => model.ElementImport.XLSXElementTypes[0].OwnCost).ToString();

                    //                                < th > @colNameChild </ th >


                    //                            }
                    CreateFormulaCell(CurrentRow, colIndex++,string.Format("C{0}*D{0}",RowIndex+1), borderedCellStyle);
                    
                    totalCost = totalCost + (item.ElementCount * item.ElementFullCost);

                    RowIndex++;
                }
                CurrentRow = Sheet.CreateRow(RowIndex);
                CreateCell(CurrentRow, 3, "Итого:", headerCellStyle);
                CreateDecimalCell(CurrentRow, 4, totalCost , headerCellStyle);

                CurrentRow = Sheet.CreateRow(++RowIndex);
                CreateCell(CurrentRow, 3, "НДС 20%:", headerCellStyle);
                CreateFormulaCell(CurrentRow, 4,string.Format( "E{0}*20/100", RowIndex), headerCellStyle);
                CurrentRow = Sheet.CreateRow(++RowIndex);
                CreateCell(CurrentRow, 3, "Всего к оплате:", headerCellStyle);
                CreateFormulaCell(CurrentRow, 4, string.Format("E{0}+E{1}", RowIndex ,RowIndex-1), headerCellStyle);


                // Auto sized all the affected columns
                int lastColumNum = Sheet.GetRow(0).LastCellNum;

                for (int i = 0; i <= lastColumNum; i++)
                {
                    Sheet.AutoSizeColumn(i);
                    GC.Collect();
                }
                XSSFFormulaEvaluator.EvaluateAllFormulaCells(workbook);

                if (!String.IsNullOrEmpty(FileName))
                {
                    // Write Excel to disk 
                    using var fileData = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                    workbook.Write(fileData);
                    fileData.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
        private string GetProrertyDisplayName(PropertyInfo pInfo)
        {
            // получаем все атрибуты класса
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
