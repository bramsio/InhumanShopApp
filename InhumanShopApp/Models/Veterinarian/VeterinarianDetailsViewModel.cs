using System.ComponentModel.DataAnnotations;

namespace InhumanShopApp.Models.Veterinarian
{
    public class VeterinarianDetailsViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Specialization")]
        public string Specialization { get; set; }

        [Display(Name = "Years of Experience")]
        public int YearsOfExperience { get; set; }

        [Display(Name = "Phone Number")]
        public string TelNumber { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}
