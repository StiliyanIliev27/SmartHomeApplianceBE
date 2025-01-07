namespace SmartHomeAppliance.Core.Models.DTOs.Admin.Orders
{
    public class GetOrderDetails : GetOrdersDto
    {
        public IEnumerable<GetProductDetailsDto>? Products { get; set; }
        public StripePaymentDetails? StripePaymentDetails { get; set; }
    }
}
