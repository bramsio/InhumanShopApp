using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.UserConstants;


namespace InhumanShopApp.Models.Account
{
    public class ProfileViewModel
    {
        [Key]
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(userNameMaxLength,
             MinimumLength = userNameMinLength,
             ErrorMessage = stringLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = requireFieldMessage)]
        [EmailAddress(ErrorMessage = invalidEmailMessage)]
        public string Email { get; set; } = string.Empty;
    }

}
