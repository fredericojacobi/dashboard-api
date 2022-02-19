using Microsoft.Extensions.Configuration;

namespace Generics.Settings
{
    public static class Configuration
    {
        public static string GetConfiguration(string section) =>
            new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true)
                .Build()?.GetSection(section)?.Value;
    }
}