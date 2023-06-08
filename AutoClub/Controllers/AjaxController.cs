using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Models;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using static AutoClub.Utilities.Utilities;

namespace AutoClub.Controllers
{
    public class AjaxController : Controller
    {
        private AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public AjaxController(AppDbContext db, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _db = db;
            _userManager = userManager;
            _env = env;
        }
        public JsonResult ModelFilterByMake(int id)
        {
            List<VehicleModel> modellist = new List<VehicleModel>();
            modellist = _db.VehicleModels.Where(m => m.Make.Id == id).OrderBy(m => m.Name).ToList();

            modellist.Insert(0, new VehicleModel { Id = 0, Name = "Select a Model" });

            return Json(new SelectList(modellist, "Id", "Name"));
        }

        public JsonResult SubCategoryFilterByCategory(int id)
        {
            List<ShopSubCategory> subcategorielist = new List<ShopSubCategory>();
            subcategorielist = _db.ShopSubCategories.Where(sc => sc.ShopCategory.Id == id).OrderByDescending(m => m.Name).ToList();

            subcategorielist.Insert(0, new ShopSubCategory { Id = 0, Name = "Select a SubCategory" });
            return Json(new SelectList(subcategorielist, "Id", "Name"));
        }

        public async Task<IActionResult> AddCompare(int id)
        {
            string UserName = User.Identity.Name;

            Vehicle vehicle = await _db.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            List<DetailsVM> comparelist;
            string currentCompare = HttpContext.Session.GetString("compare");

            if (currentCompare == null)
            {
                comparelist = new List<DetailsVM>();
            }
            else
            {
                comparelist = JsonConvert.DeserializeObject<List<DetailsVM>>(currentCompare);
            }

            if (comparelist.FirstOrDefault(cl => cl.Vehicle.Id == id) == null)
            {
                DetailsVM detailsVM = new DetailsVM
                {
                    Vehicle = vehicle,
                    //Make = _db.Makes.ToList(),
                    VehicleModel = _db.VehicleModels.ToList(),
                    BodyTypes = _db.BodyTypes.ToList(),
                    DriveTypes = _db.DriveTypes.ToList(),
                    FuelTypes = _db.FuelTypes.ToList(),
                    TransmissionTypes = _db.TransmissionTypes.ToList(),
                    //VehicleImages = _db.VehicleImages.ToList(),
                };
                if (comparelist.Count() < 3)
                {
                    comparelist.Add(detailsVM);
                }
                else
                {
                    return Ok(new
                    {
                        status = 420,
                        message = "You have already added 3 vehicles",
                        data = "",
                    });
                }

            }
            else
            {
                return Ok(new
                {
                    status = 410,
                    message = "Already added",
                    data = "",
                });
            }

            string compare = JsonConvert.SerializeObject(comparelist);

            HttpContext.Session.SetString("compare", compare);

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public IActionResult RemoveCompare(int id)
        {
            string currentCompare = HttpContext.Session.GetString("compare");

            List<DetailsVM> comparelist = new List<DetailsVM>();

            if (currentCompare != null)
            {
                comparelist = JsonConvert.DeserializeObject<List<DetailsVM>>(currentCompare);
            }

            DetailsVM detailsVM = comparelist.FirstOrDefault(dvm => dvm.Vehicle.Id == id);
            comparelist.Remove(detailsVM);

            string compare = JsonConvert.SerializeObject(comparelist);

            HttpContext.Session.SetString("compare", compare);

            return RedirectToAction("Compare", "Vehicle");
        }

        public async Task<IActionResult> AddFavoriteVehicle(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Ok(new
                {
                    status = 444,
                    message = "Already added",
                    data = "",
                });
            }
            if (!User.IsInRole("User") && !User.IsInRole("Company"))
            {
                return NotFound();
            }

            Vehicle vehicle = await _db.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (_db.FavoriteVehicles.FirstOrDefault(fv => fv.VehicleId == id && fv.UserId == activUser.Id) != null)
            {
                return Ok(new
                {
                    status = 430,
                    message = "Already added",
                    data = "",
                });
            };

            FavoriteVehicle favoriteVehicle = new FavoriteVehicle();
            favoriteVehicle.UserId = activUser.Id;
            favoriteVehicle.VehicleId = id;

            await _db.FavoriteVehicles.AddAsync(favoriteVehicle);
            await _db.SaveChangesAsync();

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> RemoveFavorite(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            FavoriteVehicle favoritevehicle = await _db.FavoriteVehicles.FindAsync(id);
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (favoritevehicle == null)
            {
                return NotFound();
            }
            if (favoritevehicle.UserId != activUser.Id)
            {
                return NotFound();
            }

            _db.FavoriteVehicles.Remove(favoritevehicle);
            await _db.SaveChangesAsync();

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> RemoveMyVehicle(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            Vehicle vehicle = await _db.Vehicles.FindAsync(id);
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (vehicle == null)
            {
                return NotFound();
            }
            if (vehicle.AppUserId != activUser.Id)
            {
                return NotFound();
            }
            foreach (var image in _db.VehicleImages.Where(img => img.VehicleId == vehicle.Id))
            {
                RemoveFile(image.Name, "Items", _env.WebRootPath);
            }
            _db.Vehicles.Remove(vehicle);
            await _db.SaveChangesAsync();

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> RemoveMyProduct(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            ShopProduct product = await _db.ShopProducts.FindAsync(id);
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (product == null)
            {
                return NotFound();
            }
            if (product.AppUserId != activUser.Id)
            {
                return NotFound();
            }
            foreach (var image in _db.ShopProductImages.Where(img => img.ShopProductId == product.Id))
            {
                RemoveFile(image.Name, "Shop", _env.WebRootPath);
            }
            _db.ShopProducts.Remove(product);
            await _db.SaveChangesAsync();

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> AddBasket(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Ok(new
                {
                    status = 422,
                    message = "",
                    data = "",
                });
            }
            ShopProduct product = await _db.ShopProducts.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            List<BasketVM> productlist;
            string currentBasket = HttpContext.Session.GetString("basket");
            if (currentBasket == null)
            {
                productlist = new List<BasketVM>();
            }
            else
            {
                productlist = JsonConvert.DeserializeObject<List<BasketVM>>(currentBasket);
            }

            if (productlist.FirstOrDefault(p => p.ShopProduct.Id == id) == null)
            {
                BasketVM basketVM = new BasketVM
                {
                    ShopProduct = product,
                    Quantity = 1,
                };
                productlist.Add(basketVM);
            }
            else
            {
                if (productlist.FirstOrDefault(p => p.ShopProduct.Id == id).Quantity >= _db.ShopProducts.FirstOrDefault(p => p.Id == id).Count)
                {
                    return Ok(new
                    {
                        status = 421,
                        message = "",
                        data = "",
                    });
                }
                productlist.FirstOrDefault(p => p.ShopProduct.Id == id).Quantity += 1;
            }
            string basket = JsonConvert.SerializeObject(productlist);
            HttpContext.Session.SetString("basket", basket);

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public IActionResult RemoveBasket(int id)
        {
            string currentBasket = HttpContext.Session.GetString("basket");

            List<BasketVM> productlist = new List<BasketVM>();
            if (currentBasket != null)
            {
                productlist = JsonConvert.DeserializeObject<List<BasketVM>>(currentBasket);
            }

            BasketVM basketVM = productlist.FirstOrDefault(bvm => bvm.ShopProduct.Id == id);
            productlist.Remove(basketVM);
            string basket = JsonConvert.SerializeObject(productlist);
            HttpContext.Session.SetString("basket", basket);

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }
    }
}