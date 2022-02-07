using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace IntroMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                string connString = "";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string query = "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                //database operation
                return RedirectToAction("List","Person");
            }
            return View(s);
        }
        [HttpPost]
        public ActionResult Submit(Student s)
        {
            /*Student s = new Student();
            s.Name = Request["Name"];
            s.Id = Request["Id"];
            s.Dob = Request["Dob"];
            s.Email = Request["Email"];*/
            /*Student s = new Student();
            s.Name = form["Name"];
            s.Id = form["Id"];
            s.Dob = form["Dob"];
            s.Email = form["Email"];*/
            /*Student s = new Student();
            s.Name = Name;
            s.Id = Id;
            s.Dob = Dob;
            s.Email = Email;*/

            return View(s);
        }
        
        public ActionResult List() 
        {
            return View();
        }

    }
}