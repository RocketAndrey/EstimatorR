using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Estimator.Data;
using Estimator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Estimator.Migrations;

namespace Estimator.Pages.ElementKey
{
    [Authorize(Roles = "Administrator")]
    public class CreateModel : Estimator.Pages.BaseEstimatorPage 
    {
       
     
        public CreateModel(Estimator.Data.EstimatorContext context, IWebHostEnvironment appEnvironment, IConfiguration configuration):base( context,  appEnvironment, configuration)
        { 
        }

        public IActionResult OnGet(int? typeID, int? keyID)
        {

            if (typeID == null)
            {
                return NotFound();
            }
            if ((keyID ?? 0) == 0)
            {
                ElementKey = new Models.ElementKey
                {
                    ElementTypeID = typeID ?? 0,
                    ElementType = _context.ElementTypes
                    .Include(e=>e.Program)
                    .FirstOrDefault(e => e.ElementTypeID == typeID)
                };
                
            }
            else
            {

                ElementKey =  _context.ElementKey
                    .Include(e => e.ElementType)
                        .ThenInclude(e=>e.Program)
                    .FirstOrDefault(m => m.ElementKeyID == keyID);
            }
            if (ElementKey.ElementType==null)
            {
                return NotFound();
            }

            return Page();
        }

        [BindProperty]
        public Estimator.Models.ElementKey ElementKey { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ;
            ElementType elementType = _context.ElementTypes
                .Include (e=>e.Keys)
                .AsNoTracking()
                .FirstOrDefault(e => e.ElementTypeID == ElementKey.ElementTypeID);
            

            if (elementType != null) 
            {
                //проверка ключа на существование
                Estimator.Models.ElementKey  keyExists = elementType.Keys
                   .FirstOrDefault(c => PrepareStr(c.Key) == PrepareStr(ElementKey.Key));
                if (keyExists!=null)
                {
                    if (keyExists.ElementKeyID != ElementKey.ElementKeyID)
                    {
                        ModelState.AddModelError("", "Ключ уже существует для данного типа элемента");
                        ElementKey.ElementType = elementType;
                        return Page();
                    }
                }
                keyExists = null;
            }
           
            if (ElementKey.ElementKeyID > 0)
            {
                // ключ существует
                _context.Attach(ElementKey).State = EntityState.Modified;
            }
            else
            {
                // новый ключ
                _context.ElementKey.Add(ElementKey);
            }
            await _context.SaveChangesAsync();
            ElementKey.ElementType = elementType;

            return RedirectToPage("./Index", new {id= elementType.ElementTypeID });
        }
    }
}
