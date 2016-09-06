using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Round2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Category()
        {
            ViewBag.Message = "Your Topic of Choice.";

            return View();
        }

        public ActionResult Review()
        {
            ViewBag.Message = "What's Your Opinion?";

            return View();
        }
    }
}