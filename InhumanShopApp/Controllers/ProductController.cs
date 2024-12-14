using InhumanShopApp.Data;
using Microsoft.AspNetCore.Mvc;
using InhumanShopApp.Models.Product;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using InhumanShopApp.Infrastructure.Data.Models;
using System.Security.Claims;

namespace InhumanShopApp.Controllers
{
    public class ProductController : Controller
    {
        //CRUD operationd for products [admins]
        private readonly ApplicationDbContext context;
        public ProductController(ApplicationDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            int x = 0;
            int result = 1 / x; // Това ще хвърли грешка Division by Zero
            return View();
            //var products = await context.Products
            //    .Select(p => new ProductInfoViewModel
            //    {
            //        Id = p.Id,
            //        Name = p.Name,
            //        Count = p.Count,
            //        Price = p.Price,
            //        Category = p.Category,
            //        Description = p.Description,
            //        ImageUrl = p.ImageUrl
            //    })
            //    .ToListAsync();

            //return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProductFormViewModel();
            model.Categories = await GetCategories();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = await GetCategories();
                return View(model);
            }
            var entity = new Product()
            {
                Name = model.Name,
                Count = model.Count,
                Price = model.Price,
                CategoryId = model.CategoryId,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
            };

            await context.Products.AddAsync(entity);
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
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
        //public async Task<IActionResult> AddToCart(int id)
        //{
        //    string userId = GetUserId();

        //    if (userId == null)
        //    {
        //        return Unauthorized();
        //    }

        //    var isAlreadyFavorite = await context.UserDestinations
        //        .AnyAsync(ud => ud.UserId == userId && ud.DestinationId == id);


        //    if (isAlreadyFavorite)
        //    {
        //        return BadRequest("This destination is already in your favorites.");
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



        //[HttpGet]
        //public async Task<IActionResult> Details(int id)
        //{
        //    var destination = await context.Destinations
        //        .Include(d => d.Terrain)
        //        .Include(d => d.Publisher)
        //        .FirstOrDefaultAsync(d => d.Id == id);

        //    if (destination == null)
        //    {
        //        return NotFound();
        //    }

        //    var userId = GetUserId();
        //    var isPublisher = destination.PublisherId == userId;
        //    var isFavorite = context.UserDestinations
        //        .Any(ud => ud.UserId == userId && ud.DestinationId == id);

        //    var viewModel = new DestinationDetailsViewModel
        //    {
        //        Id = destination.Id,
        //        Name = destination.Name,
        //        Description = destination.Description,
        //        ImageUrl = destination.ImageUrl,
        //        Terrain = destination.Terrain.Name,
        //        PublishedOn = destination.PublishedOn,
        //        Publisher = destination.Publisher.UserName,
        //        IsPublisher = isPublisher,
        //        IsFavorite = isFavorite
        //    };

        //    return View(viewModel);
        //}



        //[HttpGet]
        //public async Task<IActionResult> Edit(int id)
        //{
        //    string userId = GetUserId();

        //    var d = await context.Destinations
        //        .FindAsync(id);

        //    if (d == null)
        //    {
        //        return BadRequest();
        //    }
        //    if (d.PublisherId != userId)
        //    {
        //        return Unauthorized();
        //    }


        //    var model = new DestinationEditViewModel
        //    {
        //        Id = d.Id,
        //        Name = d.Name,
        //        TerrainId = d.TerrainId,
        //        Description = d.Description,
        //        ImageUrl = d.ImageUrl,
        //        PublisherId = d.PublisherId,
        //        PublishedOn = d.PublishedOn.ToString(DataConstants.DateFormat),
        //    };
        //    model.Terrains = await GetTerrains();

        //    return View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(DestinationEditViewModel model, int id)
        //{
        //    string userId = GetUserId();

        //    var d = await context.Destinations
        //        .FindAsync(id);

        //    if (d == null)
        //    {
        //        return BadRequest();
        //    }
        //    if (d.PublisherId != userId)
        //    {
        //        return Unauthorized();
        //    }


        //    DateTime publishedOn = DateTime.Now;

        //    if (!DateTime.TryParseExact(
        //        model.PublishedOn,
        //        DataConstants.DateFormat,
        //        CultureInfo.InvariantCulture,
        //        DateTimeStyles.None,
        //        out publishedOn))
        //    {
        //        ModelState.AddModelError(nameof(model.PublishedOn), $"Invalid date! Format must be: {DataConstants.DateFormat}");
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        model.Terrains = await GetTerrains();
        //        return View(model);
        //    }

        //    d.Id = model.Id;
        //    d.Name = model.Name;
        //    d.TerrainId = model.TerrainId;
        //    d.Description = model.Description;
        //    d.ImageUrl = model.ImageUrl;
        //    d.PublisherId = model.PublisherId;
        //    d.PublishedOn = publishedOn;

        //    context.Destinations.Update(d);
        //    await context.SaveChangesAsync();

        //    return RedirectToAction("Details", new { id = d.Id });
        //}

        //[HttpGet]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var destination = await context.Destinations
        //    .FirstOrDefaultAsync(d => d.Id == id && d.PublisherId == GetUserId() && !d.IsDeleted);

        //    if (destination == null)
        //    {
        //        return NotFound();
        //    }

        //    var viewModel = new DestinationDeleteViewModel
        //    {
        //        Id = destination.Id,
        //        Name = destination.Name,
        //        PublisherId = destination.PublisherId,
        //    };

        //    return View(viewModel);
        //}

        //[HttpPost, ActionName("Delete")]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var destination = await context.Destinations
        //    .FirstOrDefaultAsync(d => d.Id == id && d.PublisherId == GetUserId());

        //    if (destination == null)
        //    {
        //        return NotFound();
        //    }

        //    // Soft delete the destination
        //    destination.IsDeleted = true;
        //    context.Destinations.Update(destination);
        //    await context.SaveChangesAsync();

        //    return RedirectToAction("Index");
        //}

        private async Task<IEnumerable<CategoryViewModel>> GetCategories()
        {
            return await context.Products
                .AsNoTracking()
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }
    }
}
