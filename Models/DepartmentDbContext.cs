
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst_Demo.Models
{
    public class DepartmentDbContext:DbContext
    {
        public DepartmentDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
    }
}
