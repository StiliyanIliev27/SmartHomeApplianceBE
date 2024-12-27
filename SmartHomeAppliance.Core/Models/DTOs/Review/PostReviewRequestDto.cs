namespace SmartHomeAppliance.Core.Models.DTOs.Review
{
    public class PostReviewRequestDto
    {
        public string ProductId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string Comment { get; set; } = string.Empty;
        public int Rating { get; set; }
    }
}
