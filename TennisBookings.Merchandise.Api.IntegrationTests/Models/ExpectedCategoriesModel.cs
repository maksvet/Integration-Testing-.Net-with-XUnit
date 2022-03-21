using System.Collections.Generic;
using Newtonsoft.Json;
namespace TennisBookings.Merchandise.Api.IntegrationTests.Models
{
    public class ExpectedCategoriesModel
    {
        [JsonProperty("allowedCategories")]
        public string[] AllowedCategories { get; set; }
    }
}
