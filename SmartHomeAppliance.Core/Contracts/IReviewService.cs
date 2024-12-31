using SmartHomeAppliance.Core.Models.DTOs.Review;
using SmartHomeAppliance.Core.Models.Responses;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IReviewService
    {
        Task<ApiResponse> AllReviewsByProductIdAsync(string productId);
        Task<ApiResponse> PostReviewAsync(PostReviewRequestDto postReviewDto);
        Task<ApiResponse> EditReviewAsync(EditReviewDto editReviewDto);
        Task<ApiResponse> DeleteReviewAsync(string reviewId);
    }
}
