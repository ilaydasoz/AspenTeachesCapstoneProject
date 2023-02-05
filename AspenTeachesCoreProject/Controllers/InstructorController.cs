using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace AspenTeachesCoreProject.Controllers
{
    public class InstructorController : Controller
    {
        InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());

        public IActionResult Index()
        {
            var values = instructorManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor p)
        {
            instructorManager.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteInstructor(int id)
        {
            var values = instructorManager.TGetByID(id);
            instructorManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            var values = instructorManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditInstructor(Instructor p)
        {
            instructorManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
