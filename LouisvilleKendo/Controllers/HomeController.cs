using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LouisvilleKendo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Louisville Kendo Club";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please contact us for information";

            return View();
        }
    }
}