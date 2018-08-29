using System;
using System.Web.Mvc;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Привет Мир";
            ViewData["Time"] = DateTime.Now.ToShortTimeString();
            return View("DebugData");
        }

        public ActionResult List()
        {
            return View();
        }
    }
}