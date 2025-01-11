using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Orders;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Products;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Users;
using SmartHomeAppliance.Core.Models.DTOs.Auth;

namespace SmartHomeAppliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        private readonly IAdminService adminService;
        private readonly IAuthService authService;
        public AdminController(IAdminService adminService, IAuthService authService)
        {
            this.adminService = adminService;
            this.authService = authService;
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

        [HttpPost("new-user")]
        public async Task<IActionResult> CreateNewUser([FromBody] RegisterDTO registerModel)
        {
            var response = await authService.RegisterAsync(registerModel);

            if (response.StatusCode == 400)
                return BadRequest(response);

            if (response.StatusCode == 500)
                return StatusCode(500, response.ErrorMessages.First());


            return Ok(response);
        }

        [HttpDelete("delete-user")]
        public async Task<IActionResult> DeleteUser([FromQuery] string userId)
        {
            var response = await adminService.DeleteUserAsync(userId);

            if (response.StatusCode == 404)
                return NotFound(response);
            else if (response.StatusCode == 403)
                return StatusCode(403, response);

            return Ok(response);
        }

        [HttpGet("products")]
        public async Task<IActionResult> AllProducts()
        {
            var products = await adminService.GetProductsAsync();

            return Ok(products);
        }

        [HttpPut("edit-product")]
        public async Task<IActionResult> EditProduct([FromForm] EditProductDto editProductDto)
        {
            var response = await adminService.EditProductAsync(editProductDto);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }

        [HttpPost("new-product")]
        public async Task<IActionResult> CreateNewProduct([FromForm] EditProductDto addProductDto)
        {
            var response = await adminService.AddProductAsync(addProductDto, UserId);

            if (response.StatusCode == 400)
                return BadRequest(response);
            
            return Ok(response);
        }

        [HttpDelete("delete-product")]
        public async Task<IActionResult> DeleteProduct([FromQuery] string productId)
        {
            var response = await adminService.DeleteProductAsync(productId);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }

        [HttpGet("orders")]
        public async Task<IActionResult> GetProducts()
        {
            var orders = await adminService.GetOrdersAsync();

            return Ok(orders);
        }

        [HttpGet("order-by-id")]
        public async Task<IActionResult> GetOrderById([FromQuery] string orderId)
        {
            var response = await adminService.GetOrderDetailsByIdAsync(orderId);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }

        [HttpPatch("update-order")]
        public async Task<IActionResult> UpdateOrderStatus([FromBody] UpdateOrderStatusDto updateOrderStatusDto)
        {
            var response = await adminService.UpdateOrderStatusAsync(updateOrderStatusDto);

            if (response.StatusCode == 404)
                return NotFound(response);
            else if (response.StatusCode == 400)
                return BadRequest(response);

            return Ok(response);
        }
    }
}
