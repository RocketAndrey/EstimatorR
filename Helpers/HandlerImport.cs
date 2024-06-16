using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.Util;
using NPOI.HSSF.Util;
using Microsoft.AspNetCore.Http;
using NPOI.SS.Formula.Functions;
using Estimator.Models;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace Estimator.Helpers
{
    public class HandlerImport
    {
        public bool _useFirstRow { get; set; }
        public int _selRow { get; set; }
        public int _selCost { get; set; }
        public int _selStandartPack { get; set; }
        public int _selStandartDelivery { get; set; }
        public int _selTimeDelivery { get; set; }
        public int _PriceListId { get; set; }
        public int _selCode { get; set; }
        public int _selName { get; set; }
        public int _selNote { get; set; }
        public string _path_File { get; set; }
        public int _selGroup { get; set; }
        public int _selSubGroup { get; set; }
        public int _selManuf { get; set; }
        public int _selQuality { get; set; }

        public List<Company> addFactory;

        public List<RuChipsDB> addDirVniir;

        public List<Price> addPrice;

        Data.EstimatorContext context;

        public HandlerImport(string path_File)
        {
            _path_File = path_File;
        }
        public HandlerImport(string path_File, int selCode, int selName, int selNote, bool useFirstRow)
        {
            _path_File = path_File;
            _selCode = selCode;
            _selName = selName;
            _selNote = selNote;
            _useFirstRow = useFirstRow;
        }
        public HandlerImport(string path_File, int selGroup, int selSubGroup, int selName, int selManuf, int selQuality, bool useFirstRow, Data.EstimatorContext db)
        {
            _path_File = path_File;
            _selGroup = selGroup;
            _selSubGroup = selSubGroup;
            _selName = selName;
            _selManuf = selManuf;
            _selQuality = selQuality;
            _useFirstRow = useFirstRow;

            context = db;
        }

        public HandlerImport(string path_File, int selRow, int selName, int selCost, int selStandartPack, int selStandartDelivery, int selTimeDelivery, int PriceListID,Data.EstimatorContext db)
        {
            _path_File = path_File;
            _selRow = selRow;
            _selName = selName;
            _selCost = selCost;
            _selStandartPack = selStandartPack;
            _selStandartDelivery = selStandartDelivery;
            _selTimeDelivery = selTimeDelivery;
            _PriceListId = PriceListID;

            context = db;
        }

        public List<Company> ImportFileManufacturer()
        {
            try
            {
                // Открытие существующей рабочей книги
                IWorkbook workbook;

                using (FileStream fileStream = new FileStream(_path_File, FileMode.Open, FileAccess.Read))
                {
                    workbook = new XSSFWorkbook(fileStream);
                }

                ISheet worksheet = workbook.GetSheetAt(0);

                var rowCount = worksheet.LastRowNum;

                addFactory = new List<Company>();

                for (int row = 0; row <= rowCount; row++)
                {
                    //Проверка на строку-заголовок
                    if (row == 0 && _useFirstRow == false)
                        row++;

                    IRow row_Line = worksheet.GetRow(row);
                    if (row_Line.GetCell(_selCode - 1) != null && row_Line.GetCell(_selName - 1) != null && row_Line.GetCell(_selNote - 1) != null)

                        addFactory.Add(new Company()
                        {
                            Code = row_Line.GetCell(_selCode - 1).ToString(),
                            Name = row_Line.GetCell(_selName - 1).ToString(),
                            Note = row_Line.GetCell(_selNote - 1).ToString(),
                        });
                }
            }
            catch (Exception ex)
            {
                //Message = "Error while parsing the file. Check the column order and format.";
                //return Page();
            }
            return addFactory;
        }
        public List<RuChipsDB> ImportFileRuChips()
        {
            try
            {
                // Открытие существующей рабочей книги
                IWorkbook workbook;

                using (FileStream fileStream = new FileStream(_path_File, FileMode.Open, FileAccess.Read))
                {
                    workbook = new XSSFWorkbook(fileStream);
                }

                ISheet worksheet = workbook.GetSheetAt(0);

                var rowCount = worksheet.LastRowNum;

                addDirVniir = new List<RuChipsDB>();

                //System.Diagnostics.Debug.WriteLine("count in Ex:" + rowCount);
                for (int row = 0; row <= rowCount; row++)
                {
                    //Проверка на строку-заголовок
                    if (row == 0 && _useFirstRow == false)
                        row++;

                    IRow row_Line = worksheet.GetRow(row);
                    if (row_Line.GetCell(_selName - 1) != null)
                    {

                        string tmp_Man;
                        //Проверка на существоание компании в "Списке производителей"
                        if (context.Companies.FirstOrDefault(x => x.Name == row_Line.GetCell(_selManuf - 1).ToString()) != null)
                            tmp_Man = context.Companies.FirstOrDefault(x => x.Name == row_Line.GetCell(_selManuf - 1).ToString()).Code;
                        else tmp_Man = "-";

                        string tmp_Ql;
                        if (row_Line.GetCell(_selQuality - 1) == null)
                            tmp_Ql = "ВП [0001]";
                        else tmp_Ql = row_Line.GetCell(_selQuality - 1).ToString();

                        addDirVniir.Add(new RuChipsDB()
                        {
                            Group = row_Line.GetCell(_selGroup - 1).ToString(),
                            Subgroup = row_Line.GetCell(_selSubGroup - 1).ToString(),
                            Name = row_Line.GetCell(_selName - 1).ToString(),
                            Manufacturer = row_Line.GetCell(_selManuf - 1).ToString(),
                            CodeManufacturer = tmp_Man,
                            QLevel = tmp_Ql,
                        });
                    }
                    System.Diagnostics.Debug.WriteLine(row_Line.ToString() + " || " + row);
                }
                System.Diagnostics.Debug.WriteLine("count in Ex:" + rowCount);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                //Message = "Error while parsing the file. Check the column order and format.";
                //return Page();
            }
            return addDirVniir;
        }

        public List<Price> ImportFilePrice()
        {
            try
            {
                // Открытие существующей рабочей книги
                IWorkbook workbook;
                
                using (FileStream fileStream = new FileStream(_path_File, FileMode.Open, FileAccess.Read))
                {
                    workbook = new XSSFWorkbook(fileStream);
                }
                
                ISheet worksheet = workbook.GetSheetAt(0);

                var rowCount = worksheet.LastRowNum;

                addPrice = new List<Price>();
                
                for (int row = _selRow-2; row <= rowCount; row++)
                {
                    IRow row_Line = worksheet.GetRow(row);
                    if (row_Line.GetCell(_selName - 1) != null)
                    {

                        int tmp_VniirId;

                        //Проверка на существоание компании в "Справочнике ВНИИР"
                        if (context.DirVniir.FirstOrDefault(x => x.Name == row_Line.GetCell(_selName - 1).ToString()) != null)
                            tmp_VniirId = context.DirVniir.FirstOrDefault(x => x.Name == row_Line.GetCell(_selName - 1).ToString()).Id;
                        else tmp_VniirId = 0;

                        int tmp_SD;
                        if (row_Line.GetCell(_selStandartDelivery - 1) == null)
                            tmp_SD = 1;
                        else int.TryParse(row_Line.GetCell(_selStandartDelivery - 1).ToString(),out tmp_SD);

                        int tmp_SP;
                        if (row_Line.GetCell(_selStandartPack - 1) == null)
                            tmp_SP = 1;
                        else int.TryParse(row_Line.GetCell(_selStandartPack - 1).ToString(), out tmp_SP);

                        double tmp_Price;
                        if (row_Line.GetCell(_selCost - 1).CellType == CellType.Formula)
                            tmp_Price = row_Line.GetCell(_selCost - 1).NumericCellValue;
                        else tmp_Price = double.Parse(row_Line.GetCell(_selCost - 1).ToString());

                        addPrice.Add(new Price()
                        {
                            PriceListId= _PriceListId,
                            VniirId= tmp_VniirId,
                            Name = row_Line.GetCell(_selName - 1).ToString(),
                            Cost = tmp_Price,
                            StandartDelivery = tmp_SD,
                            StandartPack = tmp_SP,
                            TimeDelivery = int.Parse(row_Line.GetCell(_selTimeDelivery - 1).ToString()),

                        });
                    }
                }                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                //Message = "Error while parsing the file. Check the column order and format.";
                //return Page();
            }
            return addPrice;
        }

        public List<string> takeData(string _path)
        {
            List<string> _firstRow = new List<string>();

            try
            {
                // Открытие существующей рабочей книги
                IWorkbook workbook;

                using (FileStream fileStream = new FileStream(_path, FileMode.Open, FileAccess.Read))
                {
                    workbook = new XSSFWorkbook(fileStream);
                }

                ISheet worksheet = workbook.GetSheetAt(0);

                var rowCount = worksheet.LastRowNum;

                IRow row_Line = worksheet.GetRow(0);

                for (int i = 0; i < row_Line.LastCellNum; i++)
                {
                    if (row_Line.GetCell(i) != null)
                    {
                        _firstRow.Add(row_Line.GetCell(i).ToString());
                    }
                    else
                    {
                        _firstRow.Add("-");
                    }
                }
            }
            catch (Exception ex)
            {
                //Message = "Error while parsing the file. Check the column order and format.";
                //return Page();
            }

            return _firstRow;
        }

        public List<List<string>> takeAllData(string _path)
        {

            List<List<string>> _firstRow = new List<List<string>>();

            try
            {
                // Открытие существующей рабочей книги
                IWorkbook workbook;

                using (FileStream fileStream = new FileStream(_path, FileMode.Open, FileAccess.Read))
                {
                    workbook = new XSSFWorkbook(fileStream);
                }

                ISheet worksheet = workbook.GetSheetAt(0);

                //var rowCount = worksheet.LastRowNum;

                //IRow row_Line = worksheet.GetRow(0);

                int max = 0;
                for (int i = worksheet.FirstRowNum; i < 20; i++)
                {
                    IRow row_Line = worksheet.GetRow(i);

                    if (row_Line != null && row_Line.LastCellNum > max)
                        max = row_Line.LastCellNum; 


                }
                //List<string> firstTmpRow = new List<string>();
                //for (int i = 0; i < max; i++)
                //{
                //    firstTmpRow.Add("");

                //}
                //_firstRow.Add(firstTmpRow);
                System.Diagnostics.Debug.WriteLine("____________________________________ " + worksheet.FirstRowNum);
                for (int i = worksheet.FirstRowNum; i < 20; i++)
                {
                    IRow row_Line = worksheet.GetRow(i);

                    if (row_Line != null)
                    {
                        List<string> row = new List<string>();

                        for (int j = row_Line.FirstCellNum; j < row_Line.LastCellNum; j++)
                        {

                            if (row_Line.GetCell(j) != null)
                            {
                                row.Add(row_Line.GetCell(j).ToString());
                            }
                            else
                            {
                                row.Add("-");
                            }

                        }
                        _firstRow.Add(row);
                    }
                
                }

                List<string> lastTmpRow = new List<string>();

                for (int i = 0; i < max; i++)
                {
                    lastTmpRow.Add("...");

                }
                _firstRow.Add(lastTmpRow);
            }
            catch (Exception ex)
            {
                //Message = "Error while parsing the file. Check the column order and format.";
                //return Page();
            }

            return _firstRow;
        }
    }
}
