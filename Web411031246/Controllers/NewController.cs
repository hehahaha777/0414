using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411031246.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HW1()
        {
            return View();
        }
        public ActionResult HW2()
        {
            return View();
        }
        public ActionResult HW3()
        {
            ViewBag.hoyeah = "liubi";
            ViewData["liubi"] = 100;
            return View();

        }

    }
}