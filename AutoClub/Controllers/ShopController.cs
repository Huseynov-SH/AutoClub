using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.ViewModels;
using AutoClub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using AutoClub.Extensions;

namespace AutoClub.Controllers
{
    [Authorize(Roles = "Admin, Company")]

    public class ShopController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<AppUser> _userManager;

        public ShopController(AppDbContext db, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _db = db;
            _userManager = userManager;
            _env = env;
        }
        [AllowAnonymous]
        public IActionResult Index(int? subcategory)
        {
            ShopVM shopVM = new ShopVM
            {
                ShopCategories = _db.ShopCategories.ToList(),
                ShopSubCategories = _db.ShopSubCategories.ToList(),
                ShopProductImages = _db.ShopProductImages.ToList(),
                ShopProducts = _db.ShopProducts.ToList(),
                RelatedProducts = _db.ShopProducts.Where(p => p.Blocked == false).ToList(),
            };
            if (subcategory == null)
            {
                shopVM.ShopProducts = _db.ShopProducts.Where(p => p.Blocked == false).ToList();
            }
            else
            {
                shopVM.ShopProducts = _db.ShopProducts.Where(p => p.ShopSubCategoryId == subcategory && p.Blocked == false).ToList();
            }
            return View(shopVM);
        }

        public IActionResult Create()
        {
            ViewBag.category = _db.ShopCategories.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ShopProduct shopProduct)
        {
            ViewBag.category = _db.ShopCategories.ToList();

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            if (!User.IsInRole("Company"))
            {
                return NotFound();
            }
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);

            shopProduct.Blocked = true;
            shopProduct.AppUserId = activUser.Id;
            shopProduct.CreateDate = DateTime.Now;

            if (!ModelState.IsValid) return View(shopProduct);

            //Custom StateIsValid
            if (shopProduct.ShopSubCategoryId == 0)
            {
                ModelState.AddModelError("ShopSubCategoryId", "You have to choose");
                return View(shopProduct);
            }

            if (shopProduct.Photos == null)
            {
                ModelState.AddModelError("Photos", "You must choose at least 1 image");
                return View(shopProduct);
            }
            if (shopProduct.Photos.Count() > 5)
            {
                ModelState.AddModelError("Photos", "You can upload up to 5 photos");
                return View(shopProduct);
            }
            foreach (var imgFile in shopProduct.Photos)
            {
                if (!imgFile.IsImage())
                {
                    ModelState.AddModelError("Photos", "Only pictures can be selected");
                    return View(shopProduct);
                }
            }

            await _db.ShopProducts.AddAsync(shopProduct);

            foreach (var imgFile in shopProduct.Photos)
            {
                ShopProductImage productImage = new ShopProductImage();
                productImage.Name = await imgFile.SaveFileAsync(_env.WebRootPath, "Shop");
                productImage.ShopProductId = shopProduct.Id;
                await _db.ShopProductImages.AddAsync(productImage);
            }

            await _db.SaveChangesAsync();
            return RedirectToAction("MyProduct", "Account");
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var product = await _db.ShopProducts.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.category = _db.ShopCategories.ToList();

            ShopVM shopVM = new ShopVM
            {
                ShopProduct = product,
                ShopProductImages = _db.ShopProductImages.Where(i => i.ShopProductId == product.Id),
                ShopSubCategories = _db.ShopSubCategories.ToList(),
                RelatedProducts = _db.ShopProducts.Where(rp => rp.ShopSubCategory.ShopCategoryId == product.ShopSubCategory.ShopCategoryId && rp.Id != product.Id),
                ShopProductAllImages = _db.ShopProductImages.ToList(),
                AppUser = await _userManager.FindByIdAsync(product.AppUserId),
            };
            return View(shopVM);
        }
    }
}