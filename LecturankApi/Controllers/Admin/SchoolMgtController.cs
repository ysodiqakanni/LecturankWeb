using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LecturankApi.Controllers.Admin
{
    [Route("api/admin/schools")]
    [ApiController]
    public class SchoolMgtController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetSchools()
        {
            return Ok("hello there");
        }
    }
}
