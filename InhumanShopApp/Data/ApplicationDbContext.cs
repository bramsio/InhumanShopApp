using InhumanShopApp.Data.Configuration;
using InhumanShopApp.Data.SeedData;
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

            builder.Entity<User>()
                .HasDiscriminator<string>("UserType")
                .HasValue<User>("User")
                .HasValue<Veterinarian>("Veterinarian");


            // Зареждане на конфигурациите
            builder.ApplyConfiguration(new ChatConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new OrderItemConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            //builder.ApplyConfiguration(new VeterinarianConfiguration());


            // Зареждане на Seed данни
            RoleSeedData.Seed(builder);
            AdminSeedData.Seed(builder);
            CategorySeedData.Seed(builder);
            ProductSeedData.Seed(builder);
            SizeSeedData.Seed(builder);
            VeterinarianSeedData.Seed(builder);
            StatusSeedData.Seed(builder);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}

