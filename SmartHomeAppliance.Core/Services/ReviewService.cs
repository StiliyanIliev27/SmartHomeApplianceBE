using Microsoft.EntityFrameworkCore;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Review;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Models;
using static SmartHomeAppliance.Common.CustomErrors.GlobalErrors;

namespace SmartHomeAppliance.Core.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository repository;
        private ApiResponse apiResponse;
        public ReviewService(IRepository repository)
        {
            this.repository = repository;
            apiResponse = new ApiResponse();
        }
        public async Task<ApiResponse> AllReviewsByProductIdAsync(string productId)
        {
            var reviews = await repository.AllReadOnly<Review>()
                .Where(r => r.ProductId == productId)
                .Include(r => r.User)
                .Select(r => new GetReviewDto()
                {
                    Id = r.Id,
                    UserId = r.UserId,
                    UserFullName = $"{r.User!.FirstName} {r.User.LastName}",
                    UserProfilePicture = r.User.ProfilePictureUrl,
                    Comment = r.Comment,
                    Rating = r.Rating,
                    ReviewDate = r.ReviewDate.ToString("dd-MM-yyyy")
                })
                .ToListAsync();

            if (!reviews.Any())
            {
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                apiResponse.ErrorMessages.Add("The given product has no reviews yet");
                return apiResponse;
            }

            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 200;
            apiResponse.Result = reviews;
            return apiResponse;
        }

        public async Task<ApiResponse> DeleteReviewAsync(string reviewId)
        {
            var review = await repository.GetByIdAsync<Review>(reviewId);

            if (review is null)
            {
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 404;
                apiResponse.ErrorMessages.Add("Review was not found!");
                return apiResponse;
            }

            repository.Delete(review);
            await repository.SaveChangesAsync();

            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 200;
            apiResponse.Message = $"Review with an id: {review.Id} was succesfully been deleted!"; 
            return apiResponse;
        }

        public async Task<ApiResponse> EditReviewAsync(EditReviewDto editReviewDto)
        {
            var review = await repository.GetByIdAsync<Review>(editReviewDto.ReviewId);

            if(review is null)
            {
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 404;
                apiResponse.ErrorMessages.Add("Review was not found!");
                return apiResponse;
            }

            review.Comment = editReviewDto.NewComment;
            review.Rating = editReviewDto.NewRating;
            
            await repository.UpdateAsync(review);
            await repository.SaveChangesAsync();

            apiResponse.Result = review;
            apiResponse.IsSuccess = true;
            apiResponse.Message = $"Review with an id: {review.Id} was successfully been updated!";
            apiResponse.StatusCode = 200;
            return apiResponse;
        }

        public async Task<ApiResponse> PostReviewAsync(PostReviewRequestDto postReviewDto)
        {
            var product = await repository.GetByIdAsync<Product>(postReviewDto.ProductId);

            if(product is null)
            {
                apiResponse.StatusCode = 404;
                apiResponse.ErrorMessages.Add(ProductNotFound);
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var review = new Review()
            {
                ProductId = product.Id,
                UserId = postReviewDto.UserId,
                Comment = postReviewDto.Comment,
                ReviewDate = DateTime.Now,
                Rating = postReviewDto.Rating
            };

            await repository.AddAsync(review);
            await repository.SaveChangesAsync();

            apiResponse.IsSuccess = true;
            apiResponse.Message = "Review was successfully uploaded!";
            apiResponse.StatusCode = 201;
            apiResponse.Result = review;
            return apiResponse;
        }
    }
}
