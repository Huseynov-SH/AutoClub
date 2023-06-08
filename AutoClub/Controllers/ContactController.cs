using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoClub.DAL;
using AutoClub.Models;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using AutoClub.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace AutoClub.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        private UserManager<AppUser> userManager;
        public ContactController(AppDbContext db, UserManager<AppUser> _userManager)
        {
            _db = db;
            userManager = _userManager;
        }
        public async Task<IActionResult> Index()
        {
            AppUser activUser;
            ContactMessage contactMessage = new ContactMessage();
            ContactVM contactVM = new ContactVM
            {
                webSiteBio = _db.WebSiteBios.FirstOrDefault(wsb => wsb.Id == 1),
                contactMessage = contactMessage,
            };

            if (User.Identity.IsAuthenticated)
            {
                activUser = await userManager.FindByNameAsync(User.Identity.Name);
                contactMessage.UserName = activUser.UserName;
                contactMessage.Email = activUser.Email;
            }


            return View(contactVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactMessage contactMessage)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }
            if (!ModelState.IsValid) return View(contactMessage);

            AppUser activUser = await userManager.FindByNameAsync(User.Identity.Name);

            if (contactMessage.UserName != activUser.UserName)
            {
                ContactVM contactVM = new ContactVM
                {
                    webSiteBio = _db.WebSiteBios.FirstOrDefault(wsb => wsb.Id == 1),
                    contactMessage = contactMessage,
                };
                ModelState.AddModelError("contactMessage.UserName", "This username is not yours");
                return View(contactVM);
            }

            if (contactMessage.Type == 1)
            {
                try
                {

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("AutoClub", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2));
                    message.To.Add(new MailboxAddress("AutoClub", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email1));

                    message.Subject = "Other";
                    message.Body = new TextPart("plain")
                    {
                        Text = $"User: {contactMessage.UserName} / {activUser.Email}" +
                        $"{Environment.NewLine}" +
                        $"Email: {contactMessage.Email}" +
                        $" {Environment.NewLine}" +
                        $"Phone: {contactMessage.Phone}" +
                        $"{Environment.NewLine}" +
                        $"Message: {contactMessage.Message}"
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

            }

            if (contactMessage.Type == 2)
            {
                try
                {

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("AutoClub", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email2));
                    message.To.Add(new MailboxAddress("AutoClub", _db.WebSiteMails.FirstOrDefault(m => m.Id == 1).Email1));

                    message.Subject = "Company Application";
                    message.Body = new TextPart("plain")
                    {
                        Text = $"User: {contactMessage.UserName} / {activUser.Email}" +
                        $"{Environment.NewLine}" +
                        $"Email: {contactMessage.Email}" +
                        $" {Environment.NewLine}" +
                        $"Phone: {contactMessage.Phone}" +
                        $"{Environment.NewLine}" +
                        $" Message : {contactMessage.Message}"
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

            }


            return RedirectToAction(nameof(Index));
        }
    }
}