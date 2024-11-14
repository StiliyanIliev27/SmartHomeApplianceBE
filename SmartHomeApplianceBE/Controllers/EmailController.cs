﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Infrastructure.Data.Models;
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

    }
}
