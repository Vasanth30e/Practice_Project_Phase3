using System.Collections.Generic;
using System.Data.Entity;

namespace Phase3Section2._32.Models
{
    public class GenericDBContext : DbContext
    {
        public GenericDBContext()
           : base("School1Entities")
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }

}
