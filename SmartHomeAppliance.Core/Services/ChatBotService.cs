using Microsoft.EntityFrameworkCore;
using OpenAI.Chat;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Helpers;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Core.Services
{
    public class ChatBotService : IChatBotService
    {
        private readonly IRepository repository;
        private readonly ChatClient client;
        private readonly Dictionary<string, List<ChatMessage>> chatHistories = new();

        public ChatBotService(IRepository repository, ChatClient client)
        {
            this.repository = repository;
            this.client = client;
        }

        public async Task<string> GetProductFeaturesAsync(string prompt, string userId)
        {
            ArgumentNullException.ThrowIfNull(prompt, nameof(prompt));
            ArgumentNullException.ThrowIfNull(userId, nameof(userId));

            // Ensure each user has a chat history
            if (!chatHistories.ContainsKey(userId))
            {
                chatHistories[userId] = new List<ChatMessage>();
            }

            // Check if the prompt is related to products
            if (!IsValidProductQuery(prompt))
            {
                return "I'm here to help with SmartHub product information. Please ask me about features, pricing, or availability.";
            }

            var productData = GetProductInfo();
            var systemMessage = GeneratePrompt.SystemMessage();
            var userMessage = GeneratePrompt.UserMessage(prompt);

            // Add the system and user messages to chat history
            var systemChatMessage = new SystemChatMessage(systemMessage);
            var userChatMessage = new UserChatMessage(userMessage);
            chatHistories[userId].Add(systemChatMessage);
            chatHistories[userId].Add(userChatMessage);

            // Get the full conversation history for context
            var messages = chatHistories[userId];

            // Get the response from OpenAI
            var response = await client.CompleteChatAsync(messages);

            var responseText = response.Value.Content[0].Text;

            // Add the assistant's response to the history
            chatHistories[userId].Add(new AssistantChatMessage(responseText));

            return responseText;
        }

        private bool IsValidProductQuery(string prompt)
        {
            // Simple keyword matching to validate product-related queries
            var validKeywords = new List<string> { "product", "feature", "price", "pricing", "availability", "support", "category", "categories", "stockQuantity", "help", "smart home", "device" };
            var productsNames = repository.AllReadOnly<Product>().Select(p => p.Name).ToList();
            var productsCategories = repository.AllReadOnly<Product>().Select(p => p.GetCategoryNormalized()).ToList();
            validKeywords.AddRange(productsNames);
            validKeywords.AddRange(productsCategories);
            return validKeywords.Any(keyword => prompt.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        }

        private string GetProductInfo()
        {
            var products = repository.AllReadOnly<Product>();
            return string.Join("\n", products.Select(p => $"{p.Name}: {p.Description} (Price: {p.Price}) (Stock Quantity: {p.StockQuantity}) (Category {p.GetCategoryNormalized()})"));
        }
    }
}
