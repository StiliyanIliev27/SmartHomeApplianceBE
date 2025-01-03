namespace SmartHomeAppliance.Common
{
    public static class GlobalConstants
    {
        public static class ActivityMessages
        {
            // User related activities
            public const string UserRegistrationSuccess = "User registered successfully with email: {email}";
            public const string UserLoginSuccess = "User logged in successfully with email: {email}";
            public const string UserLoginFailed = "Failed login attempt for email: {email}";
            public const string UserPasswordChanged = "Password changed for user: {email}";
            public const string UserProfileUpdated = "Profile updated for user: {email}";

            // Order related activities
            public const string OrderCreated = "Order #{orderId} created by user: {email}";
            public const string OrderUpdated = "Order #{orderId} updated. Status changed to: {status}";
            public const string OrderCancelled = "Order #{orderId} cancelled. Reason: {reason}";
            public const string OrderPaymentReceived = "Payment received for order #{orderId}. Amount: ${amount}";

            // Product related activities
            public const string ProductCreated = "Product '{productName}' created with ID: {productId}";
            public const string ProductUpdated = "Product '{productName}' (ID: {productId}) updated";
            public const string ProductDeleted = "Product '{productName}' (ID: {productId}) deleted";
            public const string ProductPriceChanged = "Price updated for product '{productName}' from ${oldPrice} to ${newPrice}";
            public const string ProductStockUpdated = "Stock updated for product '{productName}'. New quantity: {quantity}";
        }
    }
}
