using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace TablePerHierarchyInheritanceWithCodeFirst
{
    public class PermanentEmployee : Employee
    {
        [Column(Order = 5)]
        public int AnnualSalary { get; set; }
    }
}