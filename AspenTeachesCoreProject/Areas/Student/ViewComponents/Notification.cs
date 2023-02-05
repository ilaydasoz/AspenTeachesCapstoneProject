using System;
using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspenTeachesCoreProject.Areas.Student.ViewComponents
{
    public class Notification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
