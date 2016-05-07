using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak26.Models.Entities
{
    public class Link
    {
        public int id { get; set; }
        public int userID { get; set; }
        public int courseID { get; set; }
        public string role { get; set; }
    }
}