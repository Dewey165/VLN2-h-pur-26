using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak26.Models.Entities
{
    public class User
    {
        public int id { get; set; }
        public string userName { get; set; }
        public int kennitala { get; set; }
        public string email { get; set; }
        public int role { get; set; }

    }
}