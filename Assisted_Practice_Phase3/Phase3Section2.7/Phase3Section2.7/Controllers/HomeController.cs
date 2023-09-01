using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Phase3Section2._7.Models;

namespace Phase3Section2._7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ViewResult ViewDataSubmit()
        {
            ViewData["name"] = Request.Form["name"];
            ViewData["address"] = Request.Form["address"];
            ViewData["class"] = Request.Form["class"];
            ViewData["year"] = Request.Form["year"];

            return View();
        }

        [HttpPost]
        public ViewResult ViewBagSubmit()
        {
            ViewBag.name = Request.Form["name"];
            ViewBag.address = Request.Form["address"];
            ViewBag.sclass = Request.Form["sclass"];
            ViewBag.year = Request.Form["year"];

            return View();
        }

        [HttpPost]
        public ActionResult TempDataRedirect()
        {
            TempData["name"] = Request.Form["name"].ToString();
            TempData["address"] = Request.Form["address"].ToString();
            TempData["class"] = Request.Form["class"].ToString();
            TempData["year"] = Request.Form["year"].ToString();

            return RedirectToAction("TempDataSubmit");
        }

        public ViewResult TempDataSubmit()
        {
            var model = TempData["name"];
            return View();
        }

    }
}
