using InhumanShopApp.Data;
using InhumanShopApp.Infrastructure.Data.Models;
using InhumanShopApp.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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


        //Add product to cart
        //get -> за избиране на брой и размер 

        //[Required(ErrorMessage = requireFieldMessage)]
        //[Comment("Product Size")]
        //public string Size { get; set; } = null!;


        //[HttpPost]
        //public async Task<IActionResult> AddToCart(int id)
        //{
        //    var product = context.Products.Find(id);
        //    if (product == null)
        //    {
        //        return NotFound(); 
        //    }

        //    var cart = HttpContext.Session.GetObjectFromJson<List<OrderItem>>("Cart") ?? new List<OrderItem>();

        //    var cartItem = cart.FirstOrDefault(i => i.ProductId == id);
        //    if (cartItem == null)
        //    {
        //        cart.Add(new OrderItem
        //        {
        //            ProductId = product.Id,
        //            Price = product.Price,
        //            Quantity = 1
        //        });
        //    }
        //    else
        //    {
        //        cartItem.Quantity += quantity;
        //    }

        //    HttpContext.Session.SetObjectAsJson("Cart", cart);
        //    TempData["Message"] = $"{product.Name} has been added to your cart.";

        //    return RedirectToAction("Index");
        //}




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
                Quantity = product.Quantity,
                Count = product.Count,
                SizeId = 1
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
    }
}
