using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    public enum Role {User,Administrator}
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Логин:")]
        [Required(ErrorMessage = "Не указан Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Не указан пароль")]
        [MaxLength(50)]
        [MinLength(6, ErrorMessage = "Минимальная длина пароля- 6 символов")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(50)]
        [MaxLength(50)]
        [MinLength(3, ErrorMessage = "Минимальная длина фамилии- 3 символа")]
        [Display(Name = "Имя:")]
        [Required(ErrorMessage = "Имя не указано")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана фамилия")]
        [StringLength(50)]
        [MaxLength(50)]
        [MinLength(3, ErrorMessage="Минимальная длина фамилии- 3 символа")]
        [Display(Name = "Фамилия:")]
        public string Family { get;  set; }

        [Display(Name = "Роль:")]
        public Role  Role { get; set; }

        public string Monogrammed
        {
            get
            {
                return Name.Trim().Substring(1, 1).ToUpper() + Family.Trim().Substring(1, 1).ToUpper();
            }
        }


    }
}
