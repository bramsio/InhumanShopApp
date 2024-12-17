using System.ComponentModel.DataAnnotations;

namespace InhumanShopApp.Models.Veterinarian
{
    public class VeterinarianEditViewModel
    {
        public string Id { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Specialization { get; set; } = string.Empty;

        [Required]
        public int YearsOfExperience { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string TelNumber { get; set; } = string.Empty;
    }
}
