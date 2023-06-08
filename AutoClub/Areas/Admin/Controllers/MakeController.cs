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
    public class MakeController : Controller
    {
        private readonly AppDbContext _db;
        public MakeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Makes = _db.Makes.ToList(),
            };

            return View(homeVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Make make)
        {
            if (!ModelState.IsValid)
            {
                return View(make);
            }

            await _db.Makes.AddAsync(make);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var make = await _db.Makes.FindAsync(id);
            if (make == null) return NotFound();

            return View(make);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Make make)
        {
            if (!ModelState.IsValid) return View(make);

            Make makeFromDb = await _db.Makes.FindAsync(id);

            makeFromDb.Name = make.Name;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var make = await _db.Makes.FindAsync(id);
            if (make == null) return NotFound();


            _db.Makes.Remove(make);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}