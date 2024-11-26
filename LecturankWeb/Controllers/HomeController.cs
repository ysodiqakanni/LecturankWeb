using Microsoft.AspNetCore.Mvc;
using LecturankWeb.Models;
using System.Linq;
using System.Threading.Tasks;
using LecturankWeb.Data;

namespace LecturankWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly LecturankDbContext _context;

        public HomeController(LecturankDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult School()
        {
            return View("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet]
        public IActionResult SearchSchool(string query)
        {
            var schools = _context.Schools
                .Where(s => s.Name.Contains(query) || s.Address.Contains(query))
                .ToList();

            return View("SearchSchoolResults", schools);
        }


        [HttpPost]
        public IActionResult SearchLecturer(int schoolId, string query)
        {
            var lecturers = _context.Lecturers
                .Where(l => l.SchoolId == schoolId && (l.Name.Contains(query) || l.ContactInformation.Contains(query)))
                .ToList();

            return View("SearchLecturerResults", lecturers);
        }
    }
}
