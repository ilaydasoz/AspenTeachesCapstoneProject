using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspenTeachesCoreProject.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
    }
}
