using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Връзка между User и Chat
            builder.Entity<Chat>()
                .HasOne(c => c.User)
                .WithMany(u => u.Chats)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Връзка между Veterinarian и Chat
            builder.Entity<Chat>()
                .HasOne(c => c.Veterinarian)
                .WithMany(v => v.Chats)
                .HasForeignKey(c => c.VeterinarianId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Order>()
                .Property(o => o.TotalPrice)
                .HasColumnType("decimal(18,2)");

            builder.Entity<OrderItem>()
                .Property(oi => oi.Price)
                .HasColumnType("decimal(18,2)");

            builder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");





            // Настройки за Identity ролите
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "User", NormalizedName = "USER" },
                new IdentityRole { Id = "2", Name = "Veterinarian", NormalizedName = "VETERINARIAN" },
                new IdentityRole { Id = "3", Name = "Administrator", NormalizedName = "ADMINISTRATOR" }
            );


            // Създаване на администраторски потребител
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

            // Асоцииране на администратора с ролята "Administrator"
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = adminUserId,
                    RoleId = "3"          //"Administrator"
                }
            );


            //Clothes Toys Medications Accessories Food
            builder.Entity<Category>()
                .HasData(
                    new Category { Id = 1, Name = "Clothes" },
                    new Category { Id = 2, Name = "Toys" },
                    new Category { Id = 3, Name = "Medications" },
                    new Category { Id = 4, Name = "Accessories" },
                    new Category { Id = 5, Name = "Food" }
                );

        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Veterinarian> Veterinarians { get; set; }
    }
}

