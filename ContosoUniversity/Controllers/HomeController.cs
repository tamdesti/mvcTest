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
            return View();
        }
        
        public ActionResult About(Models.Student student)
        {            
            return View();
        }

        public ActionResult Slicebox()
        {
            return View();
        }

        public ActionResult Carousel()
        {
            return View();
        }
    }
}
