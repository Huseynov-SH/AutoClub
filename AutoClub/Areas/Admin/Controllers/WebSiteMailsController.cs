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
    public class WebSiteMailsController : Controller
    {
        private readonly AppDbContext _db;
        public WebSiteMailsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            WebSiteMails webSiteMails = _db.WebSiteMails.FirstOrDefault(wsb => wsb.Id == 1);
            return View(webSiteMails);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(WebSiteMails webSiteMails)
        {
            if (!ModelState.IsValid) return View(webSiteMails);

            WebSiteMails webSiteMailsFromDb = _db.WebSiteMails.FirstOrDefault(wsm => wsm.Id == 1);

            if(webSiteMailsFromDb == null)
            {
                return NotFound();
            }

            webSiteMailsFromDb.Email1 = webSiteMails.Email1;
            webSiteMailsFromDb.Email1Password = webSiteMails.Email1Password;
            webSiteMailsFromDb.Email2 = webSiteMails.Email2;
            webSiteMailsFromDb.Email2Password = webSiteMails.Email2Password;
            webSiteMailsFromDb.Email3 = webSiteMails.Email3;
            webSiteMailsFromDb.Email3Password = webSiteMails.Email3Password;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}