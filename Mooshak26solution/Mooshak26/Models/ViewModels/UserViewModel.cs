using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mooshak26.Models.ViewModels
{
    public class UserViewModel
    {
        public class CreateUserViewModel
        {
            [Required]
            [Display(Name = "User Name")]
            public string userName { get; set; }
            
            [Required]
            //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
            [Display(Name = "Kennitala")]
            public int kennitala { get; set; }
/*
            [Required]
            [Display(Name = "Role")]
            public int role { get; set; }
*/    
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

        }
    }
}