using InhumanShopApp.Data;
using InhumanShopApp.Infrastructure.Constants;
using InhumanShopApp.Infrastructure.Data.Models;
using InhumanShopApp.Models.Veterinarian;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InhumanShopApp.Controllers
{
    public class VeterinarianController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly ApplicationDbContext context;

        public VeterinarianController(UserManager<User> _userManager, ApplicationDbContext _context)
        {
            userManager = _userManager;
            context = _context;
        }


        //All veterinarians
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var veterinarians = await context.Users
            .OfType<Veterinarian>() // Филтрира само ветеринарите
            .Select(v => new VeterinarianViewModel
            {
                Id = v.Id,
                Name = v.Name,
                TelNumber = v.TelNumber, // Дефинирано в класа Veterinarian
                Specialization = v.Specialization
            })
            .ToListAsync();


            return View(veterinarians);
        }



        //Details for Vets

        //[Authorize] Add Vet (admins can adding vet)

        //And maybe anything for profil or register idk 
    }
}
