using Microsoft.EntityFrameworkCore;

namespace CSSSDF_FINALS.Models
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
