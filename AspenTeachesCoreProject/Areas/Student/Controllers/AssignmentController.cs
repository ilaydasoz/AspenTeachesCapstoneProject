using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AspenTeachesCoreProject.Areas.Student.Controllers
{
    [Area("Student")]
    public class AssignmentController : Controller
    {
        AssignmentManager assignmentManager = new AssignmentManager(new EfAssignmentDal());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAssignment()
        {
            var values = JsonConvert.SerializeObject(assignmentManager.TGetList()); //listeleme islemlerinde serialize kullanilir.
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Assignment p)
        {
            assignmentManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        public IActionResult GetById(int ExperienceID)
        {
            var experience = assignmentManager.TGetByID(ExperienceID);
            var values = JsonConvert.SerializeObject(experience);
            return Json(values);
        }

        public IActionResult DeleteExperience(int id)
        {
            var v = assignmentManager.TGetByID(id);
            assignmentManager.TDelete(v);
            return NoContent();
        }

        public IActionResult UpdateExperince(Assignment p)
        {
            var v = assignmentManager.TGetByID(p.AssignmentID);
            assignmentManager.TUpdate(v);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}
