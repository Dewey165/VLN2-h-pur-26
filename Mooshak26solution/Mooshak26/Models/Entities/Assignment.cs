using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak26.Models.Entities
{
    /// <summary>
    /// Assignment is a project that Teachers create for students.
    /// Each Assignment has one or more milestones.
    /// </summary>
    public class Assignment
    {
        public int assignmentID { get; set; }
        public int courseID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}