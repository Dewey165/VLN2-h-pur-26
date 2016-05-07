using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak26.Models.Entities
{
    public class Solution
    {
        public int solutionID { get; set; }
        public int courseID { get; set; }
        public int assignID { get; set; }
        public int milestoneID { get; set; }
        public string input { get; set; }
        public string output { get; set; }
    }
}