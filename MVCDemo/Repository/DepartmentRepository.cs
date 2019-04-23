using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo.Models;

namespace MVCDemo.Repository
{
    public class DepartmentRepository
    {
        public List<DepartmentViewModel> GetDepartmentListRepo() {

            EmployeeContext employeeContext = new EmployeeContext();
            List<DepartmentViewModel> departmentList = employeeContext.Department.ToList();

            return departmentList;
        }
                 
    }
}