using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Store the list of country in Dynamic Feature which is introduced in C# 4.0 Version
            //Dynamic Properties CountryList
            ViewData["CountryList"] =new List<string>()
            {
                "India","UK","USA","Canada"
            };
            
            return View();
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