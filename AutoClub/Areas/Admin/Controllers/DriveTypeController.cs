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
    public class DriveTypeController : Controller
    {
        private readonly AppDbContext _db;
        public DriveTypeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                DriveTypes = _db.DriveTypes.ToList(),
            };

            return View(homeVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DriveType driveType)
        {
            if (!ModelState.IsValid)
            {
                return View(driveType);
            }

            await _db.DriveTypes.AddAsync(driveType);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var driveType = await _db.DriveTypes.FindAsync(id);
            if (driveType == null) return NotFound();

            return View(driveType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, DriveType driveType)
        {
            if (!ModelState.IsValid) return View(driveType);

            DriveType driveTypeFromDb = await _db.DriveTypes.FindAsync(id);

            driveTypeFromDb.Name = driveType.Name;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var driveType = await _db.DriveTypes.FindAsync(id);
            if (driveType == null) return NotFound();


            _db.DriveTypes.Remove(driveType);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}