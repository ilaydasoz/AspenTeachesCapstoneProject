using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AspenTeachesCoreProject.Areas.Instructor.Controllers
{
    [Area("Instructor")]
    [Route("Instructor/InstructorAssignment")]
    public class InstructorAssignmentController : Controller
    {
        AssignmentManager assignmentManager = new AssignmentManager(new EfAssignmentDal());

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InstructorAddAssignment(Assignment p)
        {
            assignmentManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

       /* public IActionResult InstructorUpdateAssignment(Assignment p)
        {
            var v = assignmentManager.TGetByID(p.AssignmentID);
            assignmentManager.TUpdate(v);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }*/

    }
}
