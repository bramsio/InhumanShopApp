using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InhumanShopApp.Data.Configuration
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasKey(s => s.Id);


            builder.HasMany(s => s.Products)
                .WithMany(p => p.Sizes)
                .UsingEntity(j => j.ToTable("ProductSizes"));
        }
    }
}
