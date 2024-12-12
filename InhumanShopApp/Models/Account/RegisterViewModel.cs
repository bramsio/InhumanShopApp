using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.UserConstants;


namespace InhumanShopApp.Models.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(userNameMaxLength,
            MinimumLength = userNameMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;


        [Required(ErrorMessage = requireFieldMessage)]
        [EmailAddress(ErrorMessage = invalidEmailMessage)]
        public string Email { get; set; } = string.Empty;


        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(passwordMaxLength,
            MinimumLength = passwordMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;


        [Required(ErrorMessage = requireFieldMessage)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = notMatchingPasswordsErrorMessage)]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
