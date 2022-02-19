using System;
using System.Threading.Tasks;
using Contracts.Services;
using Entities.Models;
using Extensions;
using Microsoft.AspNetCore.Mvc;

namespace DashboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IServiceWrapper _service;

        public AuthenticationController(IServiceWrapper service) => _service = service;

        [HttpGet("Token")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var token = _service.Token.CreateStaticToken();
                return Ok(token);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            try
            {
                var newUser = await _service.User.CreateUserAsync(user);
                return Ok(newUser.Message.IsNullOrWhiteSpace() ? _service.Token.CreateStaticToken() : newUser);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }
    }
}