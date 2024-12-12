using Microsoft.AspNetCore.Mvc;

namespace InhumanShopApp.Controllers
{
    public class ProductController : Controller
    {
        //CRUD operationd for products [admins]
        public IActionResult Index()
        {
            return View();
        }
    }
}
