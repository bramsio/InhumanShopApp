using InhumanShopApp.Data;
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

        //[HttpPost]
        //public async Task<IActionResult> AddToCart(int id)
        //{
        //    string userId = GetUserId();

        //    if (userId == null)
        //    {
        //        return Unauthorized();
        //    }

        //    var favorite = new UserDestination
        //    {
        //        UserId = userId,
        //        DestinationId = id
        //    };

        //    context.UserDestinations.Add(favorite);
        //    await context.SaveChangesAsync();


        //    string redirectUrl = Url.Action("Index", "Destination");

        //    var currentUrl = Request.Headers["Referer"].ToString();
        //    if (!string.IsNullOrEmpty(currentUrl) && currentUrl.Contains("Destination/Details"))
        //    {
        //        redirectUrl = Url.Action("Details", "Destination", new { id });
        //    }

        //    return Redirect(redirectUrl);
        //}




        ////The details of profuct
        //[HttpGet]
        //public async Task<IActionResult> Details(int id)
        //{
        //    var product = await context.Products
        //        .Include(p => p.Category)
        //        .FirstOrDefaultAsync(p => p.Id == id);

        //    if (product == null)
        //    {
        //        return NotFound();
        //    }


        //    var viewModel = new ProductDetailsViewModel
        //    {
        //        Id = product.Id,
        //        Name = product.Name,
        //        Description = product.Description,
        //        ImageUrl = product.ImageUrl,
        //        Terrain = product.Terrain.Name,
        //        PublishedOn = product.PublishedOn,
        //        Publisher = product.Publisher.UserName,
        //    };

        //    return View(viewModel);
        //}
    }
}
