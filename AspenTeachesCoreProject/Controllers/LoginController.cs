using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
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
        private readonly UserManager<AppUser> _userManager;
        private readonly IAppUserService _userService;
        private readonly IRoleService _roleService;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IRoleService roleService, IAppUserService userService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleService = roleService;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Index(AppUser appUser)
        {
            var user = await _userManager.FindByNameAsync(appUser.UserName);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user.UserName, appUser.PasswordHash, false, true);
                int roleId = _roleService.TGetLoggedUserRoleId(user.Id);

                if (result.Succeeded && user.EmailConfirmed && roleId == 1)
                {
                    return RedirectToAction("Index", "Dashboard", new { area = "Student" });
                }
                else if (roleId == 2)
                {
                    return RedirectToAction("Index", "InstructorDashboard", new { area = "Instructor" });
                }
                else if (roleId == 3)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return RedirectToAction("401", "Error");
                }
            }
            else
            {
                return RedirectToAction("404", "Error");
            }
        }




        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Default");
        }
    }
}
