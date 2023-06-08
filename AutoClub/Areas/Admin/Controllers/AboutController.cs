using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Extensions;
using AutoClub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using static AutoClub.Utilities.Utilities;

namespace AutoClub.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public AboutController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            AboutUs aboutUs = _db.AboutUs.FirstOrDefault(a => a.Id == 1);
            return View(aboutUs);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(AboutUs aboutUs)
        {
            if (!ModelState.IsValid) return View(aboutUs);
            AboutUs aboutUsDb = _db.AboutUs.FirstOrDefault(a => a.Id == 1);

            if (aboutUs.Photo != null)
            {
                if (aboutUs.Photo.IsImage())
                {
                    //Remove old image
                    RemoveFile(aboutUsDb.Image, "About", _env.WebRootPath);

                    //Save new image
                    aboutUsDb.Image = await aboutUs.Photo.SaveFileAsync(_env.WebRootPath, "About");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Photo is invalid");
                    return View(aboutUs);
                }
            }
            aboutUsDb.Title = aboutUs.Title;
            aboutUs.SubTitle = aboutUs.SubTitle;
            aboutUs.Description = aboutUs.Description;


            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Offers()
        {
            List<AboutUsOffers> aboutUsOffers = _db.AboutUsOffers.ToList();
            return View(aboutUsOffers);
        }

        public async Task<IActionResult> OffersDetails(int id)
        {
            var offer = await _db.AboutUsOffers.FindAsync(id);
            if (offer == null)
            {
                return NotFound();
            }

            return View(offer);
        }

        public async Task<IActionResult> OffersUpdate(int id)
        {
            var offer = await _db.AboutUsOffers.FindAsync(id);
            if (offer == null) return NotFound();

            return View(offer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OffersUpdate(int id, AboutUsOffers aboutUsOffers)
        {
            if (!ModelState.IsValid) return View(aboutUsOffers);

            AboutUsOffers aboutUsOffersDb = await _db.AboutUsOffers.FindAsync(id);

            if (aboutUsOffers.Photo != null)
            {
                if (aboutUsOffers.Photo.IsImage())
                {
                    //Remove old image
                    RemoveFile(aboutUsOffersDb.Image, "About", _env.WebRootPath);

                    //Save new image
                    aboutUsOffersDb.Image = await aboutUsOffers.Photo.SaveFileAsync(_env.WebRootPath, "About");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Photo is invalid");
                    return View(aboutUsOffers);
                }
            }

            aboutUsOffersDb.OffersSection = aboutUsOffers.OffersSection;
            aboutUsOffersDb.OffersTitle = aboutUsOffers.OffersTitle;
            aboutUsOffersDb.OffersDescription = aboutUsOffers.OffersDescription;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Offers));
        }

        public IActionResult OffersCreate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OffersCreate(AboutUsOffers aboutUsOffers)
        {
            if (!ModelState.IsValid)
            {
                return View(aboutUsOffers);
            }

            if (aboutUsOffers.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo should be selected");
                return View(aboutUsOffers);
            }

            if (!aboutUsOffers.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Photo is not valid");
                return View(aboutUsOffers);
            }

            aboutUsOffers.Image = await aboutUsOffers.Photo.SaveFileAsync(_env.WebRootPath, "About");

            await _db.AboutUsOffers.AddAsync(aboutUsOffers);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Offers));
        }

        public async Task<IActionResult> DeleteOffer(int id)
        {
            var offer = await _db.AboutUsOffers.FindAsync(id);
            if (offer == null) return NotFound();

            RemoveFile(offer.Image, "About", _env.WebRootPath);

            _db.AboutUsOffers.Remove(offer);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Offers));
        }

        public IActionResult Choose()
        {
            List<AboutUsChoseUs> AboutUsChoseUs = _db.AboutUsChoseUs.ToList();
            return View(AboutUsChoseUs);
        }

        public async Task<IActionResult> ChooseUpdate(int id)
        {
            var choose = await _db.AboutUsChoseUs.FindAsync(id);
            if (choose == null) return NotFound();

            return View(choose);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChooseUpdate(int id, AboutUsChoseUs aboutUsChoseUs)
        {
            if (!ModelState.IsValid) return View(aboutUsChoseUs);

            AboutUsChoseUs aboutUsChoseUsDb = await _db.AboutUsChoseUs.FindAsync(id);

            aboutUsChoseUsDb.Description = aboutUsChoseUs.Description;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Choose));
        }

        public IActionResult ChooseCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChooseCreate(AboutUsChoseUs aboutUsChoseUs)
        {
            if (!ModelState.IsValid)
            {
                return View(aboutUsChoseUs);
            }


            await _db.AboutUsChoseUs.AddAsync(aboutUsChoseUs);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Choose));
        }

        public async Task<IActionResult> DeleteChoose(int id)
        {
            var choose = await _db.AboutUsChoseUs.FindAsync(id);
            if (choose == null) return NotFound();

            _db.AboutUsChoseUs.Remove(choose);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Choose));
        }

        public IActionResult MoreInfo()
        {
            AboutUsMoreInfo moreInfo = _db.AboutUsMoreInfo.FirstOrDefault(a => a.Id == 1);
            return View(moreInfo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MoreInfo(AboutUsMoreInfo aboutUsMoreInfo)
        {
            if (!ModelState.IsValid) return View(aboutUsMoreInfo);
            AboutUsMoreInfo aboutUsMoreInfoDb = _db.AboutUsMoreInfo.FirstOrDefault(a => a.Id == 1);

            aboutUsMoreInfoDb.Block1Title = aboutUsMoreInfo.Block1Title;
            aboutUsMoreInfoDb.Block1Inside = aboutUsMoreInfo.Block1Inside;
            aboutUsMoreInfoDb.Block2Title = aboutUsMoreInfo.Block2Title;
            aboutUsMoreInfoDb.Block2Inside = aboutUsMoreInfo.Block2Inside;
            aboutUsMoreInfoDb.Block3Title = aboutUsMoreInfo.Block3Title;
            aboutUsMoreInfoDb.Block3Inside = aboutUsMoreInfo.Block3Inside;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(MoreInfo));
        }
    }
}