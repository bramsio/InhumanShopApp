using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.CategoryConstants;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Models.Product
{
    public class CategoryViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(categoryNameMaxLength,
            MinimumLength = categoryNameMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        [Comment("Category Name")]
        public string Name { get; set; } = string.Empty;
    }
}
