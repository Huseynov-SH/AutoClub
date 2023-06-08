using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Extensions;
using AutoClub.Models;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using Newtonsoft.Json;

namespace AutoClub.Controllers
{
    public class VehicleController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public VehicleController(AppDbContext db, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _db = db;
            _userManager = userManager;
            _env = env;
        }
        public async Task<IActionResult> Submit()
        {
            ViewBag.make = _db.Makes.ToList();
            ViewBag.bodyType = _db.BodyTypes.ToList();
            ViewBag.transmissionTypes = _db.TransmissionTypes.ToList();
            ViewBag.driveTypes = _db.DriveTypes.ToList();
            ViewBag.fuelTypes = _db.FuelTypes.ToList();
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(VehicleVM vehicleVM)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            if (!User.IsInRole("User") && !User.IsInRole("Company"))
            {
                return NotFound();
            }

            ViewBag.make = _db.Makes.ToList();
            ViewBag.bodyType = _db.BodyTypes.ToList();
            ViewBag.transmissionTypes = _db.TransmissionTypes.ToList();
            ViewBag.driveTypes = _db.DriveTypes.ToList();
            ViewBag.fuelTypes = _db.FuelTypes.ToList();

            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            vehicleVM.Vehicle.AppUserId = activUser.Id;
            vehicleVM.Vehicle.CreateDate = DateTime.Now;
            vehicleVM.Vehicle.Blocked = true;


            if (!ModelState.IsValid) return View(vehicleVM);

            //Custom StateIsValid
            if (vehicleVM.Vehicle.VehicleModelId == 0)
            {
                ModelState.AddModelError("Vehicle.VehicleModelId", "You have to choose");
                return View(vehicleVM);
            }


            if (vehicleVM.Vehicle.Photos == null)
            {
                ModelState.AddModelError("Vehicle.Photos", "You must choose at least 1 image");
                return View(vehicleVM);
            }

            if (vehicleVM.Vehicle.Registration == true)
            {
                if (vehicleVM.Vehicle.RegistrationPlateNumber == null)
                {
                    ModelState.AddModelError("Vehicle.RegistrationPlateNumber", "The Registerarion Plate Number field is required.");
                    return View(vehicleVM);
                }
                if (vehicleVM.Vehicle.RegistrationNumber == null)
                {
                    ModelState.AddModelError("Vehicle.RegistrationNumber", "The Vehicle Registerarion Number field is required.");
                    return View(vehicleVM);
                }
            }

            foreach (var imgFile in vehicleVM.Vehicle.Photos)
            {
                if (!imgFile.IsImage())
                {
                    ModelState.AddModelError("Vehicle.Photos", "Only pictures can be selected");
                    return View(vehicleVM);
                }
            }

            if (vehicleVM.Vehicle.PlanType == true)
            {
                if (vehicleVM.Vehicle.CupunCode == "AABBCC")
                {
                    vehicleVM.Vehicle.PlanType = true;
                }
                else
                {
                    ModelState.AddModelError("Vehicle.CupunCode", "The coupon code is incorrect or used");
                    return View(vehicleVM);
                }
            }

            if (vehicleVM.Vehicle.PlanType == false)
            {
                List<Vehicle> AlreadyVehicle;
                AlreadyVehicle = _db.Vehicles.Where(v => v.AppUserId == activUser.Id && v.VehicleModelId == vehicleVM.Vehicle.VehicleModelId).ToList();
                if (AlreadyVehicle.Count() != 0)
                {
                    ModelState.AddModelError("Vehicle.CupunCode", "Use the premium version to place many vehicles of the same model and brand");
                    return View(vehicleVM);
                }
            }

            await _db.Vehicles.AddAsync(vehicleVM.Vehicle);
            await _db.VehicleFeatures.AddAsync(vehicleVM.VehicleFeatures);
            vehicleVM.Vehicle.VehicleFeaturesId = vehicleVM.VehicleFeatures.Id;

            foreach (var imgFile in vehicleVM.Vehicle.Photos)
            {
                VehicleImage vehicleImage = new VehicleImage();
                vehicleImage.Name = await imgFile.SaveFileAsync(_env.WebRootPath, "Items");
                vehicleImage.VehicleId = vehicleVM.Vehicle.Id;
                await _db.VehicleImages.AddAsync(vehicleImage);
            }

            await _db.SaveChangesAsync();

            return RedirectToAction("MyVehicle", "Account");
        }

