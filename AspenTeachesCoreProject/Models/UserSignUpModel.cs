using System;
using System.ComponentModel.DataAnnotations;

namespace AspenTeachesCoreProject.Models
{
    public class UserSignUpModel
    {
        [Required(ErrorMessage = "Please enter your username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your surname.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter your e-mail.")]
        [EmailAddress(ErrorMessage ="Please enter a valid e-mail address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        public string ConfirmPassword { get; set; }
    }
}
