using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.UserConstants;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = requireFieldMessage)]
        [MaxLength(userNameMaxLength)]
        public string Name { get; set; }
        public ICollection<Chat> Chats { get; set; } = new List<Chat>();
    }
}
