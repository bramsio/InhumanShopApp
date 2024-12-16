using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.StatusConstants;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class Status
    {
        [Key]
        [Comment("Status identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(statusNameMaxLength)]
        public string Name { get; set; } = string.Empty;
        // Статус на поръчката (напр. "Pending", "Completed", "Cancelled")
    }
}