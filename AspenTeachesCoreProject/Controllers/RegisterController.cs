using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspenTeachesCoreProject.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace AspenTeachesCoreProject.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IAppUserService _appUserService;

        public RegisterController(UserManager<AppUser> userManager, IAppUserService appUserService)
        {
            _userManager = userManager;
            _appUserService = appUserService;
        }

        //Email confirmation
        [HttpGet]
        public IActionResult EmailConfirmPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EmailConfirmPage(AppUser appUser)
        {
            var user = await _userManager.FindByEmailAsync(appUser.Email);
            if (user.EmailConfirmationCode == appUser.EmailConfirmationCode)
            {
                user.EmailConfirmed = true;

                var result = await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }

        public void SendEmail(string emailAddress, string emailcode)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Aspen Teaches", "iloschi69126@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom); 

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", emailAddress);
            mimeMessage.To.Add(mailboxAddressTo); 

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Your confirmation code is: " + emailcode;
            mimeMessage.Body = bodyBuilder.ToMessageBody(); 

            mimeMessage.Subject = "Aspen Teaches - Confirm Your E-Mail"; 

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("iloschi69126@gmail.com", "wglnavvzurehgazx");
            client.Send(mimeMessage);
            client.Disconnect(true);
        }

        //Registration
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserSignUpModel userSignUp)
        {
            Random rnd = new Random();
            string code = rnd.Next(10000, 999999).ToString();

            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = userSignUp.Username,
                    Name = userSignUp.Name,
                    Surname = userSignUp.Surname,
                    Email = userSignUp.Email,
                    EmailConfirmationCode = code
                };

                if (userSignUp.Password == userSignUp.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(appUser, userSignUp.Password);

                    if (result.Succeeded)
                    {
                        SendEmail(userSignUp.Email, code);
                        return RedirectToAction("EmailConfirmPage", "Register");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
            }

            return View();
        }
    }
}
