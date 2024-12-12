using InhumanShopApp.Data;
using InhumanShopApp.Infrastructure.Data.Models;
using InhumanShopApp.Models;
using InhumanShopApp.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace InhumanShopApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly ApplicationDbContext context;

        public AccountController(UserManager<User> _userManager, SignInManager<User> _signInManager, ApplicationDbContext _context)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            context = _context;
        }



        //Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await userManager.CreateAsync(user, model.Password);


            if (result.Succeeded)
            {
                // Задаване на роля "User"
                await userManager.AddToRoleAsync(user, "User");

                // Автоматично влизане след регистрация
                await signInManager.SignInAsync(user, isPersistent: false);

                // Пренасочване към началната страница
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }



        //Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Check if the email exists in the database
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "This email is not registered.");
                return View(model);
            }

            // Check if the password is correct
            var result = await signInManager.PasswordSignInAsync(user, model.Password, true, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Incorrect password.");
                return View(model);
            }
        }



        //Logout
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }



        //Profile

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var model = new ProfileViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
            };

            return View(model);
        }


        //Confirm password

        [HttpGet]
        public IActionResult ConfirmPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmPassword(string password)
        {
            var user = await userManager.GetUserAsync(User);

            if (user != null)
            {
                var passwordValid = await userManager.CheckPasswordAsync(user, password);

                if (passwordValid)
                {
                    var model = new EditViewModel
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Email = user.Email,
                    };
                    return View("Edit", model);
                }
                else
                {
                    ModelState.AddModelError("", "Invalid password");
                }
            }

            return View();
        }






        //Update profile

        [HttpPost]
        public async Task<IActionResult> UpdateProfile(EditViewModel model)
        {
            if (string.IsNullOrEmpty(model.NewPassword))
            {
                ModelState.Remove("NewPassword");
            }

            if (ModelState.IsValid)
            {
                var user = await context.Users.FindAsync(model.Id);

                if (user != null)
                {
                    user.Name = model.Name;
                    user.Email = model.Email;

                    if (!string.IsNullOrEmpty(model.NewPassword))
                    {
                        var token = await userManager.GeneratePasswordResetTokenAsync(user);
                        var result = await userManager.ResetPasswordAsync(user, token, model.NewPassword);

                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }

                            return View(model);
                        }
                    }

                    context.Users.Update(user);
                    await context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Profile updated successfully!";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "User not found.");
                }
            }

            return View(model);
        }





        //За change password логика за изпращане на имейл за да се потвърди


        //Change password

        //[HttpGet]
        //public IActionResult ChangePassword(string username)
        //{
        //    if (string.IsNullOrEmpty(username))
        //    {
        //        return RedirectToAction("VerifyEmail", "Account");
        //    }
        //    return View(new ChangePasswordViewModel { Email = username });
        //}

        //[HttpPost]
        //public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await userManager.FindByNameAsync(model.Email);
        //        if (user != null)
        //        {
        //            var result = await userManager.RemovePasswordAsync(user);
        //            if (result.Succeeded)
        //            {
        //                result = await userManager.AddPasswordAsync(user, model.NewPassword);
        //                return RedirectToAction("Login", "Account");
        //            }
        //            else
        //            {

        //                foreach (var error in result.Errors)
        //                {
        //                    ModelState.AddModelError("", error.Description);
        //                }

        //                return View(model);
        //            }
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Email not found!");
        //            return View(model);
        //        }
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "Something went wrong. try again.");
        //        return View(model);
        //    }
        //}



    }
}
