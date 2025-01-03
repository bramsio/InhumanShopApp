﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class OrderItem
    {
        [Key]
        [Comment("Order item identifier")]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; } = null!;

        [Required]
        public int SizeId { get; set; }
        [Required]
        [Comment("Product size")]
        public Size Size { get; set; } = null!;

        [Required]
        [Comment("Product quanity")]
        public int Quantity { get; set; } = 1;

        [Required(ErrorMessage = requireFieldMessage)]
        public decimal Price { get; set; }
    }
}