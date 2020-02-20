using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator.Models.ViewModels
{
    public class RequestOperationGroupView
    {
            public int OperationID { get; set; }

            public string Name {get;set;}

	      public bool IsExecute{get;set;}
          public int ExecuteCount{get;set;}

         public int Order { get; set; }

    }
}
