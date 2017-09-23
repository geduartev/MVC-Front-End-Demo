using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class LanguagesController : Controller
    {
        public ActionResult Index(string language)
        {
            if (string.IsNullOrWhiteSpace(language))
            {
                return View("DefaultPage");
            }

            if (language.Equals("ingles") || language.Equals("english") || language.Equals("en"))
            {
                ViewBag.Title = "Page with Title in English";
                ViewBag.SubTitle = "SubTitle in English";
            }

            if (language.Equals("español") || language.Equals("spanish") || language.Equals("es"))
            {
                ViewBag.Title = "Título en español";
                ViewBag.SubTitle = "Subtítulo en español";
            }

            return View();
        }
    }
}