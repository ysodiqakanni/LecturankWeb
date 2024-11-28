using LecturankWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LecturankWeb.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult Index()
        {
            // Create a list of lecturers using the LecturerViewModel
            var lecturers = new List<LecturerViewModel>
            {
                new LecturerViewModel { Id = 1, Name = "Dr. John Doe", School = "School of Science", Department = "Computer Science" },
                new LecturerViewModel { Id = 2, Name = "Prof. Jane Smith", School = "School of Arts", Department = "Fine Arts" }
             };

            return View(lecturers);
        }
        // Action for Lecturer Creation Page
        public IActionResult Create()
        {
            return View();
        }

        // Action for Lecturer Profile Page
        public IActionResult Profile()
        {
            return View();
        }
    }
}
