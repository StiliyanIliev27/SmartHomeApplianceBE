namespace SmartHomeAppliance.Infrastructure.Data.Enums
{
    public enum OrderStatus
    {
        Pending = 0,       // Order has been created but not yet processed
        Processing = 1,     // Order has been confirmed and is being prepared
        Shipped = 2,       // Order has been dispatched to the customer
        Delivered = 3,     // Order has been delivered to the customer
        Cancelled = 4      // Order has been canceled by the customer or system
    }
}
