using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Core.Models.Responses;
using SmartHomeAppliance.Infrastructure.Common;

namespace SmartHomeAppliance.Core.Services
{
    public class TechnicianService : ITechnicianService
    {
        private readonly IRepository repository;
        private readonly ApiResponse response;

        public TechnicianService(IRepository repository)
        {
            this.repository = repository;
            response = new ApiResponse();
        }
    }
}
