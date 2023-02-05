using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AspenTeachesCoreProject.ViewComponents.Course
{
    public class CourseList : ViewComponent
    {
        CourseManager courseManager = new CourseManager(new EfCourseDal());

        public IViewComponentResult Invoke()
        {
            var values = courseManager.TGetList();
            return View(values);
        }

    }
}
