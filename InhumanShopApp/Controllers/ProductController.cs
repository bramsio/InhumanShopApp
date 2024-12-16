using InhumanShopApp.Data;
using Microsoft.AspNetCore.Mvc;
using InhumanShopApp.Models.Product;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using InhumanShopApp.Infrastructure.Data.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace InhumanShopApp.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ProductController : Controller
    {
        //CRUD operations for products [admins]
        private readonly ApplicationDbContext context;
        public ProductController(ApplicationDbContext _context)
        {
            context = _context;
        }

        //All products
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await context.Products
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

            return View(products);
        }

        //// products with filter and search
        //[AllowAnonymous]
        //[HttpGet]
        //public async Task<IActionResult> Index(string category, bool filter = false)
        //{
        //    // Извличане на всички продукти
        //    var productsQuery = context.Products.AsQueryable();

        //    // Ако е зададена категория, филтрирай продуктите
        //    if (!string.IsNullOrEmpty(category))
        //    {
        //        productsQuery = productsQuery.Where(p => p.Category.Name == category);
        //    }

        //    // Извличане на продуктите след евентуалното филтриране
        //    var products = await productsQuery
        //        .Select(p => new ProductInfoViewModel
        //        {
        //            Id = p.Id,
        //            Name = p.Name,
        //            Price = p.Price,
        //            Category = p.Category.Name,
        //            Description = p.Description,
        //            ImageUrl = p.ImageUrl
        //        })
        //        .ToListAsync();

        //    // Извличане на всички категории за dropdown менюто
        //    var categories = await context.Categories
        //        .Select(c => c.Name)
        //        .ToListAsync();

        //    // Предаване на категориите и текущата селекция към View-то
        //    ViewData["Categories"] = categories;
        //    ViewData["SelectedCategory"] = category;
        //    ViewData["FilterCategories"] = filter; // Управлява показването на филтъра в View-то

        //    return View(products);
        //}


        //Add product
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

        

        //Delete product
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await context.Products
            .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var viewModel = new ProductDeleteViewModel
            {
                Id = product.Id,
                Name = product.Name,
            };

            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = context.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            context.Products.Remove(product);
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }



        //Edit product
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var product = await context.Products
                .FindAsync(id);

            if (product == null)
            {
                return BadRequest();
            }


            var model = new ProductEditViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Count = product.Count,
                Price = product.Price,
                CategoryId = product.CategoryId,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
            };
            model.Categories = await GetCategories();

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(ProductEditViewModel model, int id)
        {

            var product = await context.Products
                .FindAsync(id);

            if (product == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await GetCategories();
                return View(model);
            }

            product.Id = model.Id;
            product.Name = model.Name;
            product.CategoryId = model.CategoryId;
            product.Description = model.Description;
            product.ImageUrl = model.ImageUrl;
            product.Count = model.Count;
            product.Price = model.Price;

            context.Products.Update(product);
            await context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Product edited successfully!";
            return RedirectToAction("Index");
        }



        
        private async Task<IEnumerable<CategoryViewModel>> GetCategories()
        {
            return await context.Categories
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
