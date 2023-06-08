using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AutoClub.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _db;
        public CartController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.images = _db.ShopProductImages.ToList();

            string basket = HttpContext.Session.GetString("basket");
            if (basket == null)
            {
                return View();
            }
            return View(JsonConvert.DeserializeObject<List<BasketVM>>(basket));
        }
    }
}