using AutoClub.DAL;
using AutoClub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Areas.Admin.ViewComponents
{
    public class HeaderBioViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        private UserManager<AppUser> _userManager;

        public HeaderBioViewComponent(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(await Task.FromResult(activUser));
        }
    }
}
