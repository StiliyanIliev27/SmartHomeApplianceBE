using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Cart;

namespace SmartHomeAppliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartController : BaseController
    {
        private readonly ICartService cartService;

        public CartController(ICartService cartService)
        {
            this.cartService = cartService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCart()
        {
            var response = await cartService.GetCartByUserIdAsync(UserId);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddToCart([FromBody]ProductToCartDto addProductToCartDto)
        {
            var response = await cartService.AddToCartAsync(UserId, addProductToCartDto);

            if (!response.IsSuccess)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpDelete("remove")]
        public async Task<IActionResult> RemoveFromCart([FromBody]RemoveProductDto removeProductDto)
        {
            var response = await cartService.RemoveCartProductAsync(removeProductDto);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCartItem([FromBody]ProductToCartDto updateProductToCarDto)
        {
            var response = await cartService.UpdateCartProductQuantityAsync(UserId, updateProductToCarDto);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCart()
        {
            var response = await cartService.RemoveCartAsync(UserId);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }
    }
}
