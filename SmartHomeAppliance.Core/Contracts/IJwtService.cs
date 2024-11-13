namespace SmartHomeAppliance.Core.Contracts
{
    public interface IJwtService
    {
        Task<string> GenerateTokenAsync(string userId);
    }
}
