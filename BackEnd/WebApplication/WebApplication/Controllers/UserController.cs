using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _service.GetAll();
            return Ok(users);
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
