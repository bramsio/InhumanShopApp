using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.UserConstants;

namespace InhumanShopApp.Models.Account
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = requireFieldMessage)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(passwordMaxLength, MinimumLength = passwordMinLength, ErrorMessage = stringLengthErrorMessage)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = requireFieldMessage)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = notMatchingPasswordsErrorMessage)]
        public string ConfirmNewPassword { get; set; } = string.Empty;
    }
}
