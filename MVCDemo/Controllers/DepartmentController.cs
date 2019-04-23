using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using MVCDemo.Repository;

namespace MVCDemo.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            DepartmentRepository departmentRepository = new DepartmentRepository();
            List<DepartmentViewModel> department = departmentRepository.GetDepartmentListRepo();
            
            return View(department);
        }
    }
}