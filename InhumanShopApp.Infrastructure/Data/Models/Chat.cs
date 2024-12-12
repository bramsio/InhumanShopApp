using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static InhumanShopApp.Infrastructure.Constants.ChatConstants;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class Chat
    {
        [Key]
        [Comment("Chat Identifier")]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey("UserId")]

        public User User { get; set; } = null!;

        [Required]
        public int VeterinarianId { get; set; }

        [ForeignKey("VeterinarianId")]
        public Veterinarian Veterinarian { get; set; } = null!;

        [Required(ErrorMessage = requireFieldMessage)]
        [StringLength(messageContentMaxLenght)]
        public string MessageContent { get; set; } 

        [Required]
        [Comment("The time the message was sent")]
        public DateTime SentAt { get; set; } 

        [Required]
        [Comment("What role is the sender of the message from - User or Veterinarian")]
        public bool IsFromUser { get; set; } 
    }
}
