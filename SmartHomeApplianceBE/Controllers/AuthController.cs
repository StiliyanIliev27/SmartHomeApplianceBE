using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs;

namespace SmartHomeAppliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerModel)
        {
            var response = await authService.RegisterAsync(registerModel);

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginModel)
        {
            var response = await authService.LoginAsync(loginModel);

            return Ok(response);
        }


        [HttpGet("check-login")]
        [Authorize]
        public IActionResult CheckLogin()
        {
            return Ok("User is logged in.");
        }
    }
}
