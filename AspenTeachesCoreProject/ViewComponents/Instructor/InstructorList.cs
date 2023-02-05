using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspenTeachesCoreProject.ViewComponents.Instructor
{
    public class InstructorList : ViewComponent
    {
        InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());

        public IViewComponentResult Invoke()
        {
            var values = instructorManager.TGetList();
            return View(values);
        }
    }
}
