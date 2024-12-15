using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InhumanShopApp.Data.Configuration
{
    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            // Връзка между User и Chat
            builder
                .HasOne(c => c.User)
                .WithMany(u => u.Chats)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Връзка между Veterinarian и Chat
            builder
                .HasOne(c => c.Veterinarian)
                .WithMany(v => v.Chats)
                .HasForeignKey(c => c.VeterinarianId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
