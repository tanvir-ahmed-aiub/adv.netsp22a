﻿using Assoc.Auth;
using Assoc.Models.Database;
using Assoc.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Assoc.Controllers
{
    
    public class HomeController : Controller
    {
        [Authorize]
        //[AllowAnonymous]
        public ActionResult Index()
        {
            
            UMS_Sp22_AEntities db = new UMS_Sp22_AEntities();
            var dept = (from d in db.Departments where d.Id == 1 select d).FirstOrDefault();
            DepartmentModel de = new DepartmentModel();
            de.Name = dept.Name;
            de.Id = dept.Id;
            return View(dept);
        }
        [HttpGet]
        public ActionResult Login() {
            if (User.Identity.IsAuthenticated) { return RedirectToAction("Index"); }
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            UMS_Sp22_AEntities db = new UMS_Sp22_AEntities();
            var data = (from e in db.Users
                        where e.Password.Equals(user.Password) &&
                        e.Username.Equals(user.Username)
                        select e).FirstOrDefault();
            if (data != null) {
                FormsAuthentication.SetAuthCookie(data.Username, false);
                Session["role"] = data.Role;
                return RedirectToAction("Index");
            }

            TempData["msg"] = "Invalid Crdentials";
            return RedirectToAction("Login");
        }
        public ActionResult Logout() {

            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AdminAccess]
        public ActionResult UserList() {

            UMS_Sp22_AEntities db = new UMS_Sp22_AEntities();
            return View(db.Users.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}