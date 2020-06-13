using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Estimator.Data;
using Estimator.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace Estimator.Pages.Users
{
    [Authorize(Roles = "Administrator")]
    public class EditModel : Estimator.Pages.BaseEstimatorPage
    {


        public EditModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration) : base(context, appEnvironment, configuration)
        {

        }
        [BindProperty]
        public Estimator.Models.ViewModels.NewUserView  UserView { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, string? name)
        {
            User user; 
            if (id == null)
            {
                if (name == null)
                {
                    user = new User();
                }
                else
                {
                    user = await _context.User.FirstOrDefaultAsync(m => m.Email == name);
                }
            }
            else
            {
                user = await _context.User.FirstOrDefaultAsync(m => m.Id == id);
            }
            UserView = new Estimator.Models.ViewModels.NewUserView
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
                Family = user.Family,
                Password = user.Password,
                ConfirmPassword = user.Password,
                Role = user.Role
            };
          
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
            User user = UserView;

            if (UserView.Id < 1)
            {
                _context.User.Add(user);
            }
            else
            {
                _context.Attach(user).State = EntityState.Modified;
            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(user.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
