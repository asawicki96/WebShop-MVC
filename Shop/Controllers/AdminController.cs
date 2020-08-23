using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;


namespace Shop.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<IdentityUser> UserMgr { get; }
        private SignInManager<IdentityUser> SignInMgr { get; }

        public AdminController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            UserMgr = userManager;
            SignInMgr = signInManager;
        }



        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            if (!User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Dashboard", "Admin");
            }

        }


        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await SignInMgr.SignOutAsync();
            }

            return RedirectToAction("List", "Products");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                var result = await SignInMgr.PasswordSignInAsync(model.Username, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Dashboard", "Admin");
                }
                else return View(model);

            }
        }



        [Authorize(Roles = "Administrator")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit()
        {

            var user = await UserMgr.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [Authorize(Roles ="Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string UserName, string password, string old_password)
        {
            var user = await UserMgr.GetUserAsync(HttpContext.User);
            if (user != null)
            {
                
                if (!string.IsNullOrEmpty(UserName))
                    user.UserName = UserName;
                else
                    ModelState.AddModelError("", "Username cannot be empty");

                if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(old_password))
                {
                    IdentityResult result = await UserMgr.ChangePasswordAsync(user, old_password, password);

                    if (result.Succeeded)
                        return RedirectToAction("Dashboard");
                    else
                        ViewBag.error = "Old passord is incorrect";
                        return View(user);
                }

                if (!string.IsNullOrEmpty(UserName))
                {
                    IdentityResult result = await UserMgr.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Dashboard");
                    else
                        return View(user);
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
                return View(user);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}
