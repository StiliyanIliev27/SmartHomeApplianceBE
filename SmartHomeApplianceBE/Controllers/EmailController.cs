using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using SmartHomeAppliance.Infrastructure.Data.Models;
using System.Web;
using static SmartHomeAppliance.Common.CustomErrors.GlobalErrors;

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
        public async Task<IActionResult> ConfirmEmail([FromQuery]string token, [FromQuery]string userId)
        {
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(userId))
            {
                return BadRequest("Invalid token or userId.");
            }

            var tokenArray = token.Split(' ');
            token = string.Join('+', tokenArray);

            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return BadRequest(UserNotFound);
            }

            var result = await userManager.ConfirmEmailAsync(user, token);

            if (!result.Succeeded)
            {
                return BadRequest("Email confirmation failed.");
            }

            return Ok("Email confirmed successfully. Your account is now activated.");
        }
        
        // GET: api/auth/check-confirmation?email={email}
        [HttpGet("check-confirmation")]
        public async Task<IActionResult> CheckConfirmationStatus([FromQuery] string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return BadRequest(new { message = "Email is required." });
            }

            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound(new { message = "User not found." });
            }

            if (user.EmailConfirmed)
            {
                return Ok(new { isConfirmed = true });
            }

            return Ok(new { isConfirmed = false });
        }
    }
}
