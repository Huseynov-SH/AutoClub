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
    public class TransmissionTypeController : Controller
    {
        private readonly AppDbContext _db;
        public TransmissionTypeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                TransmissionTypes = _db.TransmissionTypes.ToList(),
            };

            return View(homeVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TransmissionType transmissionType)
        {
            if (!ModelState.IsValid)
            {
                return View(transmissionType);
            }

            await _db.TransmissionTypes.AddAsync(transmissionType);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var transmissionType = await _db.TransmissionTypes.FindAsync(id);
            if (transmissionType == null) return NotFound();

            return View(transmissionType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, TransmissionType transmissionType)
        {
            if (!ModelState.IsValid) return View(transmissionType);

            TransmissionType transmissionTypeFromDb = await _db.TransmissionTypes.FindAsync(id);

            transmissionTypeFromDb.Name = transmissionType.Name;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var transmissionType = await _db.TransmissionTypes.FindAsync(id);
            if (transmissionType == null) return NotFound();


            _db.TransmissionTypes.Remove(transmissionType);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}