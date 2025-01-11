namespace SmartHomeAppliance.Core.Contracts
{
    public interface IChatBotService
    {
        Task<string> GetProductFeaturesAsync(string prompt, string userId);
    }
}
