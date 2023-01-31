using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31._1._2023.Controllers
{
    public class RazanController : Controller
    {
        // GET: Razan
        public ActionResult Index()
        {
            return View();
        }

        public string name()
        {
            return "Razan Ali Smadi";
        }
        public int age()
        {
            return 23;
        }
        public string city()
        {
            return "jerash";
        }
        public int id()
        {
            return 30;
        }

        public string email()
        {
            return "razansmadi99@gmail.com";
        }
    }
}