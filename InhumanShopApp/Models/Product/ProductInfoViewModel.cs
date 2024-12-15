using Humanizer;
using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.ProductConstants;
namespace InhumanShopApp.Models.Product
{
    public class ProductInfoViewModel
    {
        [Key]
        [Comment("Product Identifier")]
        public int Id { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(productNameMaxLength,
            MinimumLength = productNameMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        [Comment("Product Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = requireFieldMessage)]
        [Comment("Product count")]
        public int Count { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [Comment("Product Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [Comment("Product Category")]
        public string Category { get; set; } = null!;

        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(productDescriptionMaxLength,
            MinimumLength = productDescriptionMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        [Comment("Product description")]
        public string Description { get; set; } = string.Empty;

        [Comment("Product image url")]
        public string? ImageUrl { get; set; } 
    }
}
