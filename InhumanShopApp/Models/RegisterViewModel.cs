using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InhumanShopApp.Infrastructure.Constants.ValidationConstants;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = requireNameMessage)]
        public string Name { get; set; }

        [Required(ErrorMessage = requireEmailMessage)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = requirePasswordMessage)]
        [StringLength(passwordMaxLength, MinimumLength = passwordMinLength, ErrorMessage = passwordLengthErrorMessage)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = requireConfirmPasswordMessage)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = notMatchingPasswordsErrorMessage)]
        public string ConfirmPassword { get; set; }
    }
}
