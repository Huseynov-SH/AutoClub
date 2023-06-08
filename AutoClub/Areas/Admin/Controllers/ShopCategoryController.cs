using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.ViewModels;
using AutoClub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoClub.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ShopCategoryController : Controller
    {
        private readonly AppDbContext _db;
        public ShopCategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ShopVM shopVM = new ShopVM
            {
                ShopCategories = _db.ShopCategories.ToList(),
            };
            return View(shopVM);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ShopCategory category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            await _db.ShopCategories.AddAsync(category);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var category = await _db.ShopCategories.FindAsync(id);
            if (category == null) return NotFound();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]  
        public async Task<IActionResult> Update(int id, ShopCategory category)
        {
            if (!ModelState.IsValid) return View(category);

            ShopCategory categoryFromDb = await _db.ShopCategories.FindAsync(id);

            categoryFromDb.Name = category.Name;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _db.ShopCategories.FindAsync(id);
            if (category == null) return NotFound();


            _db.ShopCategories.Remove(category);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}