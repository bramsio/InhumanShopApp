using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InhumanShopApp.Infrastructure.Constants.PostConstants;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class Product
    {
        [Key]
        [Comment("Product Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Product Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Product count")]
        public int Count { get; set; } = 0;

        [Required]
        [Comment("Product Price")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Product Category")]
        public string Category { get; set; } //Clothes Toys Medications

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Product description")]
        public string  Description { get; set; }

        [Required]
        [Comment("Product image url")]
        public string ImageUrl { get; set; }
    }
}
