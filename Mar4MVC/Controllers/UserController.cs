using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mar4MVC.Models;

namespace Mar4MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        ReleaseMgmtContext dbcontext = new ReleaseMgmtContext();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(LoginDetails g)
        {
            dbcontext.LoginDetails.Add(g);
            try
            {
                dbcontext.SaveChanges();
                ViewBag.succ = true;
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                ViewBag.flag = true;
            }
            return View();
        }



        public ActionResult UpdatePsss()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdatePsss(LoginDetails loginDetails)
        {
            try
            {
LoginDetails ld = dbcontext.LoginDetails.FirstOrDefault(log => log.UserName == loginDetails.UserName);
            ld.Password = loginDetails.Password;
            dbcontext.SaveChanges();
                ViewBag.succ = true;
            }
            catch
            {
                ViewBag.flag = true;
            }
            
            return View();

        }

        public ActionResult DeleteUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteUser(LoginDetails l)
        {
            LoginDetails ld = l;
            try
            {
                ld = dbcontext.LoginDetails.Single(log => log.UserName == l.UserName);
                dbcontext.LoginDetails.Remove(ld);
            dbcontext.SaveChanges();
            ViewBag.Name = ld.UserName;
            ViewBag.Role = ld.Role;
                ViewBag.succ = true;

            }
            catch(System.InvalidOperationException)
            {
                ViewBag.flag = true;
            }
            
            
            return View();
            //return "User Deleted : "++"\nUser Role: "+ld.Role;
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginDetails l)
        {
            LoginDetails ld = dbcontext.LoginDetails.Single(log => (log.UserName == l.UserName)&&(log.Password==l.Password));


            return RedirectToAction("Index", l);
        }



    }
}