using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1_web_design.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Info()
        {
            ViewBag.Name = "John Doe";
            ViewBag.Address = "1230 NE Test Ave";
            return View();
        }
    }
}