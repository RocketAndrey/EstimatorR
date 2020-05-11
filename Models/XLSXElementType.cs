﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{
    public class XLSXElementType
    {
        public XLSXElementType()
        {
            InList = true;
        }
        public int ID { get; set; }
        public int ElementImportID { get; set; }
        public ElementImport ElementImport { get; set; }
        public string ElementName { get; set; }
        public string ElementDatasheet { get; set; }

        public string ElementTypeKey { get; set; }

        public int ElementCount { get; set; }

        [NotMapped]
        public bool InList { get; set; }

        public int? ElementTypeID { get; set; }

        [NotMapped]
        public bool Valid { get; set; }
        [NotMapped]
        public string ErrorMessage
        {
            get;
            set;
        }
        [NotMapped]
        public string ElementTypeName { get; set; }
        /// <summary>
        /// Код протокола из АСУ
        /// </summary>

        public string? AsuProtokolCode { get; set; }
        /// <summary>
        /// Найдена запись в АСУ о испытания такого типа
        /// </summary>
        public bool IsAsuProtokolExists 
        { 
            get
            {
                if (!String.IsNullOrEmpty(AsuProtokolCode))
                {
                    return AsuProtokolCode.Length > 0;
                }
                else
                { 
                    return false;
                }
                
            }
                
        }

    }
}
