using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Estimator.Models
{
    public class ElementKey
    {
        public int ElementKeyID { get; set; }
        public ElementType ElementType { get; set; }
        //,ErrorMessage = "ИНН организации состоит из 10 цифр!")
        public int ElementTypeID { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Поле ключ должно быть заполнено")]
        [Display(Name = "Ключ")]
        [MinLength(2,ErrorMessage = "Длина ключа не менне 2-х символов")]
        public string Key { get; set; }
    }
}
