using SmartHomeAppliance.Core.Models.DTOs.Auth;
using SmartHomeAppliance.Core.Models.Responses;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IAuthService
    {
        Task<ApiResponse> RegisterAsync(RegisterDTO registerModel);
        Task<ApiResponse> LoginAsync(LoginDTO loginModel);
    }
}
