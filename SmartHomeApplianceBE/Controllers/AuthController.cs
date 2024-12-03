using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Auth;

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
        public async Task<IActionResult> Register([FromForm] RegisterDTO registerModel)
        {
            var response = await authService.RegisterAsync(registerModel);

            if (response.StatusCode == 400)
                return BadRequest(response);

            if (response.StatusCode == 500)
                return StatusCode(500, response.ErrorMessages.First());
                

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginModel)
        {
            var response = await authService.LoginAsync(loginModel);

            if (response.StatusCode == 400)
                return BadRequest(response);

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
