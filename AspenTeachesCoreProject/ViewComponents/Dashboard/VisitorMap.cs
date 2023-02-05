using System;
using Microsoft.AspNetCore.Mvc;

namespace AspenTeachesCoreProject.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
