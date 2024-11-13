namespace SmartHomeAppliance.Core.Models.Responses
{
    public class ApiResponse
    {
        public bool IsSuccess { get; set; } = false;
        public int StatusCode { get; set; }
        public ICollection<string> ErrorMessages { get; set; } = new HashSet<string>();
        public object Result { get; set; } = default!;
    }
}
