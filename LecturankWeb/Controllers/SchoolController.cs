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
            var schools = new List<SchoolListViewModel>()
            {
                new SchoolListViewModel()
                {
                    Id = 1,
                    Name = "School1",
                    Address = "Address 1"
                },
                new SchoolListViewModel()
                {
                    Id = 2,
                    Name = "School2",
                    Address = "Address 2"
                },
                new SchoolListViewModel()
                {
                    Id = 3,
                    Name = "School13",
                    Address = "Address 3"
                },
            };
            return View(await _context.Schools.ToListAsync());
        }

        public IActionResult Details(int id)
        { 

            var schoolDetails = new SchoolDetailsViewModel
            {
                Name = "My School",
                Amenities = new List<string> { "Water", "Library", "Sports complex" },
                CoverPhotoUrl = "www.img.com",
                Reviews = new List<SchoolReview>
                {
                    new SchoolReview
                    {
                        ReviewerName = "John Doe",
                        Content = "Bad school"
                    },
                    new SchoolReview
                    {
                        ReviewerName = "Shola Ade",
                        Content = "Great school"
                    }
                }
            };

            return View(schoolDetails);
        }
    }
}
