using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411031246.Controllers
{
    public class waterlaController : Controller
    {
        // GET: waterla
        public ActionResult Index(string name, float? weight)
        {
            var result = " ";
            if (weight.HasValue)
            {
                result = (weight * 30) + "cc";
            }
            ViewBag.Name = name;
            ViewBag.result = result;
            return View();
        }
    }
}