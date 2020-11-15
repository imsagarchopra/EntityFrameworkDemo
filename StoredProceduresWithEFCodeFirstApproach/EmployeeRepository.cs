using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoredProceduresWithEFCodeFirstApproach
{
    public class EmployeeRepository
    {
        EmployeeDBContext employeeDBContext = new EmployeeDBContext();

        public List<Employee> GetEmployees()
        {
            return employeeDBContext.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            employeeDBContext.Employees.Add(employee);
            employeeDBContext.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            var employeeToUpdate = employeeDBContext.Employees.FirstOrDefault(x => x.ID == employee.ID);
            employeeToUpdate.Name = employee.Name;
            employeeToUpdate.Gender = employee.Gender;
            employeeToUpdate.Salary = employee.Salary;

            employeeDBContext.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            var employeeToDelete = employeeDBContext.Employees.FirstOrDefault(x => x.ID == employee.ID);
            employeeDBContext.Employees.Remove(employeeToDelete);

            employeeDBContext.SaveChanges();
        }
    }
}