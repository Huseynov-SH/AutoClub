using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Models;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AutoClub.Controllers
{
    public class ShopsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public ShopsController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            IList<AppUser> companies = await _userManager.GetUsersInRoleAsync("Company");
            return View(companies);
        }

        public async Task<IActionResult> CompanyDetails(string id)
        {
            AppUser company = await _userManager.FindByIdAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            ShopVM shopVM = new ShopVM
            {
                AppUser = company,
                ShopProducts = _db.ShopProducts.Where(p => p.AppUserId == id && p.Blocked == false).OrderByDescending(p => p.CreateDate).ToList(),
                ShopProductImages = _db.ShopProductImages.ToList(),
            };
            return View(shopVM);
        }
    }
}