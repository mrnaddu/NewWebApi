using Microsoft.EntityFrameworkCore;
using NewWebApi.Model;

namespace NewWebApi.EmployeeContext
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {
        }
        DbSet<Employee> Employees { get; set; }
    }

    
}
