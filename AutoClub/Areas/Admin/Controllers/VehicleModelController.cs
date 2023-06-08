using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Models;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoClub.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class VehicleModelController : Controller
    {
        private readonly AppDbContext _db;
        public VehicleModelController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                VehicleModel = _db.VehicleModels.ToList(),
                Makes = _db.Makes.ToList(),
            };
            return View(homeVM);
        }

        public IActionResult Create()
        {
            ViewBag.Make = _db.Makes;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VehicleModel vehicleModel)
        {
            ViewBag.Make = _db.Makes;

            if (!ModelState.IsValid)
            {
                return View(vehicleModel);
            }

            await _db.VehicleModels.AddAsync(vehicleModel);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            ViewBag.Make = _db.Makes;
            var model = await _db.VehicleModels.FindAsync(id);
            if (model == null) return NotFound();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, VehicleModel vehicleModel)
        {
            ViewBag.Make = _db.Makes;
            if (!ModelState.IsValid) return View(vehicleModel);

            VehicleModel vehicleModelFromDb = await _db.VehicleModels.FindAsync(id);

            vehicleModelFromDb.Name = vehicleModel.Name;
            vehicleModelFromDb.MakeId = vehicleModel.MakeId;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var vehicleModel = await _db.VehicleModels.FindAsync(id);
            if (vehicleModel == null) return NotFound();


            _db.VehicleModels.Remove(vehicleModel);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}