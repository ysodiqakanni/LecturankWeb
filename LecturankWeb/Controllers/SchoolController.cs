using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LecturankWeb.Data;
using LecturankWeb.Models;

namespace LecturankWeb.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchoolController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Schools.ToListAsync());
        }

        public IActionResult Details(int id)
        {
            var school = _context.Schools
                .Include(s => s.Reviews)
                .FirstOrDefault(s => s.Id == id);

            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }
    }
}
