using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Extensions;
using AutoClub.Models;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static AutoClub.Utilities.Utilities;

namespace AutoClub.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private readonly IHostingEnvironment _env;
        public AccountController(AppDbContext db, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> MyVehicle()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }
            string UserName = User.Identity.Name;

            AppUser CurrentUser = await _userManager.FindByNameAsync(UserName);


            AccVehicleVM accVehicleVM = new AccVehicleVM
            {
                Vehicles = _db.Vehicles.OrderByDescending(v => v.CreateDate).Where(v => v.AppUserId == CurrentUser.Id).ToList(),
                Makes = _db.Makes.ToList(),
                VehicleModels = _db.VehicleModels.ToList(),
                VehicleImages = _db.VehicleImages.ToList(),
            };

            return View(accVehicleVM);
        }

        public async Task<IActionResult> UpdateMyVehicle(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            var vehicle = await _db.Vehicles.FindAsync(id);
            if (vehicle == null) return NotFound();

            string UserName = User.Identity.Name;

            AppUser CurrentUser = await _userManager.FindByNameAsync(UserName);


            if (vehicle.AppUserId != CurrentUser.Id)
            {
                return NotFound();
            }

            UpdateMyVehicleVM updateMyVehicleVM = new UpdateMyVehicleVM
            {
                City = vehicle.City,
                CurrentAddress = vehicle.CurrentAddress,
                Description = vehicle.Description,
                Email = vehicle.Email,
                Mileage = vehicle.Mileage,
                PhoneNumber = vehicle.PhoneNumber,
                Price = vehicle.Price,
                VideoLink = vehicle.VideoLink,
                ZipCode = vehicle.ZipCode,
            };

            return View(updateMyVehicleVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateMyVehicle(int id, UpdateMyVehicleVM updateMyVehicleVM)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            if (!ModelState.IsValid) return View(updateMyVehicleVM);

            Vehicle vehicleFromDb = await _db.Vehicles.FindAsync(id);

            vehicleFromDb.City = updateMyVehicleVM.City;
            vehicleFromDb.CurrentAddress = updateMyVehicleVM.CurrentAddress;
            vehicleFromDb.Description = updateMyVehicleVM.Description;
            vehicleFromDb.Email = updateMyVehicleVM.Email;
            vehicleFromDb.Mileage = updateMyVehicleVM.Mileage;
            vehicleFromDb.PhoneNumber = updateMyVehicleVM.PhoneNumber;
            vehicleFromDb.Price = updateMyVehicleVM.Price;
            vehicleFromDb.VideoLink = updateMyVehicleVM.VideoLink;
            vehicleFromDb.ZipCode = updateMyVehicleVM.ZipCode;
            vehicleFromDb.Blocked = true;

            await _db.SaveChangesAsync();

            return RedirectToAction("MyVehicle", "Account");
        }
        public async Task<IActionResult> MyProduct()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }
            if (!User.IsInRole("Company"))
            {
                return NotFound();
            }
            string UserName = User.Identity.Name;

            AppUser CurrentUser = await _userManager.FindByNameAsync(UserName);

            ShopVM shopVM = new ShopVM
            {
                ShopProducts = _db.ShopProducts.OrderByDescending(p => p.CreateDate).Where(p => p.AppUserId == CurrentUser.Id).ToList(),
                ShopProductAllImages = _db.ShopProductImages.ToList(),
            };
            return View(shopVM);
        }
        public async Task<IActionResult> UpdateMyProduct(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            var product = await _db.ShopProducts.FindAsync(id);
            if (product == null) return NotFound();

            string UserName = User.Identity.Name;

            AppUser CurrentUser = await _userManager.FindByNameAsync(UserName);

            if (product.AppUserId != CurrentUser.Id)
            {
                return NotFound();
            }
            UpdateMyProduct updateMyProduct = new UpdateMyProduct
            {
                Title = product.Title,
                Price = product.Price,
                Count = product.Count,
                Description = product.Description
            };

            return View(updateMyProduct);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateMyProduct(int id, UpdateMyProduct updateMyProduct)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            if (!ModelState.IsValid) return View(updateMyProduct);

            ShopProduct productFromDb = await _db.ShopProducts.FindAsync(id);

            productFromDb.Title = updateMyProduct.Title;
            productFromDb.Price = updateMyProduct.Price;
            productFromDb.Count = updateMyProduct.Count;
            productFromDb.Description = updateMyProduct.Description;
            productFromDb.Blocked = true;

            await _db.SaveChangesAsync();

            return RedirectToAction("MyProduct", "Account");
        }
        public async Task<IActionResult> FavoriteVehicle()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            string UserName = User.Identity.Name;

            AppUser CurrentUser = await _userManager.FindByNameAsync(UserName);

            AccVehicleVM accVehicleVM = new AccVehicleVM
            {
                Vehicles = _db.Vehicles.OrderByDescending(v => v.CreateDate).ToList(),
                FavoriteVehicles = _db.FavoriteVehicles.ToList(),
                Makes = _db.Makes.ToList(),
                VehicleModels = _db.VehicleModels.ToList(),
                VehicleImages = _db.VehicleImages.ToList(),
                AppUser = CurrentUser,
            };

            return View(accVehicleVM);
        }

        public async Task<IActionResult> AccountSettings()
        {
            if (!User.IsInRole("User"))
            {
                return NotFound();
            }
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(activUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AccountSettings(AppUser appUser)
        {
            if (!User.IsInRole("User"))
            {
                return NotFound();
            }
            if (!ModelState.IsValid) return View(appUser);
            AppUser activeUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (appUser.UserName != activeUser.UserName)
            {
                if (await _userManager.FindByNameAsync(appUser.UserName) != null)
                {
                    ModelState.AddModelError("UserName", "Username is already in use");
                    return View(appUser);
                }
            }

            activeUser.FirstName = appUser.FirstName;
            activeUser.LastName = appUser.LastName;
            activeUser.UserName = appUser.UserName;

            await _userManager.UpdateAsync(activeUser);
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login", "User");
        }
        public async Task<IActionResult> CompanySettings()
        {
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!User.IsInRole("Company"))
            {
                return NotFound();
            }
            return View(activUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompanySettings(AppUser appUser)
        {
            if (!User.IsInRole("Company"))
            {
                return NotFound();
            }
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (appUser.UserName != activUser.UserName)
            {
                if (await _userManager.FindByNameAsync(appUser.UserName) != null)
                {
                    ModelState.AddModelError("UserName", "Name is already in use");
                    return View(appUser);
                }
            }

            if (appUser.Photo != null)
            {
                if (appUser.Photo.IsImage())
                {
                    //Remove old image
                    RemoveFile(activUser.Image, "Users", _env.WebRootPath);

                    //Save new image
                    activUser.Image = await appUser.Photo.SaveFileAsync(_env.WebRootPath, "Users");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Photo is invalid");
                    return View(appUser);
                }
            }

            activUser.FirstName = appUser.FirstName;
            activUser.UserName = appUser.UserName;
            activUser.Description = appUser.Description;
            activUser.Phone = appUser.Phone;
            activUser.FacebookLink = appUser.FacebookLink;
            activUser.InstagramLink = appUser.InstagramLink;
            activUser.Location = appUser.Location;

            await _userManager.UpdateAsync(activUser);
            return RedirectToAction(nameof(CompanySettings));
        }
    }
}