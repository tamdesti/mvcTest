using ContosoUniversity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private SchoolContext db = new SchoolContext();

        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        [HttpPost]
        public ActionResult About(Models.Student student)
        {
            if (ModelState.IsValid)
            {
                var db = new SchoolContext();
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
