using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Estimator.Data;
using Estimator.Models.ViewModels;
using Estimator.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;


namespace Estimator
{
    public class LoginModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;

        public LoginModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LoginView Login { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id,string? action)
        {
          
            if(!String.IsNullOrEmpty(action))
            {
                if (action == "logout")
                {
                    return await Logout();
                }
            }
            string path = Request.Path;
            Login  = new LoginView();

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            User user = await _context.User.FirstOrDefaultAsync(u => u.Email == Login.Email && u.Password == Login.Password);
            if (user != null)
            {
                await Authenticate(user); // аутентификация
              //  HttpContext.Request.
                return RedirectToPage("./index");
            }
            
            ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            return Page();
        }
          
        
        private async Task Authenticate(User user)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email ),
                new Claim(ClaimsIdentity.DefaultRoleClaimType , user.Role.ToString ()),
                new Claim("identity",user.Id.ToString())
               
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id), new AuthenticationProperties
            {
                IsPersistent= true,
                ExpiresUtc = DateTime.UtcNow.AddMinutes(1440)
            });
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
