using Microsoft.EntityFrameworkCore;
using ProfileApi.Models;

namespace ProfileApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User>? Users { get; set; }
    }
}
