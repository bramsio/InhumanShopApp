using System.ComponentModel.DataAnnotations;

namespace InhumanShopApp.Models.Veterinarian
{
    public class VeterinarianViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public string TelNumber { get; set; } = string.Empty;
    }
}
