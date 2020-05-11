using Estimator.Models;
using Estimator.Models.ViewModels;
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

    }
}
