using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Technician;

namespace SmartHomeAppliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TechnicianController : BaseController
    {
        private readonly ITechnicianService technicianService;

        public TechnicianController(ITechnicianService technicianService)
        {
            this.technicianService = technicianService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTechniciansByProduct([FromQuery]string productId)
        {
            var technicians = await technicianService.GetAllTechniciansByProductId(productId);

            return Ok(technicians);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] AddProductDto addProductDto)
        {
            var response = await technicianService.AddProductAsync(UserId, addProductDto);

            if (response.StatusCode == 404)
                return NotFound(response);
            else if (response.StatusCode == 400)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveProduct([FromQuery] string productId)
        {
            var response = await technicianService.RemoveProductAsync(productId);

            if (response.StatusCode == 404)
                return NotFound(response);
            else if (response.StatusCode == 400)
                return BadRequest(response);

            return Ok(response);
        }
    }
}
