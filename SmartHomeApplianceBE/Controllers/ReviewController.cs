using Microsoft.AspNetCore.Mvc;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Review;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

namespace SmartHomeAppliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService reviewService;
        public ReviewController(IReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReviewsByProductId([FromQuery]string productId)
        {
            var response = await reviewService.AllReviewsByProductIdAsync(productId);

            if(response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> PostReview(PostReviewRequestDto postReviewDto)
        {
            var response = await reviewService.PostReviewAsync(postReviewDto);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }

        [HttpPatch]
        public async Task<IActionResult> EditReview(EditReviewDto editReviewDto)
        {
            var response = await reviewService.EditReviewAsync(editReviewDto);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteReview([FromQuery]string reviewId)
        {
            var response = await reviewService.DeleteReviewAsync(reviewId);

            if (response.StatusCode == 404)
                return NotFound(response);

            return Ok(response);
        }
    }
}