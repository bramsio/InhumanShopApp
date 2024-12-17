using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Data.SeedData
{
    public class ProductSeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Premium Dog Food",
                    Count = 50,
                    Price = 45.99m,
                    SizeId = 3, // M
                    CategoryId = 5, // Food
                    Description = "High-quality dog food for adult dogs.",
                    ImageUrl = "images/Products/Premium_Dog_Food.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Cat Scratching Post",
                    Count = 20,
                    Price = 29.99m,
                    SizeId = 4, // L
                    CategoryId = 2, // Toys
                    Description = "Durable scratching post for cats.",
                    ImageUrl = "images/Products/Cat_Scratching_Post.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Dog Chew Toy",
                    Count = 100,
                    Price = 15.49m,
                    SizeId = 2, // S
                    CategoryId = 2, // Toys
                    Description = "Rubber chew toy to keep your dog entertained.",
                    ImageUrl = "images/Products/Dog_Chew_Toy.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Cat Collar with Bell",
                    Count = 75,
                    Price = 9.99m,
                    SizeId = 2, // S
                    CategoryId = 4, // Accessories
                    Description = "Adjustable cat collar with a small bell.",
                    ImageUrl = "images/Products/Cat_Collar_with_Bell.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Dog And Cat Bed",
                    Count = 30,
                    Price = 59.99m,
                    SizeId = 3, // M
                    CategoryId = 4, // Accessories
                    Description = "Comfortable bed for medium-sized dogs.",
                    ImageUrl = "images/Products/Dog_And_Cat_Bed.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Cat Litter - Odor Control",
                    Count = 40,
                    Price = 19.99m,
                    SizeId = 5, // XL
                    CategoryId = 5, // Food
                    Description = "Cat litter with odor-neutralizing technology.",
                    ImageUrl = "images/Products/Cat_Litter-Odor_Control.jpg"
                },
                new Product
                {
                    Id = 7,
                    Name = "Dog Shampoo - Sensitive Skin",
                    Count = 60,
                    Price = 12.49m,
                    SizeId = 1, // XS
                    CategoryId = 3, // Medications
                    Description = "Gentle shampoo for dogs with sensitive skin.",
                    ImageUrl = "images/Products/Dog_Shampoo-Sensitive_Skin.jpg"
                },
                new Product
                {
                    Id = 8,
                    Name = "Cat Treats - Salmon Flavor",
                    Count = 200,
                    Price = 5.99m,
                    SizeId = 2, // S
                    CategoryId = 5, // Food
                    Description = "Delicious salmon-flavored treats for cats.",
                    ImageUrl = "images/Products/Cat_Treats-Salmon_Flavor.jpg"
                },
                new Product
                {
                    Id = 9,
                    Name = "Dog Harness - Adjustable",
                    Count = 25,
                    Price = 24.99m,
                    SizeId = 3, // M
                    CategoryId = 4, // Accessories
                    Description = "Adjustable harness for comfortable walks.",
                    ImageUrl = "images/Products/Dog_Harness-Adjustable.jpg"
                },
                new Product
                {
                    Id = 10,
                    Name = "Cat Tunnel",
                    Count = 15,
                    Price = 34.99m,
                    SizeId = 4, // L
                    CategoryId = 2, // Toys
                    Description = "Interactive tunnel toy for cats to play and hide.",
                    ImageUrl = "images/Products/Cat_Tunnel.jpg"
                }
            );
        }
    }
}
