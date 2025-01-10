using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Technician;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Models;
using static SmartHomeAppliance.Common.CustomErrors.GlobalErrors;

namespace SmartHomeAppliance.Core.Services
{
    public class TechnicianService : ITechnicianService
    {
        private readonly IRepository repository;
        private readonly ApiResponse apiResponse;

        public TechnicianService(IRepository repository)
        {
            this.repository = repository;
            apiResponse = new ApiResponse();
        }

        public async Task<ApiResponse> AddProductAsync(string userId, AddProductDto addProductDto)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(userId);
            if(user is null)
            {
                apiResponse.StatusCode = 404;
                apiResponse.ErrorMessages.Add(UserNotFound);
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var technician = await repository.AllReadOnly<Technician>().FirstOrDefaultAsync(t => t.UserId == userId);
            if (technician is null)
            {
                apiResponse.StatusCode = 400;
                apiResponse.ErrorMessages.Add("Current User is not technician!");
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var isProductExisting = await repository.AllReadOnly<TechnicianProduct>()
                .Where(tp => tp.ProductId == addProductDto.ProductId && tp.TechnicianId == technician.Id)
                .AnyAsync();
            if(isProductExisting)
            {
                apiResponse.StatusCode = 400;
                apiResponse.ErrorMessages.Add("Current technician already has a product of this type!");
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            TechnicianProduct newProduct = new TechnicianProduct()
            {
                TechnicianId = technician.Id,
                ProductId = addProductDto.ProductId,
                InstallationPrice = addProductDto.InstallationPrice
            };

            await repository.AddAsync(newProduct);
            await repository.SaveChangesAsync();

            apiResponse.Message = $"New product was added for technician {user.FirstName} {user.LastName}";
            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 200;
            return apiResponse;
        }

        public async Task<IEnumerable<GetAllTechniciansByProductDto>> GetAllTechniciansByProductId(string productId)
        {
            var technicians = await repository.AllReadOnly<TechnicianProduct>()
                .Include(tp => tp.Product)
                .Include(tp => tp.Technician)
                .Where(tp => tp.ProductId == productId)
                .ToListAsync();

            if (!technicians.Any())
            {
                return Enumerable.Empty<GetAllTechniciansByProductDto>();
            }

            var technicianProductsDto = new HashSet<GetAllTechniciansByProductDto>();
            foreach(var technician in technicians)
            {
                var user = await repository.GetByIdAsync<ApplicationUser>(technician.Technician.UserId);
                var technicianProductDto = new GetAllTechniciansByProductDto()
                {
                    FullName = $"{user!.FirstName} {user.LastName}",
                    Email = user.Email!,
                    ProfileImage = user.ProfilePictureUrl,
                    PhoneNumber = technician.Technician.PhoneNumber,
                    City = technician.Technician.City,
                    Lat = technician.Technician.Lat,
                    Long = technician.Technician.Long,
                    InstallationPrice = technician.InstallationPrice,
                    Product = new TechnicianProductDto()
                    {
                        ProductName = technician.Product.Name,
                        ProductDescription = technician.Product.Description,
                        ProductCategory = technician.Product.GetCategoryNormalized(),
                        ProductImage = technician.Product.ImageUrl
                    }
                };
                technicianProductsDto.Add(technicianProductDto);
            }
                
            return technicianProductsDto;
        }

        public async Task<ApiResponse> RemoveProductAsync(string productId)
        {
            var product = await repository.GetByIdAsync<Product>(productId);
            if(product is null)
            {
                apiResponse.StatusCode = 404;
                apiResponse.ErrorMessages.Add(ProductNotFound);
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var technicianProduct = await repository.All<TechnicianProduct>()
                .Where(tp => tp.ProductId == product.Id).FirstOrDefaultAsync();
            if(technicianProduct is null)
            {
                apiResponse.StatusCode = 400;
                apiResponse.ErrorMessages.Add("Current technician doesn't have this product in the list!");
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            repository.Delete(technicianProduct);
            await repository.SaveChangesAsync();

            apiResponse.StatusCode = 200;
            apiResponse.Message = $"{product.Name} was successfully removed from your list!";
            apiResponse.IsSuccess = true;
            return apiResponse;
        }
    }
}
