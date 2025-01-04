using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Users;

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
        public async Task<IActionResult> AssignRole([FromBody] AssignRoleRequestDto assignRoleDto)
        {
            var response = await adminService.AssignRoleAsync(assignRoleDto);

            if (response.StatusCode == 400)
                return BadRequest(response);
            else if (response.StatusCode == 404)
                return NotFound(response);
            else if (response.StatusCode == 403)
                return StatusCode(403, response);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            var response = await adminService.GetDashboardAsync();

            return Ok(response);
        }

        [HttpGet("recent-activities")]
        public async Task<IActionResult> RecentActivities()
        {
            var activities = await adminService.GetRecentActivitiesAsync();

            return Ok(activities);
        }

        [HttpGet("top-products")]
        public async Task<IActionResult> TopProducts()
        {
            var products = await adminService.GetTopProductsAsync();

            return Ok(products);
        }

        [HttpGet("overall-rating")]
        public async Task<IActionResult> OverallRating()
        {
            var overallRating = await adminService.GetOverallRatingAsync();

            return Ok(overallRating);
        }
        
        [HttpGet("inventory-status")]
        public async Task<IActionResult> InventoryStatus()
        {
            var inventoryStatus = await adminService.GetInventoryAsync();

            return Ok(inventoryStatus);
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await adminService.GetUsersDataAsync();

            return Ok(users);
        }
    }
}
