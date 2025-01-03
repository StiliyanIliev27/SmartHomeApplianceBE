namespace SmartHomeAppliance.Core.Extensions
{
    public static class ActivityMessageFormatter
    {
        public static string Format(string message, params (string Key, string Value)[] parameters)
        {
            foreach (var (key, value) in parameters)
            {
                message = message.Replace($"{{{key}}}", value);
            }
            return message;
        }
    }
}
