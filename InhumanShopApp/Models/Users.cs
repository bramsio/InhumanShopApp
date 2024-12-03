using Microsoft.AspNetCore.Identity;

namespace InhumanShopApp.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
