using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mooshak26.Models.ViewModels
{
    public class StudentMainViewModel
    {
        public string title { get; set; }
        public int userID { get; set; }
        public int courseID {get; set;}
        public int assignmentID { get; set; }
        public List<AssignmentViewModel> Assignments { get; set; }


    }
}