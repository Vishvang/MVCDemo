using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;


//CONTROLLER Get the data from Model and Provide to the View
namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetDetails()
        {
            Employee employee = 
                new Employee() {
                    EmployeeId = 101, Name = "David", City = "Orlando", Gender = "Male"
                };
            
            return View(employee);
        }
    }
}