using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //public string Index(string id)
        //{
        //    //return View();
        //    //return "Hello MVC";
        //    string queryString = Request.QueryString.Get("name");
        //    return "ID = "+id + " Query String = "+ queryString;
        //}


        public string Index(string id,string name)
        {
            return "ID = " + id + " Name = " + name;
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