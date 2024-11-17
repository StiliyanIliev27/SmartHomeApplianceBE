using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Product;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;
using static SmartHomeAppliance.Common.CustomErrors.GlobalErrors;

namespace SmartHomeAppliance.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repository;
        private readonly ILogger<ProductService> logger;
        private ApiResponse apiResponse;
        public ProductService(IRepository repository, ILogger<ProductService> logger)
        {
            this.repository = repository;
            this.logger = logger;
            apiResponse = new ApiResponse();
        }
        public async Task<ApiResponse> AllProductsByFilterAsync(string? category, 
            decimal? minPrice, decimal? maxPrice, string? searchTerm, int page = 1, int pageSize = 10)
        {
            logger.LogInformation("AllProductsAsync has been called");

            var query = repository.AllReadOnly<Product>().AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(p => p.Category.ToString() == category);
            }

            if (minPrice.HasValue)
            {
                query = query.Where(p => p.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                query = query.Where(p => p.Price <= maxPrice.Value);
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p => p.Name.Contains(searchTerm) || p.Description.Contains(searchTerm));
            }

            // Pagination
            var totalItems = await query.CountAsync();
            var products = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();


            if (!products.Any())
            {
                apiResponse.ErrorMessages.Add("No available products with this criteria have been found!");
                apiResponse.StatusCode = 404;
                return apiResponse;
            }
            
            apiResponse.Message = $"Products count: {products.Count}";
            apiResponse.Result = products;
            apiResponse.StatusCode = 200;
            apiResponse.IsSuccess = true;
            return apiResponse;
        }

        public async Task<ApiResponse> CreateProductAsync(CreateProductDto productDto, string creatorId)
        {
            logger.LogInformation("CreateProductAsync has been called");

            if (await repository.AllReadOnly<Product>().AnyAsync(p => p.Name == productDto.Name))
            {
                apiResponse.ErrorMessages.Add($"Product with name: \"{productDto.Name}\" already exists!");
                apiResponse.StatusCode = 400;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            Category category;
            _ = Enum.TryParse(productDto.Category, out category);

            var product = new Product()
            {
                Name = productDto.Name,
                CreatorId = creatorId,
                Price = productDto.Price,
                Category = category,
                DateCreated = DateTime.Now,
                Description = productDto.Description,
                ImageUrl = productDto.ImageUrl,
                StockQuantity = productDto.StockQuantity,
            };

            await repository.AddAsync(product);
            await repository.SaveChangesAsync();

            apiResponse.StatusCode = 201;
            apiResponse.IsSuccess = true;
            apiResponse.Result = product;
            apiResponse.Message = $"Procuct has been successfully created with Id: {product.Id}";
            return apiResponse;
        }

        public async Task<ApiResponse> DeleteProductAsync(string productId)
        {
            logger.LogInformation("DeleteProductAsync has been called");

            var product = await repository.All<Product>().FirstOrDefaultAsync(p => p.Id.ToString() == productId);
            if(product == null)
            {
                apiResponse.ErrorMessages.Add(ProductNotFound);
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var reviews = await repository.All<Review>()
                .Where(r => r.ProductId == productId).ToListAsync();
            
            if (!reviews.Any())
                logger.LogInformation($"No reviews were found for product with Id: {productId}");
            else
            {
                foreach (var review in reviews)
                    repository.Delete(review);
                logger.LogInformation($"All reviews for product with Id: {productId} have been deleted successfully.");
            }

            var cartProducts = await repository.All<CartsProduct>()
                .Where(o => o.ProductId == productId).ToListAsync();

            if (!cartProducts.Any())
                logger.LogInformation($"No products in any carts were found for product with Id: {productId}");
            else
            {
                foreach (var cartProduct in cartProducts)
                    repository.Delete(cartProduct);
                logger.LogInformation($"All carts with product with Id: {productId} have been deleted successfully.");
            }


            repository.Delete(product);
            await repository.SaveChangesAsync();

            apiResponse.Message = $"Product with Id: {product.Id} has been deleted successfully.";
            apiResponse.StatusCode = 204;
            apiResponse.IsSuccess = true;
            return apiResponse;
        }

        public async Task<Product> GetProductByIdAsync(string productId)
        {
            return await repository.GetByIdAsync<Product>(productId) ?? throw new ArgumentException("Product was not found.");
        }

        public async Task<ApiResponse> UpdateProductAsync(UpdateProductDto updatedProductDto)
        {
            logger.LogInformation("UpdateProductAsync has been called");

            var product = await repository.All<Product>().FirstOrDefaultAsync(p => p.Id.ToString() == updatedProductDto.ProductId);
            if (product == null)
            {
                apiResponse.ErrorMessages.Add(ProductNotFound);
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            Category category;
            _ = Enum.TryParse(updatedProductDto.Category, out category);

            product.Name = updatedProductDto.Name;
            product.Description = updatedProductDto.Description;
            product.Price = updatedProductDto.Price;
            product.Category = category;
            product.ImageUrl = updatedProductDto.ImageUrl;
            product.StockQuantity = updatedProductDto.StockQuantity;

            await repository.UpdateAsync(product);
            await repository.SaveChangesAsync();

            apiResponse.Message = $"Product with Id: {updatedProductDto.ProductId} has been successfully updated.";
            apiResponse.StatusCode = 200;
            apiResponse.IsSuccess = true;
            apiResponse.Result = product;
            return apiResponse;
        }
    }
}
