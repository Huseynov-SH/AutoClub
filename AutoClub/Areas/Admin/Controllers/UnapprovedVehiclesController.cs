using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using static AutoClub.Utilities.Utilities;
using Microsoft.AspNetCore.Identity;
using AutoClub.Models;

namespace AutoClub.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Member")]
    public class UnapprovedVehiclesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        public UnapprovedVehiclesController(AppDbContext db, IHostingEnvironment env, UserManager<AppUser> userManager)
        {
            _db = db;
            _env = env;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Vehicles = _db.Vehicles.OrderByDescending(v => v.CreateDate).Where(v => v.Blocked == true),
                VehicleImages = _db.VehicleImages.ToList(),
            };
            return View(homeVM);
        }

        public async Task<IActionResult> Details(int id)
        {
            var vehicle = await _db.Vehicles.FindAsync(id);

            if (vehicle == null)
            {
                return NotFound();
            }

            DetailsVM detailsVM = new DetailsVM
            {
                Vehicle = vehicle,
                VehicleImages = _db.VehicleImages.ToList(),
            };
            return View(detailsVM);
        }

        public async Task<IActionResult> Confirm(int id)
        {
            var vehicle = await _db.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            vehicle.Blocked = false;
            await _db.SaveChangesAsync();

            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            //Send email
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("AutoClub", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2));
                message.To.Add(new MailboxAddress("AutoClub", _db.Vehicles.FirstOrDefault(v => v.Id == id).Email));

                message.Subject = "AutoClub";
                message.Body = new TextPart("plain")
                {
                    Text = $" Vehicle: {_db.Makes.FirstOrDefault(m => m.Id == _db.Vehicles.FirstOrDefault(v => v.Id == id).VehicleModel.MakeId).Name}" +
                    $" {_db.VehicleModels.FirstOrDefault(v => v.Id == _db.Vehicles.FirstOrDefault(v2 => v2.Id == id).VehicleModelId).Name}" +
                    $" {_db.Vehicles.FirstOrDefault(v => v.Id == id).VehicleManufacturerYear}" +
                    $" {Environment.NewLine}" +
                    $" Your vehicle is approved" +
                    $"{Environment.NewLine}" +
                    $" ------------------------------" +
                    $"{Environment.NewLine}" +
                    $" Contact:" +
                    $"{Environment.NewLine}" +
                    $"{activUser.FirstName} {activUser.LastName}" +
                    $"{Environment.NewLine}" +
                    $"{activUser.Email} / {activUser.Phone}"
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
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var vehicle = await _db.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            foreach (var image in _db.VehicleImages.Where(img => img.VehicleId == vehicle.Id))
            {
                RemoveFile(image.Name, "Items", _env.WebRootPath);
            }


            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            //Send Email
            try
            {
                var deleteMessage = new MimeMessage();
                deleteMessage.From.Add(new MailboxAddress("AutoClub", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2));
                deleteMessage.To.Add(new MailboxAddress("AutoClub", vehicle.Email));

                deleteMessage.Subject = "AutoClub";
                deleteMessage.Body = new TextPart("plain")
                {
                    Text = $" Vehicle: {_db.Makes.FirstOrDefault(m => m.Id == _db.Vehicles.FirstOrDefault(v => v.Id == id).VehicleModel.MakeId).Name}" +
                    $" {_db.VehicleModels.FirstOrDefault(v => v.Id == _db.Vehicles.FirstOrDefault(v2 => v2.Id == id).VehicleModelId).Name}" +
                    $" {_db.Vehicles.FirstOrDefault(v => v.Id == id).VehicleManufacturerYear}" +
                    $" {Environment.NewLine}" +
                    $" Your vehicle is not approved! Check the accuracy of the data and try again" +
                    $"{Environment.NewLine}" +
                    $" ------------------------------" +
                    $"{Environment.NewLine}" +
                    $"Contact:" +
                    $"{Environment.NewLine}" +
                    $"{activUser.FirstName} {activUser.LastName}" +
                    $"{Environment.NewLine}" +
                    $"{activUser.Email} / {activUser.Phone}"
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate(_db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2, _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2Password);
                    client.Send(deleteMessage);
                    client.Disconnect(true);
                }
            }
            catch
            {

            }

            _db.Vehicles.Remove(vehicle);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}