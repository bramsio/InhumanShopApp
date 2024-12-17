using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Data.SeedData
{
    public class StatusSeedData
    {
        // Статус на поръчката (напр. "Pending", "Completed", "Cancelled")
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "Active" },
                new Status { Id = 2, Name = "Completed" },
                new Status { Id = 3, Name = "Cancelled" }
            );
        }
    }
}
