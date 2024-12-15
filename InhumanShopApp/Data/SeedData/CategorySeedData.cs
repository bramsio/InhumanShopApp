using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Data.SeedData
{
    public class CategorySeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Clothes" },
                new Category { Id = 2, Name = "Toys" },
                new Category { Id = 3, Name = "Medications" },
                new Category { Id = 4, Name = "Accessories" },
                new Category { Id = 5, Name = "Food" }
            );
        }
    }
}
