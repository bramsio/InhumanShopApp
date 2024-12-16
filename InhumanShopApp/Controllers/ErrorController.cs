using Microsoft.AspNetCore.Mvc;

namespace InhumanShopApp.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/Error500")]
        public IActionResult Error500()
        {
            return View(); 
        }


        [Route("Error/HandleError")]
        public IActionResult HandleError(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("Error404"); 
            }
            if(statusCode == 403)
            {
                return View("Error403");
            }

            return View("Еrror");
        }
    }
}
