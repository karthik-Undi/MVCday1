using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mar4MVC.Controllers;
using Mar4MVC.Models;

namespace Mar4MVC.Controllers
{
    public class LoginController : Controller
    {
        ReleaseMgmtContext dbcontext = new ReleaseMgmtContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Loginpage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Loginpage(LoginDetails l)
        {
            LoginDetails ld=l;
            try 
            {
            ld = dbcontext.LoginDetails.Single(log => (log.UserName == l.UserName) && (log.Password == l.Password));
                ViewBag.flag = true;
            }
            catch(System.InvalidOperationException)
            {
                ViewBag.wrong = true;
            
            }
           
            ViewBag.Name = ld.UserName;
            ViewBag.Role = ld.Role;


            return View();
        }
        public ActionResult updaterole()
        {
            return View();

        }
        [HttpPost]
        public ActionResult updaterole(LoginDetails loginDetails)
        {
            try
            {
                LoginDetails ld = dbcontext.LoginDetails.FirstOrDefault(log => log.UserName == loginDetails.UserName);
                ld.Role = loginDetails.Role;
                dbcontext.SaveChanges();
                ViewBag.succ = true;
            }
            catch
            {
                ViewBag.flag = true;
            }

            return View();

        }


    }
}