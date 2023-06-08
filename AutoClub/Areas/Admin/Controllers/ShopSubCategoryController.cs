using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoClub.ViewModels;
using AutoClub.Models;
using Microsoft.AspNetCore.Authorization;
using AutoClub.DAL;

namespace AutoClub.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ShopSubCategoryController : Controller
    {
        private readonly AppDbContext _db;
        public ShopSubCategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ShopVM shopVM = new ShopVM
            {
                ShopSubCategories = _db.ShopSubCategories.ToList(),
                ShopCategories = _db.ShopCategories.ToList(),
            };
            return View(shopVM);
        }
        public IActionResult Create()
        {
            ViewBag.category = _db.ShopCategories;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ShopSubCategory subCategory)
        {
            ViewBag.Make = _db.Makes;

            if (!ModelState.IsValid)
            {
                return View(subCategory);
            }

            await _db.ShopSubCategories.AddAsync(subCategory);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            ViewBag.category = _db.ShopCategories;
            var subCategory = await _db.ShopSubCategories.FindAsync(id);
            if (subCategory == null) return NotFound();

            return View(subCategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, ShopSubCategory subCategory)
        {
            ViewBag.Make = _db.Makes;
            if (!ModelState.IsValid) return View(subCategory);

            ShopSubCategory subCategoryFromDb = await _db.ShopSubCategories.FindAsync(id);

            subCategoryFromDb.Name = subCategory.Name;
            subCategoryFromDb.ShopCategoryId = subCategory.ShopCategoryId;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var subCategory = await _db.ShopSubCategories.FindAsync(id);
            if (subCategory == null) return NotFound();


            _db.ShopSubCategories.Remove(subCategory);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}