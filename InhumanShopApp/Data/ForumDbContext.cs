using InhumanShopApp.Infrastructure.Data.Configuration;
using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Data
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext(DbContextOptions<ForumDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration());
        }
        public DbSet<Product> Products { get; set; }
    }
}
