using System;

namespace EnumSupportEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                EmployeeId = 1,
                FirstName ="Jalpesh",
                LastName  ="Vadgama",
                Department = Department.Admin
            };

            Employee anotherEmployee = new Employee
            {
                EmployeeId = 2,
                FirstName = "Vishal",
                LastName = "Vadgama",
                Department = Department.Marketing
            };

            //Code for adding Employees
            using (EmployeeContext employeeContext = new EmployeeContext())
            {
                employeeContext.Employees.Add(employee);
                employeeContext.Employees.Add(anotherEmployee);
                employeeContext.SaveChanges();
                Console.WriteLine("Employee Added Sucessfully");
            }
        }
    }
}
