using Microsoft.EntityFrameworkCore;
using EmployeeMS.Models;

namespace EmployeeMS.Data
{
    public class EMSDbContext : DbContext
    {
        public EMSDbContext (DbContextOptions<EMSDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeMS.Models.EmpProfile> EmpProfile { get; set; } = default!;
        public DbSet<DeptMaster> DeptMaster { get; set; }
    }
}
