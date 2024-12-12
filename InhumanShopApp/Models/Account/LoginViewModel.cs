using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.UserConstants;

namespace InhumanShopApp.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = requireFieldMessage)]
        [EmailAddress(ErrorMessage = invalidEmailMessage)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = requireFieldMessage)]
        [DataType(DataType.Password)]
        [StringLength(passwordMaxLength,
            MinimumLength = passwordMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        public string Password { get; set; } = string.Empty;

    }
}
