using Microsoft.EntityFrameworkCore;

namespace Mentor.NET.Models.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Expert> Experts { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
