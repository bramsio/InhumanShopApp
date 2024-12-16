using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InhumanShopApp.Data.Configuration
{
    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder
           .HasOne(c => c.User)
           .WithMany(u => u.Chats)
           .HasForeignKey(c => c.UserId)
           .OnDelete(DeleteBehavior.Restrict);


            // Добавяне на условия за IsFromUser
            builder
            .Property(c => c.IsFromUser)
            .HasConversion<int?>()
            .HasConversion(
               v => v.HasValue ? 1 : 0,
                v => v == 1
            )
            .HasDefaultValue(null);
        }

    
    }
}