        public async Task<IActionResult> Details(int id)
        {
            var vehicle = await _db.Vehicles.FindAsync(id);
            if (vehicle == null) return NotFound();
            //ViewBag.model = _db.VehicleModels.First(m => m.Id == vehicle.VehicleModelId);
            ViewBag.make = _db.Makes.ToList();

            //return View(vehicle);

            DetailsVM detailsVM = new DetailsVM
            {
                Vehicle = await _db.Vehicles.FindAsync(id),
                VehicleFeatures = _db.VehicleFeatures.ToList(),
                VehicleModel = _db.VehicleModels.ToList(),
                VehicleImages = _db.VehicleImages.ToList(),
                BodyTypes = _db.BodyTypes.ToList(),
                DriveTypes = _db.DriveTypes.ToList(),
                TransmissionTypes = _db.TransmissionTypes.ToList(),
                FuelTypes = _db.FuelTypes.ToList(),
                RelatedVehicles = _db.Vehicles.Where(v => v.VehicleModel.MakeId == vehicle.VehicleModel.MakeId && v.Id != vehicle.Id),
                OfferPriceMessage = new OfferPriceMessage(),
                ContactMessage = new ContactMessage(),
            };

            return View(detailsVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(OfferPriceMessage offerPriceMessage)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            //GENERAL INQUIRY
            if (offerPriceMessage.type == 0)
            {
                Vehicle vehicle = await _db.Vehicles.FindAsync(offerPriceMessage.VehicleId);
                if (vehicle == null)
                {
                    return NotFound();
                }
                AppUser user = await _userManager.FindByIdAsync(vehicle.AppUserId);
                AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
                try
                {

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("AutoClub", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2));
                    message.To.Add(new MailboxAddress("AutoClub", vehicle.Email));

                    message.Subject = "GENERAL INQUIRY";
                    message.Body = new TextPart("plain")
                    {
                        Text = $"User: {activUser.UserName} / {activUser.Email}" +
                        $"{Environment.NewLine}" +
                        $"Email: {offerPriceMessage.EmailTo}" +
                        $" {Environment.NewLine}" +
                        $"Phone: {offerPriceMessage.Phone}" +
                        $"{Environment.NewLine}" +
                        $"Message: {offerPriceMessage.Message}"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate(_db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2, _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2Password);
                        client.Send(message);
                        client.Disconnect(true);
                    }
                }
                catch
                {
                    return RedirectToAction(nameof(Details));
                }
            }
            //Offer Price
            if (offerPriceMessage.type == 1)
            {
                AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
                try
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Offer Price", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2));
                    message.To.Add(new MailboxAddress("Offer Price", offerPriceMessage.EmailTo));

                    message.Subject = "AutoClub";
                    message.Body = new TextPart("plain")
                    {
                        Text = $" Vehicle: {_db.Makes.FirstOrDefault(m => m.Id == _db.Vehicles.FirstOrDefault(v => v.Id == offerPriceMessage.VehicleId).VehicleModel.MakeId).Name}" +
                        $" {_db.VehicleModels.FirstOrDefault(v => v.Id == _db.Vehicles.FirstOrDefault(v2 => v2.Id == offerPriceMessage.VehicleId).VehicleModelId).Name}" +
                        $" {_db.Vehicles.FirstOrDefault(v => v.Id == offerPriceMessage.VehicleId).VehicleManufacturerYear}" +
                        $" {Environment.NewLine}" +
                        $" Current Price: {_db.Vehicles.FirstOrDefault(v => v.Id == offerPriceMessage.VehicleId).Price}" +
                        $" {Environment.NewLine}" +
                        $" ------------------------------" +
                        $"{Environment.NewLine}" +
                        $" Price offered: {offerPriceMessage.Message}" +
                        $" {Environment.NewLine}" +
                        $" Contact" +
                        $" {Environment.NewLine}" +
                        $" Phone: {offerPriceMessage.Phone}" +
                        $" {Environment.NewLine}" +
                        $" Email: {offerPriceMessage.EmailFrom}" +
                        $" {Environment.NewLine}" +
                        $" UserID: {activUser.Id}"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate(_db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2, _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2Password);
                        client.Send(message);
                        client.Disconnect(true);
                    }
                }
                catch
                {
                    return RedirectToAction(nameof(Details));
                }

            }

            return RedirectToAction(nameof(Details));
        }
        public IActionResult Compare()
        {
            ViewBag.make = _db.Makes.ToList();
            ViewBag.bodyType = _db.BodyTypes.ToList();
            ViewBag.transmissionTypes = _db.TransmissionTypes.ToList();
            ViewBag.driveTypes = _db.DriveTypes.ToList();
            ViewBag.fuelTypes = _db.FuelTypes.ToList();
            ViewBag.images = _db.VehicleImages.ToList();


            string compare = HttpContext.Session.GetString("compare");
            if (compare == null) return View();
            return View(JsonConvert.DeserializeObject<List<DetailsVM>>(compare));
        }
    }
}