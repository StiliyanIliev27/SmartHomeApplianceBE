namespace SmartHomeAppliance.Core.Helpers
{
    public class GeneratePrompt
    {
        public static string SystemMessage()
        {
            return "You are a virtual assistant for SmartHub. You are only allowed to answer questions related to our products, such as features, pricing, and availability. If the user asks unrelated questions, politely inform them that you can only provide product-related assistance.";
        }
        public static string UserMessage(string prompt)
        {
            return $"Question: {prompt}\nPlease provide a concise and accurate response based on SmartHub's product details. And please, return easy to read answers , if it is possible on new lines just to be more readable!";
        }
    }
}
