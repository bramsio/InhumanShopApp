using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Data.SeedData
{
    public class RoleSeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "User", NormalizedName = "USER" },
                new IdentityRole { Id = "2", Name = "Veterinarian", NormalizedName = "VETERINARIAN" },
                new IdentityRole { Id = "3", Name = "Administrator", NormalizedName = "ADMINISTRATOR" }
            );
        }
    }
}
