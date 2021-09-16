using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCCaptcha.Models
{
    public class RegisterationModel
    {   [Display(Name ="UserName")]
        public string Username { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}