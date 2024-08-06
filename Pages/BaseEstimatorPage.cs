using Estimator.Models;
using Estimator.Models.ViewModels;
using Estimator.Data; 
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Estimator.Pages
{
    public class BaseEstimatorPage : PageModel
    {
        protected Estimator.Data.EstimatorContext _context;
        protected IWebHostEnvironment _appEnvironment;
        protected IConfiguration _configuration;
        protected Estimator.Data.AsuContext _asuContext;

        public int YearOfNoms { get; set; }
        /// <summary>
        /// использовать базу данных Asu для проерки ЭКБ которые проходили испытания
        /// </summary>
        public bool UseAsu { get; set; }
        public BaseEstimatorPage()
        {
            
        }
        public BaseEstimatorPage(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration)
        {
            _context = context;
            _appEnvironment = appEnvironment;
            _configuration = configuration;

            //получаем год для которого применяем нормативы из конфигурации;
            //получаем год для которого применяем нормативы из конфигурации;
            try
            {
                UseAsu = bool.Parse(_configuration.GetSection("UseAsu")["value"]);
                YearOfNoms = int.Parse(_configuration.GetSection("YearOfNorms")["value"]);


            }
            catch 
            {
                YearOfNoms = 2019;
                UseAsu = false;
            }

        }
        public int UserID
        {
            get
            {
                int userID = 0;

                foreach (var claim in User.Claims)
                {
                    if (claim.Type == "identity")
                    {
                        userID = int.Parse(claim.Value);
                    }
                }
                return userID;
            }
        }

        public string Role
        {
            get
            {

                return User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
        
            }
        }

        public bool isAdministrator
        {
            get
            {
                return (User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value == "Administrator"); 
            }
        }
       
        /// <summary>
        /// Подключение к базе данных ASU  для получения данных о ранее проведенных  испытаниях
        /// </summary>
        protected void SetAsuContext()
        {
            if (UseAsu)
            {
                var optionsBuilder = new DbContextOptionsBuilder<AsuContext>();
                var options = optionsBuilder
                    .UseSqlServer(_configuration.GetConnectionString("AsuContext"))
                    .Options;
                // установка конфигурации подключения к базе данных калькулятора
                _asuContext = new AsuContext(options);
               

            }

        }
      
        /// <summary>
        /// Возвращает ошибки валидации модели на стороне сервера
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        protected string GetModelStateErrors(ModelStateDictionary state)
        {
            string errorMessages = "";
            // проходим по всем элементам в ModelState
            foreach (var item in ModelState)
            {
                // если для определенного элемента имеются ошибки
                if (item.Value.ValidationState == ModelValidationState.Invalid)
                {
                    errorMessages = $"{errorMessages}\nОшибки для свойства {item.Key}:\n";
                    // пробегаемся по всем ошибкам
                    foreach (var error in item.Value.Errors)
                    {
                        errorMessages = $"{errorMessages}{error.ErrorMessage}\n";
                    }
                }
            }
            return errorMessages;
        }
    }
}
