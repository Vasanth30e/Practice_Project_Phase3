using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phase3Section2._38.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            int age = Convert.ToInt16(form["age"]);
            return View();
        }


        public ActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        [HandleError(View = "Error")]
        public ActionResult Index2(FormCollection form)
        {
            try
            {
                int age = Convert.ToInt16(form["age"]);
            }
            catch (Exception ex)
            {
                Session["error"] = ex.Message;
                throw ex;
            }
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}