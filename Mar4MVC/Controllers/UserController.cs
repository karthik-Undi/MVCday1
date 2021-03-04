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
        public String Register(LoginDetails g)
        {
            dbcontext.LoginDetails.Add(g);
            dbcontext.SaveChanges();
            return g.UserName;
        }



        public ActionResult UpdatePsss()
        {
            return View();
        }
        [HttpPost]
        public String UpdatePsss(LoginDetails loginDetails)
        {
            
            LoginDetails ld = dbcontext.LoginDetails.Single(log => log.UserName == loginDetails.UserName);
            LoginDetails newlog = new LoginDetails(loginDetails.UserName, loginDetails.Password, loginDetails.Role);
            dbcontext.LoginDetails.Remove(ld);
            //dbcontext.Sql
            dbcontext.LoginDetails.Add(newlog);
            dbcontext.SaveChanges();
            return "Your old Password is "+ld.Password+" and new password is "+newlog.Password;

        }

        public ActionResult DeleteUser()
        {
            return View();
        }

        [HttpPost]
        public String DeleteUser(LoginDetails l)
        {
            LoginDetails ld = dbcontext.LoginDetails.Single(log => log.UserName == l.UserName);
            dbcontext.LoginDetails.Remove(ld);
            dbcontext.SaveChanges();
            return "User Deleted : "+ld.UserName+"\nUser Role: "+ld.Role;
        }
    }
}