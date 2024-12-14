using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static InhumanShopApp.Infrastructure.Constants.ProductConstants;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class Product
    {
        [Key]
        [Comment("Product Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(productNameMaxLength)]
        [Comment("Product Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Product count")]
        public int Count { get; set; }

        [Required]
        [Comment("Product Price")]
        public decimal Price { get; set; }


        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey("CategoryId")]
        [Comment("Product Category")]
        public Category Category { get; set; } = null!;

        [Required]
        [MaxLength(productDescriptionMaxLength)]
        [Comment("Product description")]
        public string Description { get; set; } = string.Empty;

        [Comment("Product image url")]
        public string? ImageUrl { get; set; } 
    }
}
