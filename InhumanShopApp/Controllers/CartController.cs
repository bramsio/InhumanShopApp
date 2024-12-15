using Microsoft.AspNetCore.Mvc;

namespace InhumanShopApp.Controllers
{
    public class CartController : Controller
    {
        //cart and CRUD operations for products in cart 
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //public async Task<IActionResult> Cart()
        //{
        //    string userId = GetUserId();
        //    var favoriteDestinations = await context.Destinations
        //    .Where(d => d.UsersDestinations.Any(ud => ud.UserId == userId))
        //    .Select(d => new DestinationInfoViewModel
        //    (
        //        d.Id,
        //        d.Name,
        //        d.ImageUrl,
        //        d.Terrain.Name,
        //        d.UsersDestinations.Count(),
        //        d.PublisherId == userId,
        //        true
        //    ))
        //    .ToListAsync();

        //    return View(favoriteDestinations);
        //}

        //[HttpPost]
        //public async Task<IActionResult> RemoveFromCart(int id)
        //{
        //    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        //    var favorite = await context.UserDestinations
        //        .FirstOrDefaultAsync(ud => ud.UserId == userId && ud.DestinationId == id);

        //    if (favorite == null)
        //    {
        //        return NotFound();
        //    }

        //    context.UserDestinations.Remove(favorite);
        //    await context.SaveChangesAsync();


        //    return RedirectToAction("Favorites", "Destination");
        //}
    }
}
