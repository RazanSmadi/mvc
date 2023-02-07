using _7._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7._2.Controllers
{
    public class HomeController : Controller
    {

        Entities2 db = new Entities2();
        public ActionResult Index()
        {
            var emp = db.Services.ToList();
            return View(emp);
        }
       

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}