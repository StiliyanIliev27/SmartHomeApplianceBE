using CloudinaryDotNet;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Dashboard;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Users;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Models;
using static SmartHomeAppliance.Common.CustomErrors.GlobalErrors;

namespace SmartHomeAppliance.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository repository;
        private readonly UserManager<ApplicationUser> userManager;
        private ApiResponse apiResponse;
        public AdminService(IRepository repository, UserManager<ApplicationUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
            apiResponse = new ApiResponse();
        }
        public async Task<ApiResponse> AssignRoleAsync(AssignRoleRequestDto assignRoleDto)
        {
            var user = await userManager.FindByIdAsync(assignRoleDto.UserId);
            if(user == null)
            {
                apiResponse.ErrorMessages.Add(UserNotFound);
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var isUserAdmin = await userManager.IsInRoleAsync(user, "Admin");
            if (isUserAdmin)
            {
                if(assignRoleDto.Role == "Admin")
                {
                    apiResponse.ErrorMessages.Add($"Particular user is already in this role!");
                    apiResponse.StatusCode = 400;
                    apiResponse.IsSuccess = false;
                    return apiResponse;
                }
                if(user.FirstName == "Admin")
                {
                    apiResponse.ErrorMessages.Add("You cannot change main admin user role!");
                    apiResponse.StatusCode = 403;
                    apiResponse.IsSuccess = false;
                    return apiResponse;
                }
                if(assignRoleDto.Role == "User" && assignRoleDto.CurrentUserId != "27d78708-8671-4b05-bd5e-17aa91392224")//Main admin id
                {
                    apiResponse.ErrorMessages.Add("You don't have permissions to do this!");
                    apiResponse.StatusCode = 403;
                    apiResponse.IsSuccess = false;
                    return apiResponse;
                }
                else if(assignRoleDto.Role == "User" && assignRoleDto.CurrentUserId == "27d78708-8671-4b05-bd5e-17aa91392224")
                {
                    await userManager.RemoveFromRoleAsync(user, "Admin");
                    apiResponse.Message = $"Successfully removed {user.FirstName} {user.LastName} from Admin role!";
                    apiResponse.StatusCode = 200;
                    apiResponse.IsSuccess = true;
                    return apiResponse;
                }
            }

            if(assignRoleDto.Role.Equals("User"))
            {
                apiResponse.ErrorMessages.Add($"Particular user is already in this role!");
                apiResponse.StatusCode = 400;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var result = await userManager.AddToRoleAsync(user, assignRoleDto.Role);
            if (!result.Succeeded)
            {
                apiResponse.ErrorMessages.Add(result.Errors.ToString()!);
                apiResponse.StatusCode = 400;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            apiResponse.StatusCode = 200;
            apiResponse.Result = user;
            apiResponse.IsSuccess = true;
            apiResponse.Message = $"Role {assignRoleDto.Role} assigned to {user.FirstName} {user.LastName}";

            return apiResponse;               
        }

        public async Task<ApiResponse> GetDashboardAsync()
        {
            var users = await repository.AllReadOnly<ApplicationUser>().ToListAsync();
            var orders = await repository.AllReadOnly<Order>().ToListAsync();
            var products = await repository.AllReadOnly<Product>().ToListAsync();

            int totalUsersCount = users.Count;
            decimal totalRevenue = orders.Sum(o => o.TotalPrice);
            int totalOrdersCount = orders.Count;
            int totalProductsCount = products.Count;

            apiResponse.StatusCode = 200;
            apiResponse.Result = new { totalUsersCount, totalRevenue, totalOrdersCount, totalProductsCount };
            apiResponse.IsSuccess = true;
            return apiResponse;
        }

        public async Task<GetInventoryStatusDto> GetInventoryAsync()
        {
            var products = await repository
                .AllReadOnly<Product>()
                .ToListAsync();

            GetInventoryStatusDto inventoryStatusDto = new();
            foreach(var product in products)
            {
                if(product.StockQuantity < 15)
                {
                    inventoryStatusDto.LowStockItems += 1;
                }
                else if(product.StockQuantity < 1)
                {
                    inventoryStatusDto.OutOfStockItems += 1;
                }
            }

            return inventoryStatusDto;
        }

        public async Task<decimal> GetOverallRatingAsync()
        {
            var reviews = await repository.AllReadOnly<Review>().ToListAsync();
            var reviewsCnt = reviews.Count;

            var reviewsRatingSum = reviews.Sum(r => r.Rating);

            return reviewsRatingSum / reviewsCnt;
        }

        public async Task<IEnumerable<GetActivitiesDto>> GetRecentActivitiesAsync()
        {
            var activities = await repository.AllReadOnly<Activity>()
            .OrderByDescending(a => a.CreatedAt)
            .Select(a => new GetActivitiesDto()
            {
                ActivityDescription = a.Message,
                ActivityCreatedAt = a.CreatedAt.ToString("dd/MM/yyyy HH:mm")
            })
            .Take(3)
            .ToListAsync();

            return activities;
        }

        public async Task<IDictionary<string, GetTopPerformingProductsDto>> GetTopProductsAsync()
        {
            var productsFromOrders = await repository.AllReadOnly<OrdersProducts>()
                .Include(op => op.Product)
                .ToListAsync();

            
            IDictionary<string, GetTopPerformingProductsDto> productsDictionary = 
                new Dictionary<string, GetTopPerformingProductsDto>();

            foreach (var product in productsFromOrders)
            {
                var quantity = product.Quantity;
                var revenue = product.Price * quantity;

                if (!productsDictionary.ContainsKey(product.ProductId))
                {
                    var topPerformingProductDto = new GetTopPerformingProductsDto()
                    {
                        ProductName = product.Product!.Name,
                        SalesCount = quantity,
                        TotalRevenue = revenue
                    };
                    productsDictionary.Add(product.ProductId, topPerformingProductDto);
                }
                else
                {
                    productsDictionary[product.ProductId].SalesCount += quantity;
                    productsDictionary[product.ProductId].TotalRevenue += revenue;
                }
            }

            return productsDictionary
                .OrderByDescending(p => p.Value.SalesCount)
                .ThenByDescending(p => p.Value.TotalRevenue)
                .Take(3)
                .ToDictionary(p => p.Key, p => p.Value);
        }

        public async Task<IEnumerable<GetUsersDataDto>> GetUsersDataAsync()
        {
            var users = await repository.AllReadOnly<ApplicationUser>().ToListAsync();

            if (!users.Any())
            {
                // Можете да върнете празен списък
                return Enumerable.Empty<GetUsersDataDto>();

                // Или да хвърлите custom exception
                // throw new CustomException("No users found in the database");
            }

            var userDtos = new List<GetUsersDataDto>();
            var fifteenMinutesAgo = DateTime.UtcNow.AddMinutes(-15);

            foreach (var user in users)
            {
                var roles = await userManager.GetRolesAsync(user);
                var role = roles.Contains("Admin") ? "Admin" : "User";

                userDtos.Add(new GetUsersDataDto
                {
                    Id = user.Id,
                    ProfilePicture = user.ProfilePictureUrl,
                    FullName = $"{user.FirstName} {user.LastName}",
                    Email = user.Email!,
                    Role = role,
                    IsActive = user.LastLoginDate.HasValue &&
                              user.LastLoginDate.Value >= fifteenMinutesAgo,
                    LastLoginDate = user.LastLoginDate.HasValue
                        ? user.LastLoginDate.Value.ToString("yyyy-MM-dd HH:mm:ss")
                        : string.Empty
                });
            }

            return userDtos;
        }
    }
}
