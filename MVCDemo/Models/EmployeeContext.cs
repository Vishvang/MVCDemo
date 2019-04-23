using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCDemo.Models
{
    public class EmployeeContext : DbContext
    {
        //To use EF Code First Approach.
        //Inherit from DBContext to retrive data from database and populate our custom Objects
        public DbSet<EmployeeViewModel> Employee { get; set; }
        public DbSet<DepartmentViewModel> Department { get; set; }
    }
}