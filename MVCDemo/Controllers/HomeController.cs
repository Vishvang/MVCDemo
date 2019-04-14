using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public List<string> Index()
        {
            return new List<string>()
            {
                "India","UK","USA","Canada"
            };

            //OUTPUT from MVCDemo/Home/Index
            //In this scenerio If we see the output
            //System.Collections.Generic.List`1[System.String]

            //So we need to traverse and for that we need to add View
        }

        public string GetResult() {
            return "My String from Get Result";
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