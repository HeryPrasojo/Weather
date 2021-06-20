using System;
using System.Net.Http;
using Xunit;

namespace Weather.Test
{
    public class GetWeather_OpenWeatherMap_GetSingle
    {
        [Fact]
        public void GetSingle_NotNull()
        {
            var getCitiesDataAccess = new Data.Access.Cities.Get.Mock();

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/weather"),
            };
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var dataAccess = new Data.Access.Weathers.Get.OpenWeatherMaps.OpenWeatherMap(httpClient);

            var service = new Services.Weathers.Get.GetWeather(dataAccess, getCitiesDataAccess);

            var result = service.GetSingle(1);

            Assert.NotNull(result);
        }
    }
}
