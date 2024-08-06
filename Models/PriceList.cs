using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    public class PriceList
    {
        public int PriceListId { get; set; } = 0; 

        [Required(ErrorMessage = "Выберите производителя!")]
        [Display(Name = "Предприятие производитель")]
        public int CompanyId { get; set; }

        //[Required(ErrorMessage = "Выберите производителя!")]
        [Display(Name = "Предприятие производитель")]
        public Company Manufacture { get; set; }

        [Required(ErrorMessage = "Введите наименование прейскуранта!")]
        [Display(Name = "Наименование прейскуранта")]
        public string Name { get; set; }
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Введите начало действия прейскуранта!")]
        [Display(Name = "Начало действия")]
        public DateTime DateStart { get; set; } = DateTime.Now;
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Окончание действия")]
        [Required(ErrorMessage = "Введите окончание действия прейскуранта!")]
        public DateTime DateEnd { get; set; } = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
        [Display(Name = "Описание")]
        public string? Description { get; set; }
        [Display(Name = "Скан-копия прейскуранта")]
        public string? ScanOfPrice { get; set; }
        [Required(ErrorMessage = "Выберите тип прейскуранта!")]
        [Display(Name = "Тип")]
        public int PriceItemTypeID { get; set; }
        /// <summary>
        /// тип прейскуранта: резисторы, конденсатоы и тп
        /// </summary>
        public PriceItemType PriceItemType { get; set; }


        public List<Price> PriceItems { get; set; } = new List<Price>();
    }
}
