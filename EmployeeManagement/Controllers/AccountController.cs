﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser>_userManager;
        private readonly SignInManager<IdentityUser>_signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser{UserName = model.Email, Email = model.Email};
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                   await _signInManager.SignInAsync(user, isPersistent: false);
                   return RedirectToAction("index", "home");
                }

                foreach (var error in result.Errors)
                {
                   ModelState.AddModelError("",error.Description);
                }
            }
            return View(model);
        }
    }
}