namespace SmartHomeAppliance.Core.Models.DTOs.Review
{
    public class EditReviewDto
    {
        public string ReviewId { get; set; } = null!;
        public string NewComment { get; set; } = string.Empty;
        public int NewRating { get; set; }
    }
}
