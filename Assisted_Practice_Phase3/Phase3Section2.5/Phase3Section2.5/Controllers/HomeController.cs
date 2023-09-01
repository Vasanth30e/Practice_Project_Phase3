using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Phase3Section2._5.Models;

namespace Phase3Section2._5.Controllers
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

        public ContentResult StudentAsString()
        {
            return Content("The name of the student is Walter Smith and he is in Grade 7.");
        }

        public ViewResult StudentAsView()
        {
            ViewData["message"] = "The name of the student is <b>Walter Smith</b> and he is in Grade 7.";
            return View();
        }

        public RedirectResult StudentAsRedirectResult()
        {
            return new RedirectResult("https://www.bing.com/search?q=walter+smith");
        }

        public RedirectToRouteResult StudentAsRedirectToRouteResult()
        {
            return new RedirectToRouteResult(new { Controller = "Home", action = "StudentAsView" });
        }

        public FileResult StudentAsFileResult()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"./wwwroot/StudentData.txt");
            string fileName = "StudentData.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
        public JsonResult StudentAsJSONResult()
        {
            String data = System.IO.File.ReadAllText(@"./wwwroot/StudentData.json");
            JObject json = JObject.Parse(data);
            return Json(json);
        }

        public ViewResult StudentList()
        {
            return View();
        }
    }
}
