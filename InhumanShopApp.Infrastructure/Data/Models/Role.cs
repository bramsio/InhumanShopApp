using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.RoleConstants;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class Role
    {
        [Key]
        [Comment("Role identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(roleNameMaxLength)]
        [Comment("Role name")]
        public string Name { get; set; } = string.Empty;

        public IList<User> Users { get; set; } = new List<User>();
    }
}
