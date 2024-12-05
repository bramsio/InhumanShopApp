using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.ValidationConstants;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = requireEmailMessage)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = requirePasswordMessage)]
        [StringLength(passwordMaxLength, MinimumLength = passwordMinLength, ErrorMessage = passwordLengthErrorMessage)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = requireConfirmPasswordMessage)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = notMatchingPasswordsErrorMessage)]
        public string ConfirmNewPassword { get; set; }
    }
}
