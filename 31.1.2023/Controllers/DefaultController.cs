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

            return "<a href=\"download\"> <img src=\"../img/tree.jpeg\"></a>";
           
        }

        public void download()
        {

            var imgPath = Server.MapPath("../img/tree.jpeg");
            Response.AddHeader("Content-Disposition", "attachment;filename=DealerAdTemplate.png");
            Response.WriteFile(imgPath);
            Response.End();
        }
    }
}