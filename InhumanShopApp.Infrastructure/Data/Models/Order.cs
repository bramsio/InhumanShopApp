using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.OrderConstants;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class Order
    {
        [Key]
        [Comment("Order identifier")]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public User User { get; set; } = null!;

        [Required(ErrorMessage = requireFieldMessage)]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [Comment("Total price of order")]
        public decimal TotalPrice { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(statusMaxLength)]
        [Comment("Status of order")]
        public Status Status { get; set; } = null!;

        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}