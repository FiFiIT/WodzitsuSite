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
        private readonly UserManager<Czlopok> userManager;

        public AccountController(ILogger<AccountController> logger, SignInManager<Czlopok> signInManager, UserManager<Czlopok> userManager)
        {
            this.logger = logger;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "App");
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, model.RemeberMe, false);

                if (result.Succeeded)
                {
                    if (Request.Query.Keys.Contains("ReturnUrl"))
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
        public async Task<IActionResult> Manage()
        {
            var czlopok = await userManager.GetUserAsync(User);

            if (czlopok != null)
            {
                return View(czlopok);
            }
            else
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("Index", "App");
            }
        }
        //[HttpPost]
        //public async Task<IActionResult> Manage(string password, string password2)
        //{
        //    if (!String.IsNullOrEmpty(password) && !String.IsNullOrEmpty(password2))
        //    {
        //        var czlopok = await userManager.GetUserAsync(User);

        //        if (password == password2)
        //        {
        //            userManager.PasswordHasher.HashPassword(czlopok, password); 
        //            var result = await userManager.UpdateAsync(czlopok);
        //        }
        //        else
        //        {
        //            ModelState.TryAddModelError("", "Passwords are not equal");
        //            return View(czlopok);
        //        }

        //    }

        //    return View();
        //}

        [HttpPost]
        public async Task<IActionResult> Manage(Czlopok czlopok, string password, string password2)
        {
            if (!String.IsNullOrEmpty(password) && !String.IsNullOrEmpty(password2))
            {
                var czlopokUpdate = await userManager.GetUserAsync(User);

                if (password == password2)
                {
                    czlopokUpdate.PasswordHash = userManager.PasswordHasher.HashPassword(czlopokUpdate, password);
                    var result = await userManager.UpdateAsync(czlopokUpdate);
                    return RedirectToAction("Index", "App");
                }
                else
                {
                    ModelState.TryAddModelError("", "Passwords are not equal");
                    return View(czlopokUpdate);
                }

            }

            if (String.IsNullOrEmpty(czlopok.Email))
            {
                var czlopokUpdate = await userManager.GetUserAsync(User);
                ModelState.TryAddModelError("", "Failed to update");
                return View(czlopokUpdate);
            }

            if (ModelState.IsValid)
            {
                var oldData = await userManager.GetUserAsync(User);
                bool changed = false;

                if (oldData.FirstName != czlopok.FirstName)
                {
                    oldData.FirstName = czlopok.FirstName;
                    changed = true;
                }
                if (oldData.LastName != czlopok.LastName)
                {
                    oldData.LastName = czlopok.LastName;
                    changed = true;
                }
                if (oldData.UserName != czlopok.UserName)
                {
                    oldData.UserName = czlopok.UserName;
                    changed = true;
                }
                if (oldData.Email != czlopok.Email)
                {
                    oldData.Email = czlopok.Email;
                    changed = true;
                }

                if (changed)
                {
                    var result = await userManager.UpdateAsync(oldData);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "App");
                    }
                    else
                    {
                        ModelState.TryAddModelError("", "Failed to update");
                        return View();
                    }
                }

                return RedirectToAction("Index", "App");
            }

            ModelState.TryAddModelError("", "Failed to update");
            return View();
        }
    }
}
