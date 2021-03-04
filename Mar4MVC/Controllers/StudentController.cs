using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mar4MVC.Controllers;
using Mar4MVC.Models;
namespace Mar4MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public String Index()
        {
            return "aaaaaaaaaaaaaaaaaaaaaa";
        }
        public ActionResult viewexample()
        {
            ViewData["studentname"] = "sam";
            int[] nums = { 1, 2, 3, 4, 56, 4, 34, 5, 67, 5, 34, 45, };
            ViewData["numbers"] = nums;
            ViewBag.lol = nums;
            return View();
        }
        public ActionResult StudentDetails()
        {
            Student s1 = new Student(12, "sam", 21);
            return View(s1);
        }


    }
}