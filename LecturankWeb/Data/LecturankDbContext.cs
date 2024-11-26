using Microsoft.EntityFrameworkCore;
using LecturankWeb.Models;

namespace LecturankWeb.Data
{
    public class LecturankDbContext : DbContext
    {
        public LecturankDbContext(DbContextOptions<LecturankDbContext> options) : base(options)
        {
        }

        public DbSet<School> Schools { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
    }
}
