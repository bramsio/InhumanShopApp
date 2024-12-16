using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.ProductConstants;

namespace InhumanShopApp.Models.Product
{
    public class ProductFormViewModel
    {
        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(productNameMaxLength,
            MinimumLength = productNameMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        [Comment("Product name")]
        public string Name { get; set; } = string.Empty;


        [Required(ErrorMessage = requireFieldMessage)]
        
        [Comment("Product count")]
        [Range(1, int.MaxValue, ErrorMessage = productCountErrorMessage)]
        public int Count { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [Comment("Producr price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [Range(0.01, double.MaxValue, ErrorMessage = productPriceErrorMessage)]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(productDescriptionMaxLength,
            MinimumLength = productDescriptionMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        [Comment("Product description")]
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
    }
}
