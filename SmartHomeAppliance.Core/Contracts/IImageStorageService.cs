using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace SmartHomeAppliance.Core.Contracts
{
    public interface IImageStorageService
    {
        Task<string> UploadImageAsync(IFormFile file);
        Task<DeletionResult> DeleteImageAsync(string imageId);
    }
}
