using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DataAccess
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }
        public DbSet<Campus> Campus { get; set; }
        public DbSet<Campus> Department { get; set; }
        public DbSet<Campus> Student { get; set; }


    }
}