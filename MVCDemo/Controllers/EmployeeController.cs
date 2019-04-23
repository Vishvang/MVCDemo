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
        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<EmployeeViewModel> employeeListViewModel =
                employeeContext.Employee.Where(emp => emp.DepartmentId == departmentId).ToList();
            return View(employeeListViewModel);
        }

        // GET: Employee
        public ActionResult GetDetails(int id)
        {
            EmployeeContext empContext = new EmployeeContext();
            EmployeeViewModel employeeViewModel = empContext.Employee.Single(emp => emp.EmployeeId == id);
            return View(employeeViewModel);
        }

        [HttpGet]
        public ActionResult CreateEmployee() {

            return View();
        }



        //Extra Play with Code - Try and ...Error
        public ActionResult GetDetails1(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            ViewBag.employeeListViewModel =
                employeeContext.Employee.Where(emp => emp.DepartmentId == departmentId).ToList();
            return View();
        }
    }
}