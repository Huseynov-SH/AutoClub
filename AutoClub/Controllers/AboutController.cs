using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using Microsoft.AspNetCore.Mvc;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Identity;
using AutoClub.Models;

namespace AutoClub.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        private UserManager<AppUser> _userManager;
        public AboutController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> AboutUs()
        {
            AboutUsVM aboutUsVM = new AboutUsVM
            {
                AboutUs = _db.AboutUs.FirstOrDefault(a => a.Id == 1),
                AboutUsOffers = _db.AboutUsOffers.ToList(),
                AboutUsChoseUs = _db.AboutUsChoseUs.ToList(),
                AboutUsMoreInfo = _db.AboutUsMoreInfo.FirstOrDefault(a => a.Id == 1),
                Members = await _userManager.GetUsersInRoleAsync("Member"),
            };
            return View(aboutUsVM);
        }
    }
}