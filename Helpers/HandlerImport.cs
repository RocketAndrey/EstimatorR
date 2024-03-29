﻿using NPOI.SS.UserModel;
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

namespace webApp.Models
{
    public class HandlerImport
    {
        public bool _useFirstRow { get; set; }
        public int _selCode { get; set; }
        public int _selName { get; set; }
        public int _selNote { get; set; }
        public string _path_File { get; set; }
        public int _selGroup { get; set; }
        public int _selSubGroup { get; set; }
        public int _selManuf { get; set; }
        public int _selQuality { get; set; }

        public List<Company> addFactory ;
        
        public List<RuChipsDB> addDirVniir;

        Estimator.Data.EstimatorContext context;

        public HandlerImport(string path_File)
        {
            this._path_File = path_File;
        }
        public HandlerImport(string path_File, int selCode, int selName, int selNote, bool useFirstRow)
        {
            this._path_File = path_File;
            this._selCode = selCode;
            this._selName = selName;
            this._selNote = selNote;
            this._useFirstRow = useFirstRow;
        }
        public HandlerImport(string path_File, int selGroup, int selSubGroup, int selName, int selManuf, int selQuality, bool useFirstRow, Estimator.Data.EstimatorContext db)
        {
            this._path_File = path_File;
            this._selGroup = selGroup;
            this._selSubGroup = selSubGroup;
            this._selName = selName;
            this._selManuf = selManuf;
            this._selQuality = selQuality;
            this._useFirstRow = useFirstRow;

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
                //System.Diagnostics.Debug.WriteLine();
                System.Diagnostics.Debug.WriteLine("count in Ex:" + rowCount);
                for (int row = 0; row <= rowCount; row++)
                {
                    //Проверка на строку-заголовок
                    if (row == 0 && _useFirstRow == false)
                        row++;

                    IRow row_Line = worksheet.GetRow(row);
                    if (row_Line.GetCell(_selName - 1) != null) {

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
        public List<String> takeData(string _path)
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

                for(int i=0; i < row_Line.LastCellNum; i++)
                {
                    if(row_Line.GetCell(i) != null )
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
    }
}
