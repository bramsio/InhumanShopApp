using Microsoft.AspNetCore.Mvc;

namespace InhumanShopApp.Controllers
{
    public class OrderController : Controller
    {
        //order history
        public IActionResult Index()
        {
            return View();
        }
    }
}
