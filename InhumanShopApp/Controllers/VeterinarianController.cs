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



        // Details for a specific veterinarian
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest();
            }

            var veterinarian = await context.Users
                .OfType<Veterinarian>()
                .FirstOrDefaultAsync(v => v.Id == id);

            if (veterinarian == null)
            {
                return NotFound();
            }

            var viewModel = new VeterinarianDetailsViewModel
            {
                Id = veterinarian.Id,
                Name = veterinarian.Name,
                Specialization = veterinarian.Specialization,
                YearsOfExperience = veterinarian.YearsOfExperience,
                TelNumber = veterinarian.TelNumber,
                Email = veterinarian.Email 
            };

            return View(viewModel);
        }
    }
}
