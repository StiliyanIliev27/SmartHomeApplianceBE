using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Profile;

namespace SmartHomeAppliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProfileController : BaseController
    {
        private readonly IProfileService profileService;
        public ProfileController(IProfileService profileService)
        {
            this.profileService = profileService;
        }

        [HttpGet]  
        public async Task<IActionResult> GetProfile()
        {
            var response = await profileService.GetUserProfileAsync(UserId);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProfile([FromForm] UpdateProfileRequestDto updateProfileDto)
        {
            var response = await profileService.UpdateProfileAsync(updateProfileDto, UserId);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }
    }
}
