//This is Class First Approach so Class Name will represents Table Name and 
//properties field will represents Column of Table.


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Employee")]
    public class EmployeeViewModel
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public int DepartmentId { get; set; }
    }
}