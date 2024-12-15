using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InhumanShopApp.Models.Product
{
    public class ProductDeleteViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}

