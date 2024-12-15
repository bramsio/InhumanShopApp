using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InhumanShopApp.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .Property(o => o.TotalPrice)
                .HasColumnType("decimal(18,2)");
        }
    }
}
