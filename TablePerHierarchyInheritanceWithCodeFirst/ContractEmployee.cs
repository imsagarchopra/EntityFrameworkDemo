using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace TablePerHierarchyInheritanceWithCodeFirst
{
    public class ContractEmployee : Employee
    {
        [Column(Order = 6)]
        public int HoursWorked { get; set; }
        [Column(Order = 7)]
        public int HourlyPay { get; set; }
    }
}