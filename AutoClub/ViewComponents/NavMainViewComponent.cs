using AutoClub.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.ViewComponents
{
    public class NavMainViewComponent: ViewComponent
    {
        private readonly AppDbContext _db;

        public NavMainViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await Task.FromResult(_db.WebSiteBios.First(wsb => wsb.Id == 1)));
        }
    }
}
