using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.VeterinarianConstants;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class Veterinarian
    {
        [Key]
        [Comment("Veterinarian identifier")]
        public int Id { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [MaxLength(veterinarianFirsNameMaxLnegth)]
        [Comment("Veterinarian first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [MaxLength(veterinarianLastNameMaxLength)]
        [Comment("Veterinarian last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [MaxLength(veterinarianSpecializationMaxLength)]
        [Comment("Veterinarian specialization")]
        public string Specialization { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [Phone(ErrorMessage = invalidPhoneMessage)]
        [Comment("Veterinarian phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [EmailAddress(ErrorMessage = invalidEmailMessage)]
        [Comment("Veterinarian email adress")]
        public string EmailAdress { get; set; }

        [Required(ErrorMessage = requireFieldMessage)]
        [MaxLength(veterinarianDescriptionMaxLength)]
        [Comment("Veterinarian profile description")]
        public string ProfileDescription { get; set; }


        public ICollection<Chat> Chats { get; set; } = new List<Chat>();
    }
}
