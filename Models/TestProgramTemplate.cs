using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Models
{
    public class TestProgramTemplate
    {
        public  int TestProgramTemplateID { get; set; }
        public string TemplateName { get; set; }
        public TestProgram Program { get; set; }
        public int  TestProgramID { get; set; }

        public List<TestProgramTemplateItem> TemplateItems { get; set; }

    }
}
