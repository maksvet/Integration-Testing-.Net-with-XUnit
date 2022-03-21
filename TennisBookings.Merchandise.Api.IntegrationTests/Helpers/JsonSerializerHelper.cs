using System.Text.Json;

namespace TennisBookings.Merchandise.Api.IntegrationTests.Helpers
{
    public static class JsonSerializerHelper
    {
        public static JsonSerializerOptions DefaultSerialisationOptions => new JsonSerializerOptions
        {
            IgnoreNullValues = true,
            PropertyNameCaseInsensitive = true
        };
        public static JsonSerializerOptions DefaultSerializerOptions => new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

    }
}
