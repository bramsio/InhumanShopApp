using InhumanShopApp.Data;
using InhumanShopApp.Infrastructure.Data.Models;
using InhumanShopApp.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
namespace InhumanShopApp.Controllers
{
    public class UserProductController : Controller
    {
        //Operations for users
        private readonly ApplicationDbContext context;
        public UserProductController(ApplicationDbContext _context)
        {
            context = _context;
        }

        //All products
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return RedirectToAction("Index", "Product");
        }



        //The details of profuct
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {

            var product = await context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }


            var viewModel = new ProductDetailsViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                Category = product.Category.Name,
                Quantity = 1,
                Count = product.Count,
                Sizes = await GetSizes()
            };

            return View(viewModel);
        }


        [HttpGet]
        public async Task<IActionResult> FilterCategory(int? categoryId)
        {
            var productsQuery = context.Products
            .Include(p => p.Category) 
            .AsQueryable();

            if (categoryId.HasValue)
            {
                productsQuery = productsQuery.Where(p => p.CategoryId == categoryId.Value);
            }

            var products = await productsQuery
            .Select(p => new ProductInfoViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Category = p.Category.Name,
                Description = p.Description,
                ImageUrl = p.ImageUrl
            })
            .ToListAsync();


            return View("~/Views/Product/Index.cshtml", products);
        }



        private async Task<IEnumerable<SizeViewModel>> GetSizes()
        {
            return await context.Sizes
                .AsNoTracking()
                .Select(c => new SizeViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }
    }
}
