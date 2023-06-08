using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoClub.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class WebSiteBiographyController : Controller
    {
        private readonly AppDbContext _db;
        //private readonly UserManager<AppUser> _userManager;
        public WebSiteBiographyController(AppDbContext db)
        {
            _db = db;
            //_userManager = userManager;
        }
        public IActionResult Biography()
        {
            WebSiteBio webSiteBio = _db.WebSiteBios.FirstOrDefault(wsb => wsb.Id == 1);
            return View(webSiteBio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Biography(WebSiteBio webSiteBio)
        {
            if (!ModelState.IsValid) return View(webSiteBio);

            WebSiteBio webSiteBioFromDb = _db.WebSiteBios.FirstOrDefault(wsb => wsb.Id == 1);

            webSiteBioFromDb.Address = webSiteBio.Address;
            webSiteBioFromDb.Phone = webSiteBio.Phone;
            webSiteBioFromDb.Fax = webSiteBio.Fax;
            webSiteBioFromDb.Email = webSiteBio.Email;
            webSiteBioFromDb.OpeningHoursSales = webSiteBio.OpeningHoursSales;
            webSiteBioFromDb.FacebookLink = webSiteBio.FacebookLink;
            webSiteBioFromDb.TwitterLink = webSiteBio.TwitterLink;
            webSiteBioFromDb.GooglePlusLink = webSiteBio.GooglePlusLink;
            webSiteBioFromDb.InstagramLink = webSiteBio.InstagramLink;
            webSiteBioFromDb.YoutubeLink = webSiteBio.YoutubeLink;
            webSiteBioFromDb.SkypeLink = webSiteBio.SkypeLink;
            webSiteBioFromDb.Copyright = webSiteBio.Copyright;
            webSiteBioFromDb.LocationMap = webSiteBio.LocationMap;
            webSiteBioFromDb.AboutUs = webSiteBio.AboutUs;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Biography));
        }
    }
}