using SmartHomeAppliance.Infrastructure.Data.Enums;
using SmartHomeAppliance.Infrastructure.Data.Models;

namespace SmartHomeAppliance.Core.Extensions
{
    public static class ActivityExtensions
    {
        public static Activity CreateActivity(
            ActivityType type,
            string messageTemplate,
            string? userId,
            string? entityId,
            EntityType entityType,
            params (string Key, string Value)[] parameters)
        {
            return new Activity()
            {
                Type = type,
                Message = messageTemplate.FormatActivity(parameters),
                UserId = userId == "Anonymous user" ? null : userId,
                EntityId = entityId == "Anonymous user" ? null : entityId,
                EntityType = entityType,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}
