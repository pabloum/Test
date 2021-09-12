using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok("Get users");
        }

        [HttpGet("{filter}")]
        public IActionResult SearchUsers(string filter)
        {
            return Ok("Search users");
        }

        [HttpPost]
        public IActionResult RegisterUser()
        {
            return Ok("Register users");
        }
    }
}
