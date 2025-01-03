namespace SmartHomeAppliance.Core.Extensions
{
    public static class StringExtensions
    {
        public static string FormatActivity(this string message, params (string Key, string Value)[] parameters)
        {
            return ActivityMessageFormatter.Format(message, parameters);
        }
    }
}
