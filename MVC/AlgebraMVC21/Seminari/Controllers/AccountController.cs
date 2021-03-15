using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Seminari.Models;
using Seminari.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Seminari.Controllers
{
    public class AccountController : Controller
    {      
              


        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.KorisnickoIme, model.Password, model.ZapamtiMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "predbiljezbas");
                }

                ModelState.AddModelError(string.Empty, "Pogrešna prijava");
            }

            return View(model);
        }
    }
}
