using _2._1._2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2._1._2023.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Student()
        {
            List<Models.Student> s = new List<Models.Student>();
             s.Add( new Student() { Name = "reem", Id = 32 , Major="CS", Faculity="IT" });
             s.Add(new Student() { Name = "razan", Id = 30, Major = "CE", Faculity = "IT" });
             s.Add( new Student() { Name = "amar", Id = 3, Major = "CS", Faculity = "IT" });
            return View(s);

        }


    }
}