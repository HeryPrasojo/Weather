using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

// move to services?
namespace Weather.Data.Access.Weathers.Get.OpenWeatherMaps
{
    public class OpenWeatherMap : IGetWeather
    {
        private readonly HttpClient httpClient;

        public OpenWeatherMap(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Model.Weather GetSingle(string cityName)
        {
            var getTask = GetSingleAsync(cityName);

            getTask.Wait();

            return getTask.Result;
        }

        private async Task<Model.Weather> GetSingleAsync(string cityName)
        {
            var escapedCityName = Uri.EscapeDataString(cityName);

            var httpResponseMessage = await httpClient.GetAsync($"?q={escapedCityName}&APPID=8c833ca1a110278cac7123ce5772d9ec");

            var contentString = await httpResponseMessage.Content.ReadAsStringAsync();

            var jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            var response = JsonSerializer.Deserialize<Response>(contentString, jsonSerializerOptions);

            var weather = new Model.Weather
            {
                DewPoint = "",
                Location = $"{response.Name} ({response.Id})",
                Pressure = $"{response.Main.Pressure} hPa",
                RelativeHumidity = $"{response.Main.Humidity} %",
                SkyConditions = response.Weather.Select(weather => $"{weather.Main}, {weather.Description} ({weather.Id})"),
                Temperature = $"{response.Main.Temp} Kelvin",
                Time = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(response.Dt).ToString("yyyy-MM-ddTHH:mm:ssK"),
                Visibility = "",
                Wind = $"{response.Wind.Speed} meter/sec",
            };

            return weather;
        }
    }
}
