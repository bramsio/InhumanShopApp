using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Data.SeedData
{
    public class VeterinarianSeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            var vets = new[]
            {
                new Veterinarian
                {
                    Id = "a1b2c3d4-1234-5678-9876-abcdefabcdef",
                    Name = "Dr. Sarah Johnson",
                    Email = "sarah@zooshop.com",
                    NormalizedEmail = "SARAH@ZOOSHOP.COM",
                    Specialization = "Small Animals",
                    YearsOfExperience = 8,
                    TelNumber = "+359888123456",
                    UserName = "sarah@zooshop.com",
                    NormalizedUserName = "SARAH@ZOOSHOP.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(
                        new User { UserName = "sarah@zooshop.com" },
                        "Vet123!")
                },
                new Veterinarian
                {
                    Id = "a1b2c3d4-2345-6789-9876-abcdefabcdef",
                    Name = "Dr. Michael Brown",
                    Email = "michael@zooshop.com",
                    NormalizedEmail = "MICHAEL@ZOOSHOP.COM",
                    Specialization = "Exotic Animals",
                    YearsOfExperience = 12,
                    TelNumber = "+359888654321",
                    UserName = "michael@zooshop.com",
                    NormalizedUserName = "MICHAEL@ZOOSHOP.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(
                        new User { UserName = "michael@zooshop.com" },
                        "Vet456!")
                },
                new Veterinarian
                {
                    Id = "a1b2c3d4-3456-7890-9876-abcdefabcdef",
                    Name = "Dr. Emma Davis",
                    Email = "emma@zooshop.com",
                    NormalizedEmail = "EMMA@ZOOSHOP.COM",
                    Specialization = "Large Animals",
                    YearsOfExperience = 10,
                    TelNumber = "+359888987654",
                    UserName = "emma@zooshop.com",
                    NormalizedUserName = "EMMA@ZOOSHOP.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(
                        new User { UserName = "emma@zooshop.com" },
                        "Vet789!")
                },
                new Veterinarian
                {
                    Id = "a1b2c3d4-4567-8901-9876-abcdefabcdef",
                    Name = "Dr. John Smith",
                    Email = "john@zooshop.com",
                    NormalizedEmail = "JOHN@ZOOSHOP.COM",
                    Specialization = "Birds",
                    YearsOfExperience = 6,
                    TelNumber = "+359888456789",
                    UserName = "john@zooshop.com",
                    NormalizedUserName = "JOHN@ZOOSHOP.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(
                        new User { UserName = "john@zooshop.com" },
                        "Vet321!")
                },
                new Veterinarian
                {
                    Id = "a1b2c3d4-5678-9012-9876-abcdefabcdef",
                    Name = "Dr. Olivia Wilson",
                    Email = "olivia@zooshop.com",
                    NormalizedEmail = "OLIVIA@ZOOSHOP.COM",
                    Specialization = "Reptiles",
                    YearsOfExperience = 7,
                    TelNumber = "+359888123789",
                    UserName = "olivia@zooshop.com",
                    NormalizedUserName = "OLIVIA@ZOOSHOP.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(
                        new User { UserName = "olivia@zooshop.com" },
                        "Vet654!")
                },
                new Veterinarian
                {
                    Id = "a1b2c3d4-6789-0123-9876-abcdefabcdef",
                    Name = "Dr. William Garcia",
                    Email = "william@zooshop.com",
                    NormalizedEmail = "WILLIAM@ZOOSHOP.COM",
                    Specialization = "Fish",
                    YearsOfExperience = 5,
                    TelNumber = "+359888654987",
                    UserName = "william@zooshop.com",
                    NormalizedUserName = "WILLIAM@ZOOSHOP.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(
                        new User { UserName = "william@zooshop.com" },
                        "Vet987!")
                },
                new Veterinarian
                {
                    Id = "a1b2c3d4-7890-1234-9876-abcdefabcdef",
                    Name = "Dr. Sophia Martinez",
                    Email = "sophia@zooshop.com",
                    NormalizedEmail = "SOPHIA@ZOOSHOP.COM",
                    Specialization = "Wildlife",
                    YearsOfExperience = 15,
                    TelNumber = "+359888987123",
                    UserName = "sophia@zooshop.com",
                    NormalizedUserName = "SOPHIA@ZOOSHOP.COM",
                    PasswordHash = new PasswordHasher<User>().HashPassword(
                        new User { UserName = "sophia@zooshop.com" },
                        "Vet1234!")
                }
            };

            builder.Entity<Veterinarian>().HasData(vets);

            var roles = new[]
            {
                new IdentityUserRole<string> { UserId = "a1b2c3d4-1234-5678-9876-abcdefabcdef", RoleId = "2" }, // Vet
                new IdentityUserRole<string> { UserId = "a1b2c3d4-2345-6789-9876-abcdefabcdef", RoleId = "2" }, // Vet
                new IdentityUserRole<string> { UserId = "a1b2c3d4-3456-7890-9876-abcdefabcdef", RoleId = "2" }, // Vet
                new IdentityUserRole<string> { UserId = "a1b2c3d4-4567-8901-9876-abcdefabcdef", RoleId = "2" }, // Vet
                new IdentityUserRole<string> { UserId = "a1b2c3d4-5678-9012-9876-abcdefabcdef", RoleId = "2" }, // Vet
                new IdentityUserRole<string> { UserId = "a1b2c3d4-6789-0123-9876-abcdefabcdef", RoleId = "2" }, // Vet
                new IdentityUserRole<string> { UserId = "a1b2c3d4-7890-1234-9876-abcdefabcdef", RoleId = "2" }  // Vet
            };

            builder.Entity<IdentityUserRole<string>>().HasData(roles);
        }
    }
}
