﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Shop.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<IdentityUser>  UserMgr { get; }
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
            

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                var result = await SignInMgr.PasswordSignInAsync(model.Username, model.Password, false, false);
                if(result.Succeeded)
                {
                    return RedirectToAction("List", "Products");
                }
                else return View(model);

            }
        }
    }
}