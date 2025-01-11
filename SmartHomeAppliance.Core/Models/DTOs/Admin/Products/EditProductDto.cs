using Microsoft.AspNetCore.Http;

namespace SmartHomeAppliance.Core.Models.DTOs.Admin.Products
{
    public class EditProductDto : GetAllProductsDto
    {
        public IFormFile? ProductImageFile { get; set; }
    }
}
