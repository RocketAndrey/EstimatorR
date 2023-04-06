using Estimator.Models;
using Estimator.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Estimator.Pages.Program
{
    [Authorize(Roles = "Administrator")]
    public class IndexModel : PageModel
    {
        private readonly Estimator.Data.EstimatorContext _context;

        public IndexModel(Estimator.Data.EstimatorContext context)
        {
            _context = context;
        }

        public IList<TestProgram> TestProgram { get; set; }
        public IList<ElementType> ElementTypesSort { get; set; }
        public ProgramIndexData ProgramData { get; set; }
        public int TestProgramID { get; set; }

        public TestProgram SelectedProgram; 
        public int ElementTypeID { get; set; }

        public ElementType SelectedElementType;
        public int ChainItemID { get; set; }

        public async Task OnGetAsync(int? id, int? elementTypeID)
        {
            TestProgram = await _context.TestPrograms.ToListAsync();

            {
                ProgramData = new ProgramIndexData
                {
                    Programs = await _context.TestPrograms
                    .Include(i => i.ElementntTypes)
                        .ThenInclude(i => i.ChainItems)
                            .ThenInclude(i => i.Operation)
                     .Include(i => i.ElementntTypes)
                        .ThenInclude(i => i.ChainItems)
                            .ThenInclude(r => r.TestActions)
                    .AsNoTracking()
                    .OrderBy(i => i.Name)
                    .ToListAsync()
                };

                if (id != null)
                {
                    TestProgramID = id.Value;
                    // Instructor instructor = InstructorData.Instructors
                    SelectedProgram = ProgramData.Programs
                        .Where(i => i.TestProgramID == id.Value).Single();
                    ProgramData.Elements = SelectedProgram.ElementntTypes;
                    ElementTypesSort = SelectedProgram.ElementntTypes.OrderBy(e => e.Order).ToList();


                }
                if (elementTypeID != null)
                {
                    ElementTypeID = elementTypeID.Value;

                     SelectedElementType = ProgramData.Elements
                        .Where(x => x.ElementTypeID == elementTypeID)
                        .Single();
                    ProgramData.ChainItems = SelectedElementType.ChainItems.OrderBy(e => e.Order);
                }

            }
        }
    }
}
