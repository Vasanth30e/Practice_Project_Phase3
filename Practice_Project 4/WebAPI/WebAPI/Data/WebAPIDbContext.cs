using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class WebAPIDbContext : DbContext
    {
        public WebAPIDbContext (DbContextOptions<WebAPIDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI.Models.Marks> Marks { get; set; } = default!;
    }
}
