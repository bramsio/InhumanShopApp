using System.ComponentModel.DataAnnotations;

namespace InhumanShopApp.Models.Product
{
    public class ProductEditViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public int Count { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
    }
}
