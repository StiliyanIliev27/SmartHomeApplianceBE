namespace SmartHomeAppliance.Core.Models.DTOs.Review
{
    public class GetReviewDto
    {
        public string Id { get; set; } = null!;

        public string UserId { get; set; } = null!;
        public string UserFullName { get; set; } = null!;
        public string UserProfilePicture { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        public string ReviewDate { get; set; } = null!;
    }
}
