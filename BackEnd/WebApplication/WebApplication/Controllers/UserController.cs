﻿using Entities.DTOs;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
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

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _service.GetById(id);
            return Ok(user);
        }

        [HttpGet("filter/{filter}")]
        public IActionResult SearchUsers(string filter)
        {
            var users = _service.Filter(filter);
            return Ok(users);
        }

        [HttpPost]
        public IActionResult RegisterUser(UserDTO user)
        {
            var createdUser = _service.Create(user);
            return Ok(createdUser);
        }
    }
}
