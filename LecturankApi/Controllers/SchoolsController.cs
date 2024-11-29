using LecturankApi.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LecturankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllSchools()
        {
            var schools = new List<School>()
            {
                new School()
                {
                    Id = 1,
                    Name = "University of Lagos",
                    CodeName = "Unilag"
                }
            };
            return Ok(schools);
        }
    }
}
