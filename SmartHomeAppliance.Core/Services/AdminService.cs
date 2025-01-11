using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Dashboard;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Orders;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Products;
using SmartHomeAppliance.Core.Models.DTOs.Admin.Users;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;
using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;
using static SmartHomeAppliance.Common.CustomErrors.GlobalErrors;

namespace SmartHomeAppliance.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository repository;
        private readonly IPaymentService paymentService;
        private readonly IImageStorageService imageStorageService;
        private readonly UserManager<ApplicationUser> userManager;
        private ApiResponse apiResponse;
        public AdminService(IRepository repository, 
            UserManager<ApplicationUser> userManager, 
            IImageStorageService imageStorageService,
            IPaymentService paymentService)
        {
            this.repository = repository;
            this.userManager = userManager;
            this.imageStorageService = imageStorageService;
            this.paymentService = paymentService;
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

        public async Task<ApiResponse> DeleteUserAsync(string userId)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(userId);
            if(user is null)
            {
                apiResponse.ErrorMessages.Add(UserNotFound);
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }
            if(user.FirstName == "Admin")
            {
                apiResponse.ErrorMessages.Add("You don't have permission to do this action!");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 403;
                return apiResponse;
            }

            var orderProducts = await repository.All<OrdersProducts>()
                .Where(op => op.UserId == user.Id).ToListAsync();
            foreach(var orderProduct in orderProducts)
            {
                repository.Delete(orderProduct);
            }

            await repository.SaveChangesAsync();

            var orders = await repository.All<Order>()
                .Where(op => op.UserId == user.Id).ToListAsync();
            foreach (var order in orders)
            {
                repository.Delete(order);
            }

            await repository.SaveChangesAsync();

            await userManager.DeleteAsync(user);

            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 200;
            apiResponse.Message = $"User with email: {user.Email} was successfully deleted!";
            return apiResponse;     
        }

        private async Task DeleteCurrentProductImageAsync(Product product)
        {
            int startIndex = product.ImageUrl.IndexOf("homecraft");
            int endIndex = product.ImageUrl.LastIndexOf('.');

            string productImageIdCloud = product.ImageUrl.Substring(startIndex, endIndex - startIndex);

            var result = await imageStorageService.DeleteImageAsync(productImageIdCloud);
            
            product.ImageUrl = string.Empty;
            await repository.UpdateAsync(product);
            await repository.SaveChangesAsync();
        }

        public async Task<ApiResponse> EditProductAsync(EditProductDto editProductDto)
        {
            var product = await repository.GetByIdAsync<Product>(editProductDto.Id!);
            if(product is null)
            {
                apiResponse.ErrorMessages.Add(ProductNotFound);
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            if(editProductDto.ProductImage == null)
            {
                if(product.ImageUrl != string.Empty)
                {
                    await DeleteCurrentProductImageAsync(product);
                }
            }

            string newImageUrl = string.Empty;
            if (editProductDto.ProductImageFile != null)
            {
                if (product.ImageUrl != string.Empty)
                {
                    await DeleteCurrentProductImageAsync(product);
                }
                newImageUrl = await imageStorageService.UploadImageAsync(editProductDto.ProductImageFile);
            }

            product.Name = editProductDto.ProductName;
            product.Price = editProductDto.Price;
            product.Category = GetCategoryEnumValue(editProductDto.Category);
            product.StockQuantity = editProductDto.StockQuantity;
            product.Description = editProductDto.Description;
            product.ImageUrl = newImageUrl != string.Empty ? newImageUrl : product.ImageUrl;

            await repository.UpdateAsync(product);
            await repository.SaveChangesAsync();

            apiResponse.Message = $"Product with id: {product.Id} was succesfully updated";
            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 200;
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

        public async Task<IEnumerable<GetAllProductsDto>> GetProductsAsync()
        {
            return await repository.AllReadOnly<Product>()
                .Select(p => new GetAllProductsDto()
                {
                    Id = p.Id,
                    ProductName = p.Name,
                    ProductImage = p.ImageUrl,
                    StockQuantity = p.StockQuantity,
                    Description = p.Description,
                    Price = p.Price,
                    Category = p.GetCategoryNormalized()
                })
                .ToListAsync();
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

        private Category GetCategoryEnumValue(string category)
        {
            Category categoryEnum = Category.EnergyManagement; //default

            switch (category)
            {
                case "Energy Management":
                    categoryEnum = Category.EnergyManagement;
                    break;
                case "Cleaning And Household":
                    categoryEnum = Category.CleaningAndHousehold;
                    break;
                case "Heating And Cooling":
                    categoryEnum = Category.HealthAndFitness;
                    break;
                case "Kitchen Appliances":
                    categoryEnum = Category.KitchenAppliances;
                    break;
                case "Lighting And Ambiance":
                    categoryEnum = Category.LightingAndAmbiance;
                    break;
                case "Outdoor And Garden":
                    categoryEnum = Category.OutdoorAndGarden;
                    break;
                case "Security And Surveillance":
                    categoryEnum = Category.SecurityAndSurveillance;
                    break;
                case "Smart Hubs And Controllers":
                    categoryEnum = Category.SmartHubsAndControllers;
                    break;
            }

            return categoryEnum;
        }

        public async Task<ApiResponse> AddProductAsync(EditProductDto addProductDto, string creatorId)
        {
            var productExists = await repository.AllReadOnly<Product>()
                .Where(p => p.Name == addProductDto.ProductName).AnyAsync();
            if (productExists)
            {
                apiResponse.ErrorMessages.Add($"Product with name {addProductDto.ProductName} already exists!");
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 400;
                return apiResponse;
            }

            string imageUrl = string.Empty;
            if(addProductDto.ProductImageFile != null)
            {
                imageUrl = await imageStorageService.UploadImageAsync(addProductDto.ProductImageFile);
            }

            Product product = new Product()
            {
                Name = addProductDto.ProductName,
                StockQuantity = addProductDto.StockQuantity,
                Category = GetCategoryEnumValue(addProductDto.Category),
                CreatorId = creatorId,
                DateCreated = DateTime.Now,
                Description = addProductDto.Description,
                ImageUrl = imageUrl,
                Price = addProductDto.Price
            };

            await repository.AddAsync(product);
            await repository.SaveChangesAsync();


            apiResponse.Message = $"New product was successfully added to the store";
            apiResponse.StatusCode = 200;
            apiResponse.IsSuccess = true;
            return apiResponse;
        }

        private async Task DeleteOrdersProducts(Product product)
        {
            var orderProducts = await repository.All<OrdersProducts>()
                .Where(op => op.ProductId == product.Id).ToListAsync();

            foreach(var orderProduct in orderProducts)
            {
                repository.Delete(orderProduct);
                
                var orders = await repository.All<Order>()
                    .Where(o => o.OrderId == orderProduct.OrderId).ToListAsync();
                foreach(var order in orders)
                {
                    repository.Delete(order);
                }
            }

            var cartProducts = await repository.All<CartsProduct>()
                .Where(cp => cp.ProductId == product.Id).ToListAsync();

            foreach (var cartProduct in cartProducts)
            {
                repository.Delete(cartProduct);

                var carts = await repository.All<Cart>()
                    .Where(c => c.Id == cartProduct.CartId).ToListAsync();
                foreach (var cart in carts)
                {
                    repository.Delete(cart);
                }
            }

            var reviews = await repository.All<Review>()
                .Where(r => r.ProductId == product.Id).ToListAsync();
            foreach (var review in reviews)
            {
                repository.Delete(review);
            }

            await repository.SaveChangesAsync();
        }

        public async Task<ApiResponse> DeleteProductAsync(string productId)
        {
            var product = await repository.GetByIdAsync<Product>(productId);

            if(product is null)
            {
                apiResponse.StatusCode = 404;
                apiResponse.ErrorMessages.Add(ProductNotFound);
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            await DeleteOrdersProducts(product);

            if(product.ImageUrl != string.Empty)
            {
                await DeleteCurrentProductImageAsync(product);
            }
            
            repository.Delete(product);
            await repository.SaveChangesAsync();

            apiResponse.Message = $"Product with id: {product.Id} was successfully deleted";
            apiResponse.StatusCode = 200;
            apiResponse.IsSuccess = true;
            return apiResponse;
        }

        public async Task<IEnumerable<GetOrdersDto>> GetOrdersAsync()
        {
            return await repository.AllReadOnly<Order>()
                .Include(o => o.User)
                .Select(o => new GetOrdersDto()
                {
                    OrderId = o.OrderId,
                    CustomerFullName = $"{o.User!.FirstName} {o.User.LastName}",
                    CustomerEmail = o.User!.Email!,
                    CustomerProfilePicture = o.User.ProfilePictureUrl,
                    TotalPrice = o.TotalPrice,
                    OrderStatus = o.OrderStatus.ToString(),
                    PaymentStatus = o.PaymentStatus.ToString(),
                    OrderDate = o.OrderDate.ToString("dd/MM/yyyy HH:mm")
                })
                .ToListAsync();
        }

        public async Task<ApiResponse> GetOrderDetailsByIdAsync(string orderId)
        {
            var order = await repository.AllReadOnly<Order>()
                .Include(o => o.User)
                .Where(o => o.OrderId == orderId).FirstOrDefaultAsync();
            if(order is null)
            {
                apiResponse.ErrorMessages.Add("Order was not found!");
                apiResponse.StatusCode = 404;
                apiResponse.IsSuccess = false;
                return apiResponse;
            }

            var orderProducts = await repository.AllReadOnly<OrdersProducts>()
                .Include(op => op.Product)
                .Where(op => op.OrderId == orderId)
                .ToListAsync();

            ICollection<GetProductDetailsDto> products = new HashSet<GetProductDetailsDto>();
            foreach(var orderProduct in orderProducts)
            {
                var productDto = new GetProductDetailsDto()
                {
                    ProductName = orderProduct.Product!.Name,
                    PricePerProduct = orderProduct.Price,
                    ProductCategory = orderProduct.Product.GetCategoryNormalized(),
                    ProductImage = orderProduct.Product.ImageUrl,
                    Quantity = orderProduct.Quantity
                };

                products.Add(productDto);
            }

            GetOrderDetails orderDetails = new GetOrderDetails
            {
                OrderId = order.OrderId,
                CustomerFullName = $"{order.User!.FirstName} {order.User.LastName}",
                CustomerEmail = order.User!.Email!,
                CustomerProfilePicture = order.User.ProfilePictureUrl,
                TotalPrice = order.TotalPrice,
                OrderStatus = order.OrderStatus.ToString(),
                PaymentStatus = order.PaymentStatus.ToString(),
                OrderDate = order.OrderDate.ToString("dd/MM/yyyy HH:mm"),
                Products = products,
                StripePaymentDetails = await paymentService.GetStripePaymentDetails(order.StripePaymentIntentId!)
            };

            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 200;
            apiResponse.Result = orderDetails;
            return apiResponse;
        }

        public async Task<ApiResponse> UpdateOrderStatusAsync(UpdateOrderStatusDto updateStatusDto)
        {
            var order = await repository.All<Order>()
                .Where(o => o.OrderId == updateStatusDto.OrderId).FirstOrDefaultAsync();
            if(order is null)
            {
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 404;
                apiResponse.ErrorMessages.Add("Order was not found!");
                return apiResponse;
            }

            OrderStatus orderStatus;
            if(!Enum.TryParse(updateStatusDto.OrderStatus, out orderStatus))
            {
                apiResponse.IsSuccess = false;
                apiResponse.StatusCode = 400;
                apiResponse.ErrorMessages.Add("Something went wrong with parsing order status!");
                return apiResponse;
            }

            order.OrderStatus = orderStatus;
            await repository.UpdateAsync(order);
            await repository.SaveChangesAsync();

            apiResponse.IsSuccess = true;
            apiResponse.StatusCode = 200;
            apiResponse.Message = $"Order with id: {order.OrderId} was successfully updated its status!";
            return apiResponse;
        }
    }
}
