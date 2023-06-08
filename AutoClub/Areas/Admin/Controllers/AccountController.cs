using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Extensions;
using AutoClub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static AutoClub.Utilities.Utilities;

namespace AutoClub.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Member")]
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;

        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> MyAccount()
        {
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(activUser);
        }

        public async Task<IActionResult> AccountSettings()
        {
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(activUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AccountSettings(string id, AppUser appUser)
        {
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (appUser.Photo != null)
            {
                if (appUser.Photo.IsImage())
                {
                    //Remove old image
                    RemoveFile(activUser.Image, "Users", _env.WebRootPath);

                    //Save new image
                    activUser.Image = await appUser.Photo.SaveFileAsync(_env.WebRootPath, "Users");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Photo is invalid");
                    return View(appUser);
                }
            }


            activUser.FirstName = appUser.FirstName;
            activUser.LastName = appUser.LastName;
            activUser.Section = appUser.Section;
            activUser.Description = appUser.Description;
            activUser.Location = appUser.Location;
            activUser.Phone = appUser.Phone;
            activUser.FacebookLink = appUser.FacebookLink;
            activUser.InstagramLink = appUser.InstagramLink;
            activUser.TwitterLink = appUser.TwitterLink;
            activUser.LinkedinLink = appUser.LinkedinLink;

            await _userManager.UpdateAsync(activUser);

            return RedirectToAction(nameof(MyAccount));
        }
    }
}