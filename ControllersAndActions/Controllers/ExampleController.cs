using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ViewResult Index()
        {
            //  DateTime date = DateTime.Now;
            //return View(date);
            ViewBag.Message = TempData["Message"];
            ViewBag.Date = TempData["Date"];
            return View();
        }
        public RedirectToRouteResult Redirect()
        {
            //redirect to an action in same controller
            // return RedirectToAction("Index");
            // redirect to an action in different controller

            TempData["Message"] = "Hello";
            TempData["Date"] = DateTime.Now;
            return RedirectToAction("Index");
        }
    }
}