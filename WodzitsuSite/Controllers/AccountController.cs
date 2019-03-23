using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WodzitsuSite.Data.Entities;
using WodzitsuSite.ViewModels;

namespace WodzitsuSite.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> logger;
        private readonly SignInManager<Czlopok> signInManager;

        public AccountController(ILogger<AccountController> logger, SignInManager<Czlopok> signInManager)
        {
            this.logger = logger;
            this.signInManager = signInManager;
        }

        public IActionResult Login()
        {
            if(this.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "App");
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, model.RemeberMe, false);

                if(result.Succeeded)
                {
                    if(Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    }
                    else
                    {
                        return RedirectToAction("Wakacje", "App");
                    }
                }
            }

            ModelState.TryAddModelError("", "Failed to login");

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "App");
        }
        [HttpGet]
        public IActionResult Manage()
        {
            return View();
        }
    }
}
