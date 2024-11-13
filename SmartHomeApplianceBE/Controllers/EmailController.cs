using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration configuration;

        public EmailController(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }


        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmail(string token, string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return BadRequest("Invalid user.");
            }

            var result = await userManager.ConfirmEmailAsync(user, token);

            if (!result.Succeeded)
            {
                return BadRequest("Email confirmation failed.");
            }

            return Ok("Email confirmed successfully. Your account is now activated.");
        }

    }
}
