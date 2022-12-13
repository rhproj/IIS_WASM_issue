using BzrIIStest.Shared;
using Microsoft.EntityFrameworkCore;

namespace BzrIIStest.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<CatNames> CatNames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatNames>().HasData(
                new CatNames { Id = 1, Name = "Fluffy"},
                new CatNames { Id = 2, Name = "Tutsy" }
            );
        }
    }
}
