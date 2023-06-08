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
    public class FuelTypeController : Controller
    {
        private readonly AppDbContext _db;
        public FuelTypeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                FuelTypes = _db.FuelTypes.ToList(),
            };

            return View(homeVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FuelType fuelType)
        {
            if (!ModelState.IsValid)
            {
                return View(fuelType);
            }

            await _db.FuelTypes.AddAsync(fuelType);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var fuelType = await _db.FuelTypes.FindAsync(id);
            if (fuelType == null) return NotFound();

            return View(fuelType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, FuelType fuelType)
        {
            if (!ModelState.IsValid) return View(fuelType);

            FuelType fuelTypeFromDb = await _db.FuelTypes.FindAsync(id);

            fuelTypeFromDb.Name = fuelType.Name;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var fuelType = await _db.FuelTypes.FindAsync(id);
            if (fuelType == null) return NotFound();


            _db.FuelTypes.Remove(fuelType);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}