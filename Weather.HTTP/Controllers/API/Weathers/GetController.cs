using Microsoft.AspNetCore.Mvc;
using System;
using Weather.Services.Weathers.Get;

namespace Weather.HTTP.Controllers.API.Weathers
{
    [Route("api/weathers")]
    [ApiController]
    public class GetController : ControllerBase
    {
        private readonly IGetWeather getWeatherService;

        public GetController(IGetWeather getWeatherService)
        {
            this.getWeatherService = getWeatherService;
        }

        [HttpPost("get-single")]
        public Models.API.Weathers.Get.Weather Get(int cityId)
        {
            if (cityId == default)
            {
                throw new Exception("cityId is default");
            }


            var serviceWeather = getWeatherService.GetSingle(cityId);

            var weather = new Models.API.Weathers.Get.Weather
            {
                Location = serviceWeather.Location,
                Time = serviceWeather.Time,
                DewPoint = serviceWeather.DewPoint,
                Pressure = serviceWeather.Pressure,
                RelativeHumidity = serviceWeather.RelativeHumidity,
                SkyConditions = serviceWeather.SkyConditions,
                Temperature = serviceWeather.Temperature,
                Visibility = serviceWeather.Visibility,
                Wind = serviceWeather.Wind,
            };

            return weather;
        }
    }
}
