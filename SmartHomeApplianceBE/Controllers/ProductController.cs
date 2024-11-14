using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Product;

namespace SmartHomeAppliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] string category = "", 
            [FromQuery] decimal? minPrice = 0, [FromQuery] decimal? maxPrice = 1000, [FromQuery] string searchTerm = "", 
            [FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var response = await productService.AllProductsByFilterAsync(category, minPrice, maxPrice, searchTerm, page, pageSize);

            return Ok(response);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody]CreateProductDto productDto)
        {
            var response = await productService.CreateProductAsync(productDto, UserId);

            if(response.StatusCode == 400)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpPatch]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update([FromBody]UpdateProductDto updateProductDto)
        {
            var response = await productService.UpdateProductAsync(updateProductDto);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string productId)
        {
            var response = await productService.DeleteProductAsync(productId);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }
    }
}
