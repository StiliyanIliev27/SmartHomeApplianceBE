namespace SmartHomeAppliance.Core.Models.DTOs.Cart
{
    public class GetCartModelDto
    {
        public GetCartModelDto()
        {
            CartProducts = new HashSet<CartProductDto>();
        }
        public string UserFullName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public decimal TotalPrice { get; set; }
        public ICollection<CartProductDto> CartProducts { get; set; }
    }
}
