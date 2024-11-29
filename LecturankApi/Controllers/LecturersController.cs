using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LecturankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturersController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllLecturers()
        {
            return Ok();
        }
    }
}
