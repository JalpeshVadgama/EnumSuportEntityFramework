using System.Data.Entity;

namespace EnumSupportEF
{
    public class EmployeeContext : DbContext 
    {
        public EmployeeContext() :base("EmployeeConnectionString")
        {
            
        }
        public DbSet<Employee> Employees { get; set; } 
    }
}
