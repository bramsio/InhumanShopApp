using Microsoft.AspNetCore.Mvc;

namespace InhumanShopApp.Controllers
{
    public class VeterinarianController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
