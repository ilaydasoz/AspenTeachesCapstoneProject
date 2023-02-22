using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspenTeachesCoreProject.Areas.Student.Controllers
{
    [Area("Student")]
    public class ProjectController : Controller
    {
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = projectManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProject(Project p)
        {   
            projectManager.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProject(int id)
        {
            var values = projectManager.TGetByID(id);
            projectManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditProject(int id)
        {
            var values = projectManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditProject(Project p)
        {
            projectManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
