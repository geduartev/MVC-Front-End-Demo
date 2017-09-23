using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "MvcDemo Gabriel Duarte 2017";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "MvcDemo Gabriel Duarte 2017";
            return View();
        }
    }
}