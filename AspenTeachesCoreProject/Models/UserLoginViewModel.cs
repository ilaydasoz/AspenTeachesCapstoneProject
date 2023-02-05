using System;
using System.ComponentModel.DataAnnotations;

namespace AspenTeachesCoreProject.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please enter your username!")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter your password!")]
        public string Password { get; set; }
    }
}
