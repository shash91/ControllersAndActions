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

            
            return RedirectToAction("Index","Basic");
        }
        public HttpStatusCodeResult StatusCode()
        {
            //return new HttpStatusCodeResult(404, "URL cannot be serviced");
            //returning 404 result
            //return HttpNotFound();
            //sending a 401 result
            return new HttpUnauthorizedResult();
        }
    }
}