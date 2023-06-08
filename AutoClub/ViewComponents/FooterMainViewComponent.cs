using AutoClub.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.ViewComponents
{
    public class FooterMainViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public FooterMainViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await Task.FromResult(_db.WebSiteBios.First(wsb => wsb.Id == 1)));
        }
    }
}
