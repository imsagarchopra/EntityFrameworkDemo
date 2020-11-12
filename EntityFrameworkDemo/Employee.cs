using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemo
{
    public class Employee
    {
        // Scalar Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        // Navigation Property
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public string JobTitle { get; set; }

    }
}