using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace AspenTeachesCoreProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUser appUser)
        {
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, false, false);

            //EmailConfirmed appUser'dan geliyor.
            if (result.Succeeded && appUser.UserName == "eceaksu"/*&& appUser.EmailConfirmed == true*/ )
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Student" });
            }
            else
            {
                return RedirectToAction("Index", "InstructorDashboard", new { area = "Instructor" });
            }
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Default");
        }
    }
}
