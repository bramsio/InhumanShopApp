using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.SizeConstants;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class Size
    {
        [Key]
        [Comment("Size Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(sizeNameMaxLength)]
        [Comment("Category name")]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
