using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Core.Contracts;

namespace SmartHomeAppliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService adminService;
        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        [HttpPost("assign-role")]
        public async Task<IActionResult> AssignRole(string userId, string role)
        {
            var response = await adminService.AssignRoleAsync(userId, role);

            if (response.StatusCode == 400)
                return BadRequest(response);
            else if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }
    }
}
