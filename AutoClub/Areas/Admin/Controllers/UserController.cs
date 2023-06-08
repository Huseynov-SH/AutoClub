using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Models;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using static AutoClub.Utilities.Utilities;

namespace AutoClub.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;

        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> MakeUser(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user == null) return NotFound();

            await _userManager.RemoveFromRoleAsync(user, "Member");
            await _userManager.AddToRoleAsync(user, "User");

            if (user.Image != null)
            {
                //Remove  image
                RemoveFile(user.Image, "Users", _env.WebRootPath);
                user.Image = null;

            }
            user.Section = null;
            user.Location = null;
            user.Phone = null;
            user.FacebookLink = null;
            user.InstagramLink = null;
            user.TwitterLink = null;
            user.LinkedinLink = null;
            user.Description = null;

            await _userManager.UpdateAsync(user);

            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user.Id == activUser.Id)
            {
                await _signInManager.SignOutAsync();
            }

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> UMakeUser(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user == null) return NotFound();

            await _userManager.RemoveFromRoleAsync(user, "Admin");
            await _userManager.AddToRoleAsync(user, "User");
            if (user.Image != null)
            {
                //Remove  image
                RemoveFile(user.Image, "Users", _env.WebRootPath);
                user.Image = null;
            }
            user.Section = null;
            user.Location = null;
            user.Phone = null;
            user.FacebookLink = null;
            user.InstagramLink = null;
            user.TwitterLink = null;
            user.LinkedinLink = null;
            user.Description = null;
            await _userManager.UpdateAsync(user);

            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user.Id == activUser.Id)
            {
                await _signInManager.SignOutAsync();
            }

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> Users()
        {
            IList<AppUser> users = await _userManager.GetUsersInRoleAsync("User");
            return View(users);
        }

        public async Task<IActionResult> UserVehicles(string id)
        {
            AppUser appUser = await _userManager.FindByIdAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }
            AccVehicleVM accVehicleVM = new AccVehicleVM
            {
                Vehicles = _db.Vehicles.Where(v => v.AppUserId == id),
                VehicleImages = _db.VehicleImages.ToList(),
                Makes = _db.Makes.ToList(),
                VehicleModels = _db.VehicleModels.ToList(),
            };
            return View(accVehicleVM);
        }

        public async Task<IActionResult> UserVehicleDetails(int id)
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

        public async Task<IActionResult> Company()
        {
            IList<AppUser> users = await _userManager.GetUsersInRoleAsync("Company");
            return View(users);
        }

        public async Task<IActionResult> MakeCompany(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user == null) return NotFound();

            await _userManager.RemoveFromRoleAsync(user, "User");
            await _userManager.AddToRoleAsync(user, "Company");
            user.Image = "test.jpg";
            await _userManager.UpdateAsync(user);

            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user.Id == activUser.Id)
            {
                await _signInManager.SignOutAsync();
            }
            //Send Email
            try
            {
                var deleteMessage = new MimeMessage();
                deleteMessage.From.Add(new MailboxAddress("AutoClub", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2));
                deleteMessage.To.Add(new MailboxAddress("AutoClub", user.Email));

                deleteMessage.Subject = "AutoClub";
                deleteMessage.Body = new TextPart("plain")
                {
                    Text = $"Your company account has been accepted in AutoClub! {Environment.NewLine} You can now sell your own products"
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

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> CompanyDetails(string id)
        {
            AppUser appUser = await _userManager.FindByIdAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }
            return View(appUser);
        }

        public async Task<IActionResult> DeleteCompany(string id)
        {
            AppUser company = await _userManager.FindByIdAsync(id);

            if (company == null) return NotFound();

            //Company products remove
            foreach (var product in _db.ShopProducts.Where(v => v.AppUserId == company.Id))
            {
                foreach (var productImage in _db.ShopProductImages.Where(pi => pi.ShopProductId == product.Id))
                {
                    //Company product image remove
                    RemoveFile(productImage.Name, "Shop", _env.WebRootPath);
                }
                _db.ShopProducts.Remove(product);
            }

            //Company Logo remove
            if (company.Image != null)
            {
                //User  image remove
                RemoveFile(company.Image, "Users", _env.WebRootPath);
            }

            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);

            try
            {
                var deleteMessage = new MimeMessage();
                deleteMessage.From.Add(new MailboxAddress("AutoClub", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2));
                deleteMessage.To.Add(new MailboxAddress("AutoClub", company.Email));

                deleteMessage.Subject = "AutoClub";
                deleteMessage.Body = new TextPart("plain")
                {
                    Text = $"Your company account in AutoClub has been removed"
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

            await _userManager.DeleteAsync(company);
            await _db.SaveChangesAsync();

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> MakeMember(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user == null) return NotFound();

            await _userManager.RemoveFromRoleAsync(user, "User");
            await _userManager.AddToRoleAsync(user, "Member");

            await _userManager.UpdateAsync(user);

            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user.Id == activUser.Id)
            {
                await _signInManager.SignOutAsync();
            }

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> UMakeMember(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user == null) return NotFound();

            await _userManager.RemoveFromRoleAsync(user, "Admin");
            await _userManager.AddToRoleAsync(user, "Member");

            if (user.Image != null)
            {
                //Remove  image
                RemoveFile(user.Image, "Users", _env.WebRootPath);
                user.Image = null;
            }
            await _userManager.UpdateAsync(user);

            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user.Id == activUser.Id)
            {
                await _signInManager.SignOutAsync();
            }

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> Members()
        {
            IList<AppUser> users = await _userManager.GetUsersInRoleAsync("Member");
            return View(users);
        }

        public async Task<IActionResult> MemberDetails(string id)
        {
            AppUser appUser = await _userManager.FindByIdAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }
            return View(appUser);
        }

        public async Task<IActionResult> MakeAdmin(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user == null) return NotFound();

            await _userManager.RemoveFromRoleAsync(user, "Member");
            await _userManager.AddToRoleAsync(user, "Admin");

            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user.Id == activUser.Id)
            {
                await _signInManager.SignOutAsync();
            }

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> Admin()
        {
            IList<AppUser> users = await _userManager.GetUsersInRoleAsync("Admin");
            return View(users);
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user == null) return NotFound();

            //User vehicles remove
            foreach (var vehicle in _db.Vehicles.Where(v => v.AppUserId == user.Id))
            {
                foreach (var vehicleImage in _db.VehicleImages.Where(vi => vi.VehicleId == vehicle.Id))
                {
                    //User Vehicles image remove
                    RemoveFile(vehicleImage.Name, "Items", _env.WebRootPath);
                }
                _db.Vehicles.Remove(vehicle);
            }
            //User Image remove
            if (user.Image != null)
            {
                //User  image remove
                RemoveFile(user.Image, "Users", _env.WebRootPath);
            }

            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            //Send Email
            try
            {
                var deleteMessage = new MimeMessage();
                deleteMessage.From.Add(new MailboxAddress("AutoClub", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2));
                deleteMessage.To.Add(new MailboxAddress("AutoClub", user.Email));

                deleteMessage.Subject = "AutoClub";
                deleteMessage.Body = new TextPart("plain")
                {
                    Text = $"Your AutoClub Account has been removed"
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

            if (user.Id == activUser.Id)
            {
                await _signInManager.SignOutAsync();
            }

            await _userManager.DeleteAsync(user);
            await _db.SaveChangesAsync();

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> ConfirmYourAdmin(string[] emailorpassword)
        {
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!User.IsInRole("Admin"))
            {
                return Ok(new
                {
                    status = 400,
                    message = "",
                    data = "",
                });
            }

            if (activUser.Email != emailorpassword[0])
            {
                return Ok(new
                {
                    status = 400,
                    message = "",
                    data = "",
                });
            }

            if (_userManager.PasswordHasher.VerifyHashedPassword(activUser, activUser.PasswordHash, emailorpassword[1]) == PasswordVerificationResult.Failed)
            {
                return Ok(new
                {
                    status = 400,
                    message = "",
                    data = "",
                });
            }

            return Ok(new
            {
                status = 200,
                message = "",
                data = "",
            });
        }

        public async Task<IActionResult> ConfirmUserAdmin(string id, string[] emailandpassword)
        {
            AppUser activUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!User.IsInRole("Admin"))
            {
                return Ok(new
                {
                    status = 400,
                    message = "",
                    data = "",
                });
            }
            AppUser makeMemberUser = await _userManager.FindByIdAsync(id);

            if (makeMemberUser.Email != emailandpassword[0])
            {
                return Ok(new
                {
                    status = 400,
                    message = "",
                    data = "",
                });
            }

            if (_userManager.PasswordHasher.VerifyHashedPassword(makeMemberUser, makeMemberUser.PasswordHash, emailandpassword[1]) == PasswordVerificationResult.Failed)
            {
                return Ok(new
                {
                    status = 400,
                    message = "",
                    data = "",
                });
            }

            return Ok(new
            {
                status = 200,
                message = "",
                data = id,
            });
        }
    }
}