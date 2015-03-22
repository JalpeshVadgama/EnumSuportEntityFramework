using System.Data.Entity;

namespace EnumSupportEF
{
    public class EmployeeConext : DbContext 
    {
        public EmployeeConext() :base("EmployeeConnectionString")
        {
            
        }
        public DbSet<Employee> Employees { get; set; } 
    }
}