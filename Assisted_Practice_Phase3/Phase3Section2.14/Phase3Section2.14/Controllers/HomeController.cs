using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Phase3Section2._14.Models;
using System.Diagnostics;
using System.Text;

namespace Phase3Section2._14.Controllers
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
        public IActionResult FormAction(Student student)
        {
            if (ModelState.IsValid)
                return Content("Form data is valid.");
            else
            {
                StringBuilder sb = new StringBuilder("");

                foreach (ModelStateEntry value in ViewData.ModelState.Values)
                {
                    if (value.Errors.Count > 0)
                    {
                        for (int i = 0; i < value.Errors.Count; i++)
                            sb.Append(value.Errors[i].ErrorMessage + "\n");
                    }
                }
                return Content("Form data is invalid with " + ModelState.ErrorCount.ToString() + " errors:\n " + sb.ToString());
            }
        }
    }
}