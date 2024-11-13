namespace SmartHomeAppliance.Core.Contracts
{
    public interface IJwtService
    {
        string GenerateToken(string userId);
    }
}
