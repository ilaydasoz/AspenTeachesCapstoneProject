using System;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AspenTeachesCoreProject.Controllers
{
    public class CourseController : Controller
    {
        CourseManager courseManager = new CourseManager(new EfCourseDal());

        public IActionResult Index()
        {
            var values = courseManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(Course p)
        {
            CourseValidator validations = new CourseValidator();
            ValidationResult results = validations.Validate(p);

            if (results.IsValid)
            {
                courseManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteCourse(int id)
        {
            var values = courseManager.TGetByID(id);
            courseManager.TDelete(values);
            return RedirectToAction("Index");
        }

        public IActionResult EditPortfolio(int id)
        {
            var values = courseManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditCourse(Course p)
        {
            CourseValidator validations = new CourseValidator();
            ValidationResult results = validations.Validate(p);

            if (results.IsValid)
            {
                courseManager.TUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
