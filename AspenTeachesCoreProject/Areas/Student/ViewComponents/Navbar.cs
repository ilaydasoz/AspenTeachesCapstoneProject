using System;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspenTeachesCoreProject.Areas.Student.ViewComponents
{
    public class Navbar : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public Navbar(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.v = values.Image;
            return View();
        }
    }
}
