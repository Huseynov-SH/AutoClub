using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoClub.Models;
using AutoClub.ViewModels;
using AutoClub.DAL;

namespace AutoClub.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.make = _db.Makes.OrderBy(m => m.Name).ToList();
            HomeVM homeVM = new HomeVM
            {
                webSiteBio = _db.WebSiteBios.First(w => w.Id == 1),
                Vehicles = _db.Vehicles.OrderByDescending(v => v.CreateDate).Where(v => v.PlanType == true && v.Blocked == false),
                Makes = _db.Makes.ToList(),
                VehicleModel = _db.VehicleModels.OrderBy(m => m.Name).ToList(),
                VehicleImages = _db.VehicleImages.ToList(),
                FuelTypes = _db.FuelTypes.ToList(),
                TransmissionTypes = _db.TransmissionTypes.ToList(),
                MainSliders = _db.MainSliders.ToList(),
                VehicleSearchModel = new VehicleSearchModel(),
            };
            return View(homeVM);
        }

        public IActionResult VehicleList(int? page)
        {
            ViewBag.make = _db.Makes.OrderBy(m => m.Name).ToList();
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Vehicles.Count() / 18);
            HomeVM homeVM = new HomeVM
            {
                webSiteBio = _db.WebSiteBios.First(w => w.Id == 1),
                AllVehicles = _db.Vehicles.Where(v => v.Blocked == false).OrderByDescending(pv => pv.CreateDate),
                Makes = _db.Makes.ToList(),
                VehicleModel = _db.VehicleModels.ToList(),
                VehicleImages = _db.VehicleImages.ToList(),
                FuelTypes = _db.FuelTypes.ToList(),
                DriveTypes = _db.DriveTypes.ToList(),
                BodyTypes = _db.BodyTypes.ToList(),
                TransmissionTypes = _db.TransmissionTypes.ToList(),
                VehicleSearchModel = new VehicleSearchModel(),
            };
            if (page == null)
            {
                homeVM.Vehicles = _db.Vehicles.Where(v => v.Blocked == false).OrderByDescending(av => av.CreateDate).Take(18);
                ViewBag.Page = 0;

            }
            else
            {
                homeVM.Vehicles = _db.Vehicles.Where(v => v.Blocked == false).OrderByDescending(av => av.CreateDate).Skip(18 * (int)page).Take(18);
                ViewBag.Page = page;
            }
            return View(homeVM);
        }

        public IActionResult SearchResult(VehicleSearchModel vehicleSearchModel)
        {
            ViewBag.make = _db.Makes.OrderBy(m => m.Name).ToList();
            var business = new VehicleBusinessLogicController(_db);
            HomeVM homeVM = new HomeVM
            {
                webSiteBio = _db.WebSiteBios.First(w => w.Id == 1),
                //AllVehicles = _db.Vehicles.Where(v => v.Blocked == false).OrderByDescending(pv => pv.CreateDate),
                Makes = _db.Makes.ToList(),
                VehicleModel = _db.VehicleModels.ToList(),
                VehicleImages = _db.VehicleImages.ToList(),
                FuelTypes = _db.FuelTypes.ToList(),
                DriveTypes = _db.DriveTypes.ToList(),
                BodyTypes = _db.BodyTypes.ToList(),
                TransmissionTypes = _db.TransmissionTypes.ToList(),
                Vehicles = business.GetVehicle(vehicleSearchModel).OrderByDescending(v => v.CreateDate),
                VehicleSearchModel = new VehicleSearchModel(),
            };
            return View(homeVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
