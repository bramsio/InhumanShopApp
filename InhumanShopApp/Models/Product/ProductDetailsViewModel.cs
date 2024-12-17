using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.ProductConstants;
using static InhumanShopApp.Infrastructure.Constants.CategoryConstants;

namespace InhumanShopApp.Models.Product
{
    public class ProductDetailsViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(productNameMaxLength,
            MinimumLength = productNameMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        [Comment("Product name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = requireFieldMessage)]
        [Comment("Producr price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(productDescriptionMaxLength,
            MinimumLength = productDescriptionMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        [Comment("Product description")]
        public string Description { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }

        [Required]
        [StringLength(categoryNameMaxLength,
            MinimumLength = categoryNameMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        public string Category { get; set; } = string.Empty;


        [Required(ErrorMessage = requireFieldMessage)]
        public int SizeId { get; set; }

        public int Quantity { get; set; } = 1; // Количество, по подразбиране е 1

        public int? Count { get; set; } // Брой налични продукти, вижда се само от администратори

        public IEnumerable<SizeViewModel> Sizes { get; set; } = new List<SizeViewModel>();
    }
}
