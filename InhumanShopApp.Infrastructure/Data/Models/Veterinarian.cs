using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static InhumanShopApp.Infrastructure.Constants.ErrorMessages;
using static InhumanShopApp.Infrastructure.Constants.VeterinarianConstants;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class Veterinarian : User
    {
        [Required]
        [MaxLength(veterinarianSpecializationMaxLength)]
        public string Specialization { get; set; } = string.Empty;

        [Required]
        public int YearsOfExperience { get; set; }

        [Required]
        [Phone(ErrorMessage = invalidPhoneMessage)]
        public string TelNumber { get; set; } = string.Empty;
    }
}
