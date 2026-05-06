using System.ComponentModel;

namespace IACulinary.Tools
{
    public static class WeatherTool
    {
        [Description("Retrieves the current temperature for a specific location.")]
        public static string GetWeather([Description("The city from which the temperature will be retrieved.")]string location)
        {
            return $"A temperatura em {location} é de 30 graus.";
        }
    }
}
