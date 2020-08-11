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
            catch (Exception e)
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
        /// функция удалает из строки все пробелы и переводит в нижний регистр 
        /// </summary>
        /// <param name="value">Исходная строка</param>
        /// <returns></returns>
        protected string PrepareStr(string value)
        {
            // новая строка для записи строки без пробелов
            string newstr = "";
            // цыкл
            for (int i = 0; i < value.Length; i++)
            {
                // если елемент i-ый елемент не пробел - пишем его в новую строку "newstr"
                if (value[i] != ' ')
                {
                    // - пишем его в новую строку "newstr"
                    newstr += value[i];
                }
            }
            return newstr.Trim().ToUpper();
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
    }
}
