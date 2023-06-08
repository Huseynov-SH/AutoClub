using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.ViewModels;
using AutoClub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using AutoClub.Extensions;
using static AutoClub.Utilities.Utilities;

namespace AutoClub.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MainSliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public MainSliderController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                MainSliders = _db.MainSliders.ToList(),
            };

            return View(homeVM);
        }

        public IActionResult Create()
        {
            if(_db.MainSliders.Count() >= 5)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MainSlider mainSlider)
        {
            if (!ModelState.IsValid)
            {
                return View(mainSlider);
            }

            if (mainSlider.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo should be selected");
                return View(mainSlider);
            }

            if (!mainSlider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Photo is not valid");
                return View(mainSlider);
            }

            mainSlider.Image = await mainSlider.Photo.SaveFileAsync(_env.WebRootPath, "MainSlider");

            await _db.MainSliders.AddAsync(mainSlider);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var mainSlider = await _db.MainSliders.FindAsync(id);
            if (mainSlider == null) return NotFound();

            return View(mainSlider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, MainSlider mainSlider)
        {
            if (!ModelState.IsValid) return View(mainSlider);

            MainSlider mainSliderFromDb = await _db.MainSliders.FindAsync(id);

            if (mainSlider.Photo != null)
            {
                if (mainSlider.Photo.IsImage())
                {
                    //Remove old image
                    RemoveFile(mainSliderFromDb.Image, "MainSlider", _env.WebRootPath);

                    //Save new image
                    mainSliderFromDb.Image = await mainSlider.Photo.SaveFileAsync(_env.WebRootPath, "MainSlider");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Photo is invalid");
                    return View(mainSlider);
                }
            }

            mainSliderFromDb.SliderTitle = mainSlider.SliderTitle;
            mainSliderFromDb.SliderSubTitle = mainSlider.SliderSubTitle;
            mainSliderFromDb.SliderMain = mainSlider.SliderMain;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if (_db.MainSliders.Count() <= 1)
            {
                return NotFound();
            }
            var mainSlider = await _db.MainSliders.FindAsync(id);
            if (mainSlider == null) return NotFound();

            RemoveFile(mainSlider.Image, "MainSlider", _env.WebRootPath);

            _db.MainSliders.Remove(mainSlider);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}