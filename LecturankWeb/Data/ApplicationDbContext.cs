using Microsoft.EntityFrameworkCore;
using LecturankWeb.Models;

namespace LecturankWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<School> Schools { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
