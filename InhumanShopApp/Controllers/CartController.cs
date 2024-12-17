using InhumanShopApp.Data;
using InhumanShopApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using InhumanShopApp.Models.Cart;

namespace InhumanShopApp.Controllers
{
    public class CartController : Controller
    {   //cart and CRUD operations for products in cart 

        private readonly ApplicationDbContext context;

        public CartController(ApplicationDbContext _context)
        {
            context = _context;
        }


        //Cart
        public async Task<IActionResult> ViewCart()
        {
            var userId = GetUserId();
            var cart = await context.Orders
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Size)
                .FirstOrDefaultAsync(o => o.UserId == userId && o.Status.Name == "Active");

            if (cart == null)
            {
                return View(new CartViewModel());
            }

            var cartViewModel = new CartViewModel
            {
                OrderId = cart.Id,
                TotalPrice = cart.TotalPrice,
                Items = cart.OrderItems.Select(oi => new CartItemViewModel
                {
                    ProductId = oi.ProductId,
                    ProductName = oi.Product.Name,
                    SizeId = oi.SizeId,
                    SizeName = oi.Size.Name,
                    Quantity = oi.Quantity,
                    Price = oi.Price
                }).ToList()
            };

            return View(cartViewModel);
        }







        // Add a product to cart
        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int sizeId, int quantity)
        {

            if (sizeId <= 0)
            {
                TempData["Error"] = "You must select a size before adding the product to the cart.";
                return RedirectToAction("Details", "UserProduct", new { id = productId });
            }

            var userId = GetUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "Account");
            }

            // does the user have cart
            var cart = await context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.UserId == userId && o.Status.Name == "Active");

            if (cart == null)
            {
                // Add cart
                cart = new Order
                {
                    UserId = userId,
                    OrderDate = DateTime.Now,
                    TotalPrice = 0,
                    Status = await context.Statuses.FirstOrDefaultAsync(s => s.Name == "Active")
                };
                context.Orders.Add(cart);
                await context.SaveChangesAsync();
            }

            // We get a product with price
            var product = await context.Products.FirstOrDefaultAsync(p => p.Id == productId);
            if (product == null)
            {
                return NotFound();
            }

            // If we already have this product in cart
            var orderItem = cart.OrderItems.FirstOrDefault(oi => oi.ProductId == productId && oi.SizeId == sizeId);

            if (orderItem == null)
            {
                // if the product isnt in the cart
                cart.OrderItems.Add(new OrderItem
                {
                    ProductId = productId,
                    SizeId = sizeId,
                    Quantity = quantity,
                    Price = product.Price
                });
            }
            else
            {
                // If product is in cart we updte the quanity
                orderItem.Quantity += quantity;
            }

            cart.TotalPrice = cart.OrderItems.Sum(oi => oi.Quantity * oi.Price);
            await context.SaveChangesAsync();
            TempData["Message"] = $"{product.Name} беше добавен в кошницата.";
            return RedirectToAction("Index", "Product");
        }






        // Remove product from Cart
        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int orderId, int productId, int sizeId)
        {
            var userId = GetUserId();
            var cart = await context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.Id == orderId && o.UserId == userId && o.Status.Name == "Active");

            if (cart == null)
            {
                return NotFound();
            }

            var orderItem = cart.OrderItems.FirstOrDefault(oi => oi.ProductId == productId && oi.SizeId == sizeId);
            if (orderItem == null)
            {
                return NotFound();
            }

            cart.OrderItems.Remove(orderItem);
            cart.TotalPrice = cart.OrderItems.Sum(oi => oi.Quantity * oi.Price);

            await context.SaveChangesAsync();

            TempData["Message"] = "Продуктът беше премахнат от кошницата.";
            return RedirectToAction("ViewCart");
        }











        // Checkout
        [HttpGet]
        public async Task<IActionResult> Checkout(int orderId)
        {
            var userId = GetUserId();
            var order = await context.Orders
                .FirstOrDefaultAsync(o => o.Id == orderId && o.UserId == userId && o.Status.Name == "Active");

            if (order == null)
            {
                return NotFound();
            }

            var checkoutViewModel = new CheckoutViewModel
            {
                OrderId = order.Id,
                TotalPrice = order.TotalPrice
            };

            return View(checkoutViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(CheckoutViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = GetUserId();
            var order = await context.Orders
                .FirstOrDefaultAsync(o => o.Id == model.OrderId && o.UserId == userId && o.Status.Name == "Active");

            if (order == null)
            {
                return NotFound();
            }

            // Create a new payment record
            var payment = new Payment
            {
                OrderId = model.OrderId,
                CardNumber = model.CardNumber,
                CardHolderName = model.CardHolderName,
                CVV = model.CVV
            };

            context.Payments.Add(payment);

            // Update order status
            order.Status = await context.Statuses.FirstOrDefaultAsync(s => s.Name == "Completed");
            order.OrderDate = DateTime.Now;

            await context.SaveChangesAsync();

            TempData["Message"] = "Вашата поръчка беше успешно завършена!";

            return RedirectToAction("ViewOrders", "Order");
        }




        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
