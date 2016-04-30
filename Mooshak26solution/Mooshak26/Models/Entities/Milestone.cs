using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak26.Models.Entities
{
    /// <summary>
    /// Each assignments will have one or more milestones to represents each part of the assigment to hand in.
    /// For example, one milestone can be "Part 1" of the assignment and another milestone can be "Part 2".
    /// </summary>
    public class Milestone
    {
        /// <summary>
        /// ID represents this specific Milestone and is unique in the DB.
        /// AssignmentID represents what Assignment this milestone is part of.
        /// Title is the title of this milestone.
        /// description does not need to explain..
        /// grade is what precentage this milestone is to the whole assignment.
        /// </summary>
        public int milestoneID { get; set; }
        public int assignmentID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int grade { get; set; }
    }
}