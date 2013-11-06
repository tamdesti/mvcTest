using ContosoUniversity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{    
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        private SchoolContext db = new SchoolContext();

        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        //
        // GET: /Student/Details/5

        public ActionResult Details(int id)
        {
            Models.Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //
        // GET: /Student/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Student/Create

        [HttpPost]
        public ActionResult Create(Models.Student student)
        {
            try
            {
                // TODO: Add insert logic here
                //student.FirstMidName = Server.HtmlEncode(student.FirstMidName);
                var db = new SchoolContext();
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Student/Edit/5

        public ActionResult Edit(int id)
        {
            var db = new SchoolContext();
            Student student = db.Students.Find(id);
            if (student == null)
                return HttpNotFound();
            return View(student);
        }

        //
        // POST: /Student/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Models.Student student)
        {
            try
            {                
                // TODO: Add update logic here
                var db = new SchoolContext();
                Student student1 = db.Students.Find(id);
                student1.FirstMidName = student.FirstMidName;
                student1.EnrollmentDate = student.EnrollmentDate;
                student1.LastName = student.LastName;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Student/Delete/5

        public ActionResult Delete(int id)
        {
            var db = new SchoolContext();
            Student student = db.Students.Find(id);
            if (student == null)
                return HttpNotFound();
            return View(student);
        }

        //
        // POST: /Student/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Models.Student student)
        {
            try
            {
                // TODO: Add delete logic here
                var db = new SchoolContext();
                Student std = new Student();
                std = db.Students.Find(id);
                db.Students.Remove(std);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
