using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Models.ViewModels
{
    public class RequestOperationGroupView
    {
        public int OperationID { get; set; }
        [Display(Name = "Наименование")]
        public string Name {get;set;}
        [Display(Name = "Выполняется?")]
        public bool IsExecute{get;set;}
        [Display(Name = "Кол-во операций")]
        public int ExecuteCount{get;set;}

        [Required]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Объём выборки это число!")]
        [Display(Name = "Объём выборки, шт")]
        public int SampleCount { get; set; }

        public int Order { get; set; }

        [Display(Name = "Группа")]
        public string OperationGroupCode { get; set; }

    }
}
