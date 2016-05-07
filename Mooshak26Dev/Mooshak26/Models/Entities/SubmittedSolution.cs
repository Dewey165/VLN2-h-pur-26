using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak26.Models.Entities
{
    /// <summary>
    /// This contains each submitted answer from each milestone and an overview,
    /// 
    /// </summary>
    
    public class SubmittedSolution
    {
        public int id { get; set; }
        public int courseID { get; set; }
        public int assignmentID { get; set; }
        public int milestoneID { get; set; }
        public int userID { get; set; }
        public string input { get; set; }
        public string output { get; set; }
        public bool correct { get; set; }
        public DateTime timeSubmitted { get; set; }
    }
}