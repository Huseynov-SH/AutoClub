using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Models;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static AutoClub.Utilities.Utilities;

namespace AutoClub.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Member")]
    public class UnapprovedShopProductController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<AppUser> _userManager;

        public UnapprovedShopProductController(AppDbContext db, IHostingEnvironment env, UserManager<AppUser> userManager)
        {
            _db = db;
            _env = env;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            ShopVM shopVM = new ShopVM
            {
                ShopProducts = _db.ShopProducts.Where(p => p.Blocked == true).OrderByDescending(p => p.CreateDate).ToList(),
                ShopProductAllImages = _db.ShopProductImages.ToList(),
            };
            return View(shopVM);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _db.ShopProducts.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            ShopVM shopVM = new ShopVM
            {
                ShopProduct = product,
                ShopProductImages = _db.ShopProductImages.Where(i => i.ShopProductId == product.Id).ToList(),
            };
            return View(shopVM);
        }

        public async Task<IActionResult> Confirm(int id)
        {
            var product = await _db.ShopProducts.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            product.Blocked = false;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var product = await _db.ShopProducts.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            foreach (var image in _db.ShopProductImages.Where(img => img.ShopProductId == product.Id))
            {
                RemoveFile(image.Name, "Shop", _env.WebRootPath);
            }
            _db.ShopProducts.Remove(product);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}