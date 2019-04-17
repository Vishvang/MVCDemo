using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

//Controller Is Responsible to Handle The  REQUEST
//CONTROLLER Get the data from Model and Provide to the View
namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<EmployeeViewModel> employeeListViewModel = employeeContext.Employee.ToList();
            return View(employeeListViewModel);
        }
        // GET: Employee
        public ActionResult GetDetails(int id)
        {
            //Employee employee = 
            //    new Employee() {
            //        EmployeeId = 101, Name = "David", City = "Orlando", Gender = "Male"
            //    };

            EmployeeContext empContext = new EmployeeContext();
            EmployeeViewModel employeeViewModel = empContext.Employee.Single(emp => emp.EmployeeId == id);
            return View(employeeViewModel);
        }
    }
}