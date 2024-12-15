using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Data.SeedData
{
    public class AdminSeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            var adminUserId = "7699db7d-964f-4782-8209-d76562e0fece";

            builder.Entity<User>().HasData(
                new User
                {
                    Id = adminUserId,
                    Name = "Belgin",
                    UserName = "admin@zooshop.com",
                    NormalizedUserName = "ADMIN@ZOOSHOP.COM",
                    Email = "admin@zooshop.com",
                    NormalizedEmail = "ADMIN@ZOOSHOP.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<User>().HashPassword(
                        new User { UserName = "admin@zooshop.com" },
                        "Admin123!")
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = adminUserId,
                    RoleId = "3" // Administrator
                }
            );
        }
    }
}
