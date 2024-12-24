namespace SmartHomeAppliance.Common.ValidationConstants
{
    public static class ValidationConstants
    {
        public static class Product
        {
            public const int ProductMinRatingValue = 1;
            public const int ProductMaxRatingValue = 5;
            public const string ProductRatingErrorMessage = $"Product must have rating between 1 and 5 stars";
        }
    }
}
