using System;
using Microsoft.AspNetCore.Mvc;

namespace AspenTeachesCoreProject.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
