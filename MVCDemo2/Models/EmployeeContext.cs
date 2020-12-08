using Microsoft.EntityFrameworkCore;
using MVCDemo2.Models.Employees;

namespace MVCDemo2.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
