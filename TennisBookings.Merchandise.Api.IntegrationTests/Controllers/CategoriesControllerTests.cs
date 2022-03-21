using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using TennisBookings.Merchandise.Api.IntegrationTests.Helpers;
using TennisBookings.Merchandise.Api.IntegrationTests.Models;
using Xunit;

using Newtonsoft.Json.Linq;
using System;
using System.Net.Http.Json;

namespace TennisBookings.Merchandise.Api.IntegrationTests.Controllers
{
    public class CategoriesControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public CategoriesControllerTests(WebApplicationFactory<Startup> factory)
        {
            factory.ClientOptions.BaseAddress = new Uri("http://localhost/api/categories");
            _client = factory.CreateClient();
        }



        [Fact]

        public async Task GetAll_ReturnsExpectedResponse()
        {
            var expected = new List<string> { "Accessories", "Bags", "Balls", "Clothing", "Rackets" };
            
            var model = await _client.GetFromJsonAsync<ExpectedCategoriesModel>("");
            
            Assert.NotNull(model?.AllowedCategories);
            Assert.Equal(expected.OrderBy(s => s), model.AllowedCategories.OrderBy(s => s));
        }
    }
}
