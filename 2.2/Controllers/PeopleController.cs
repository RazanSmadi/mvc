using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using _2._2.Models;

namespace _2._2.Controllers
{
    public class PeopleController : Controller
    {
        private Entities3 db = new Entities3();

        // GET: People
        public ActionResult Index()
        {
            return View(db.Persons.ToList());
        }

      
        [HttpPost]
        public ActionResult Index(string search, string SearchType)
        {
            switch (SearchType)

            {
                case "1": return View(db.Persons.Where(person => person.First_Name.Contains(search)).ToList());
                case "2": return View(db.Persons.Where(person => person.Last_Name.Contains(search)).ToList());
                case "3": return View(db.Persons.Where(person => person.E_mail.Contains(search)).ToList());
                default: return View(db.Persons.ToList());
            }
        }









        // GET: People/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person p, HttpPostedFileBase user_image, HttpPostedFileBase Cv)
        {
            if (ModelState.IsValid)
            {
                string path = "../Images/" + user_image.FileName;
                user_image.SaveAs(Server.MapPath(path));
                p.user_image = path;
                string CvPath = "../Cvs/" + Cv.FileName;
                Cv.SaveAs(Server.MapPath(CvPath));
                p.Cv = CvPath;
                db.Persons.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(p);
        }




        // GET: People/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, Person person, HttpPostedFileBase user_image, HttpPostedFileBase Cv)
        {
            if (ModelState.IsValid)
            {
                var existingModel = db.Persons.AsNoTracking().FirstOrDefault(x => x.PersonID == id);

                if (user_image != null)
                {
                    string path = "../../Images/" + user_image.FileName;
                    user_image.SaveAs(Server.MapPath(path));
                    person.user_image = path;
                }
                else
                {
                    person.user_image = existingModel.user_image;
                }
                if (Cv != null)
                {
                    string CvPath = "../../Cvs/" + Cv.FileName;
                    Cv.SaveAs(Server.MapPath(CvPath));
                    person.Cv = CvPath;
                }
                else
                {
                    person.Cv = existingModel.Cv;
                }
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }






        // GET: People/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Persons.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = db.Persons.Find(id);
            db.Persons.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
