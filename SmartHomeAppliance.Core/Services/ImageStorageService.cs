using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using SmartHomeAppliance.Common.Settings;
using SmartHomeAppliance.Core.Contracts;

namespace SmartHomeAppliance.Core.Services
{
    public class ImageStorageService : IImageStorageService
    {
        private readonly ICloudinary cloudinary;

        public ImageStorageService(IOptions<CloudinarySettings> config)
        {
            var account = new Account(
                config.Value.CloudName, 
                config.Value.ApiKey, 
                config.Value.ApiSecret
            );

            cloudinary = new Cloudinary(account);
        }
        public async Task<DeletionResult> DeleteImageAsync(string imageId)
        {
            var deleteParams = new DeletionParams(imageId);
            return await cloudinary.DestroyAsync(deleteParams);
        }

        public async Task<string> UploadImageAsync(IFormFile file)
        {
            var uploadResult = new ImageUploadResult();

            if (file.Length > 0)
            {
                using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream),
                    Transformation = new Transformation()
                        .Height(500)
                        .Width(500)
                        .Crop("fill")
                        .Gravity("face"),
                    Folder = "homecraft-app"
                };

                uploadResult = await cloudinary.UploadAsync(uploadParams);
            }

            return uploadResult.SecureUrl.ToString();
        }
    }
}
