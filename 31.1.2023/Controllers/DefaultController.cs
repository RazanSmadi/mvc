using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31._1._2023.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public string About() {
            return "about us action";
        }
        public string  Contact() {
            return "contact us action";
        }
     
       public string img() {

            return "<h1>click to download</h1><a href=\"../img/tree.jpeg\" download><img src=\"../img/tree.jpeg\" style='width:250px;height=250px;'></a>";
           
        }

       
    }
}