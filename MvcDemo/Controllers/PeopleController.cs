using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class PeopleController : Controller
    {
        private static readonly List<Person> People = new List<Person>();

        public ActionResult List()
        {
            return View(People);
        }

        public ActionResult Details(Person person) => View(person);

        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View($"Create", person);
            }

            People.Add(person);
            return RedirectToAction("List");
        }
    }
}
