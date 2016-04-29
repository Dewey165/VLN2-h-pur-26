using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak26.Models.ViewModels
{
    public class AssignmentViewModel
    {
        public string title { get; set; }
        
        public List<AssignmentViewModel> Milestones { get; set; }

    }
}