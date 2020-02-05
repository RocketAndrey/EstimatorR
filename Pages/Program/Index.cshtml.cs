using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Estimator.Data;
using Estimator.Models;
using Estimator.Models.ViewModels;

namespace Estimator.Pages.Program
{
    public class IndexModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;

        public IndexModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        public IList<TestProgram> TestProgram { get;set; }
        public ProgramIndexData ProgramData { get; set; }
        public int TestProgramID { get; set; }
        public int ElementTypeID { get; set; }
        public int ChainItemID { get; set; }

        public async Task OnGetAsync(int? id, int? elementTypeID)
        {
            TestProgram = await _context.TestPrograms.ToListAsync();

            {
                ProgramData = new  ProgramIndexData();
                ProgramData.Programs = await _context.TestPrograms
                    .Include(i => i.ElementntTypes)
                        .ThenInclude(i=>i.ChainItems)
                            .ThenInclude(i=>i.Operation)
                    .AsNoTracking()
                    .OrderBy(i => i.Name)
                    .ToListAsync();

                if (id != null)
                {
                    TestProgramID = id.Value;
                   // Instructor instructor = InstructorData.Instructors
                    TestProgram program= ProgramData.Programs
                        .Where(i => i.TestProgramID == id.Value).Single();
                    
                    ProgramData.Elements = program.ElementntTypes.OrderBy(e => e.Order);


                }
                if (elementTypeID!=null)
                {
                    ElementTypeID = elementTypeID.Value;
                    var selectedElenentType = ProgramData.Elements
                        .Where(x => x.ElementTypeID == elementTypeID).Single();
                    ProgramData.ChainItems = selectedElenentType.ChainItems;
                }
               
            }
        }
    }
}
