using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This Project Created By Ozan Kuş";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You may feel free to contact with me .";

            return View();
        }
    }
}