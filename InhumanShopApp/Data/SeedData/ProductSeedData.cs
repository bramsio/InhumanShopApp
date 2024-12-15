using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Data.SeedData
{
    public class ProductSeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                // Toys
                new Product
                {
                    Id = 1,
                    Name = "Chew Toy",
                    Count = 5,
                    Price = 23.43M,
                    CategoryId = 2, // Toys
                    Description = "Durable chew toy for dogs.",
                    ImageUrl = "/images/chew_toy.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Cat Ball",
                    Count = 5,
                    Price = 15.99M,
                    CategoryId = 2, // Toys
                    Description = "Colorful ball with bell for cats.",
                    ImageUrl = "/images/cat_ball.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Bird Swing",
                    Count = 5,
                    Price = 12.49M,
                    CategoryId = 2, // Toys
                    Description = "Swing toy for small birds.",
                    ImageUrl = "/images/bird_swing.jpg"
                },
                // Clothes
                new Product
                {
                    Id = 4,
                    Name = "Dog Sweater",
                    Count = 5,
                    Price = 27.99M,
                    CategoryId = 1, // Clothes
                    Description = "Warm sweater for small dogs.",
                    ImageUrl = "/images/dog_sweater.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Raincoat for Dogs",
                    Count = 5,
                    Price = 34.50M,
                    CategoryId = 1, // Clothes
                    Description = "Waterproof raincoat for pets.",
                    ImageUrl = "/images/dog_raincoat.jpg"
                },
                // Medicines
                new Product
                {
                    Id = 6,
                    Name = "Flea Treatment",
                    Count = 5,
                    Price = 45.99M,
                    CategoryId = 3, // Medicines
                    Description = "Effective flea treatment for pets.",
                    ImageUrl = "/images/flea_treatment.jpg"
                },
                new Product
                {
                    Id = 7,
                    Name = "Deworming Tablets",
                    Count = 5,
                    Price = 28.75M,
                    CategoryId = 3, // Medicines
                    Description = "Tablets for deworming cats and dogs.",
                    ImageUrl = "/images/deworming_tablets.jpg"
                }
            );
        }
    }
}
