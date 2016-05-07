using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooshak26.Models.ViewModels
{
    public class LinksViewModel
    {
        [Display(Name = "Usernames")]
        public SelectList userNames { get; set; }

        [Display(Name = "Courses")]
        public SelectList titles { get; set; }
    }
}