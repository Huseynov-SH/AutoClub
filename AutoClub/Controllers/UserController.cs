using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.Models;
using AutoClub.Role;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using AutoClub.DAL;

namespace AutoClub.Controllers
{
    public class UserController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;
        private RoleManager<IdentityRole> roleManager;
        private readonly AppDbContext _db;
        public UserController(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager, RoleManager<IdentityRole> _roleManager, AppDbContext db)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
            _db = db;
        }

        public async Task RoleSeed()
        {
            if (!await roleManager.RoleExistsAsync(UserRole.Roles.Admin.ToString()))
                await roleManager.CreateAsync(new IdentityRole(UserRole.Roles.Admin.ToString()));
            if (!await roleManager.RoleExistsAsync(UserRole.Roles.Member.ToString()))
                await roleManager.CreateAsync(new IdentityRole(UserRole.Roles.Member.ToString()));
            if (!await roleManager.RoleExistsAsync(UserRole.Roles.Company.ToString()))
                await roleManager.CreateAsync(new IdentityRole(UserRole.Roles.Company.ToString()));
            if (!await roleManager.RoleExistsAsync(UserRole.Roles.User.ToString()))
                await roleManager.CreateAsync(new IdentityRole(UserRole.Roles.User.ToString()));
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginUser)
        {
            if (!ModelState.IsValid) return View(loginUser);
            AppUser user = await userManager.FindByEmailAsync(loginUser.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Email or password incorrect");
                return View(loginUser);
            }
            if (!user.EmailConfirmed)
            {
                ModelState.AddModelError("", "You need to verify your mail in order to log in. Check your mail to verify your account");
                return View(loginUser);
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await signInManager.PasswordSignInAsync(user, loginUser.Password, loginUser.RememberMe, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password incorrect");
                return View(loginUser);
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View(register);

            AppUser appUser = new AppUser
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                UserName = register.Username,
                Email = register.Email,
            };

            IdentityResult identityResult = await userManager.CreateAsync(appUser, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            if (identityResult.Succeeded)
            {
                string ctoken = userManager.GenerateEmailConfirmationTokenAsync(appUser).Result;
                string ctokenlink = Url.Action("ConfirmEmail", "User", new
                {
                    userId = appUser.Id,
                    token = ctoken
                }, protocol: HttpContext.Request.Scheme);

                try
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Email Confirmation", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2));
                    message.To.Add(new MailboxAddress("Email Confirmation", appUser.Email));

                    message.Subject = "AutoClub";
                    message.Body = new TextPart("plain")
                    {
                        Text = $"Click the link to verify your account:" +
                        $" {Environment.NewLine}" +
                        $" {ctokenlink}"
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

                }
            }
            await userManager.AddToRoleAsync(appUser, UserRole.Roles.User.ToString());
            //await signInManager.SignInAsync(appUser, true);

            return RedirectToAction("Login", "User");
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return NotFound();
            }
            AppUser user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            var result = await userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                ViewBag.confirm = true;
            }
            else
            {
                ViewBag.confirm = false;
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}