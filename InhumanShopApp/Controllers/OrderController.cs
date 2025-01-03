﻿using InhumanShopApp.Data;
using InhumanShopApp.Models.Cart;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace InhumanShopApp.Controllers
{
    public class OrderController : Controller
    {
        //order history
        private readonly ApplicationDbContext context;

        public OrderController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        // View All Orders
        //public async Task<IActionResult> ViewOrders()
        //{
        //    var userId = GetUserId();
        //    var orders = await context.Orders
        //        .Include(o => o.Status)
        //        .Where(o => o.UserId == userId)
        //        .ToListAsync();

        //    var ordersViewModel = orders.Select(o => new OrderHistoryViewModel
        //    {
        //        OrderId = o.Id,
        //        OrderDate = o.OrderDate,
        //        Status = o.Status.Name,
        //        TotalPrice = o.TotalPrice
        //    }).ToList();

        //    return View("~/Views/Cart/ViewOrders.cshtml",ordersViewModel);
        //}

        public async Task<IActionResult> ViewOrders()
        {
            var userId = GetUserId();

            var orders = await context.Orders
                .Include(o => o.Status)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .Where(o => o.UserId == userId)
                .ToListAsync();

            var ordersViewModel = orders.Select(o => new OrderHistoryViewModel
            {
                OrderId = o.Id,
                OrderDate = o.OrderDate,
                Status = o.Status.Name,
                TotalPrice = o.TotalPrice,
                Products = o.OrderItems.Select(oi => new OrderProductViewModel
                {
                    Name = oi.Product.Name,
                    Quantity = oi.Quantity
                }).ToList()
            }).ToList();

            return View("~/Views/Cart/ViewOrders.cshtml", ordersViewModel);
        }


        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
