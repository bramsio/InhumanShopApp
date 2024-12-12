using Microsoft.AspNetCore.Mvc;

namespace InhumanShopApp.Controllers
{
    public class CategoryController : Controller
    {
        //CRUD operations for categories 
        public IActionResult Index()
        {
            return View();
        }
    }
}
