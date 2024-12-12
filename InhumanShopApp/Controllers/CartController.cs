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
    }
}
