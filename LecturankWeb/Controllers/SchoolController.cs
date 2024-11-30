using Microsoft.AspNetCore.Mvc;
using LecturankWeb.Models;
using LecturankWeb.Services;
using System.Threading.Tasks;

namespace LecturankWeb.Controllers
{
    public class SchoolController : Controller
    {
        private readonly SchoolService _schoolService;

        public SchoolController(SchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        // GET: School
        public async Task<IActionResult> Index()
        {
            var schools = _schoolService.GetSchoolList();
            return View(schools);
        }

        // GET: School/Details/{slug}
        [Route("School/Details/{slug}")]
        public IActionResult Details(string slug)
        {
            var school = _schoolService.GetSchoolDetails(slug);
            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }
    }
}
