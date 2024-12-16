using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.SizeConstants;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;

namespace InhumanShopApp.Models.Product
{
    public class SizeViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(sizeNameMaxLength,
            MinimumLength = sizeNameMinLength,
            ErrorMessage = stringLengthErrorMessage)]
        [Comment("Size Name")]
        public string Name { get; set; } = string.Empty;
    }
}
