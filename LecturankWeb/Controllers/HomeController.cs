using System.Diagnostics;
using LecturankWeb.Helpers;
using LecturankWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace LecturankWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpService _httpService;

        public HomeController(ILogger<HomeController> logger, HttpService httpService)
        {
            _logger = logger;
            _httpService = httpService;
        }

        public async Task<IActionResult> Index()
        {
            //var data = await _httpService.GetAsync<string>("admin/schools");
            var schools = await _httpService.GetAsync<List<School>>("schools");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CodeName { get; set; }
    }
}
