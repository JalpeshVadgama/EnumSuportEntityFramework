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
                Deaprtment = Deaprtment.Admin
            };

            Employee anotherEmployee = new Employee
            {
                EmployeeId = 2,
                FirstName = "Vishal",
                LastName = "Vadgama",
                Deaprtment = Deaprtment.Marketing
            };

            //Code for adding Employees
            using (EmployeeConext employeeConext = new EmployeeConext())
            {
                employeeConext.Employees.Add(employee);
                employeeConext.Employees.Add(anotherEmployee);
                employeeConext.SaveChanges();
                Console.WriteLine("Employee Added Sucessfully");
            }
        }
    }
}
