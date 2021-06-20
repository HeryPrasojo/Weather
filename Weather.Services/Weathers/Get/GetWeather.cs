using System;
using System.Linq;

namespace Weather.Services.Weathers.Get
{
    public class GetWeather : IGetWeather
    {
        private readonly Data.Access.Weathers.Get.IGetWeather getWeatherDataAccess;
        private readonly Data.Access.Cities.Get.IGetCities getCitiesDataAccess;

        public GetWeather(Data.Access.Weathers.Get.IGetWeather getWeatherDataAccess, Data.Access.Cities.Get.IGetCities getCitiesDataAccess)
        {
            this.getCitiesDataAccess = getCitiesDataAccess;
            this.getWeatherDataAccess = getWeatherDataAccess;
        }

        public Weather GetSingle(int cityId)
        {
            if (cityId == default)
            {
                throw new Exception("cityId is default");
            }


            var city = getCitiesDataAccess.GetSingle(cityId);
            if (city == default)
            {
                throw new Exception("cityId not found");
            }

            var dataAccessWeather = getWeatherDataAccess.GetSingle(city.Name);
            if (dataAccessWeather == default)
            {
                return default;
            }

            var weather = new Weather
            {
                Location = dataAccessWeather.Location,
                Time = dataAccessWeather.Time,
                DewPoint = dataAccessWeather.DewPoint,
                Pressure = dataAccessWeather.Pressure,
                RelativeHumidity = dataAccessWeather.RelativeHumidity,
                SkyConditions = dataAccessWeather.SkyConditions,
                Temperature = dataAccessWeather.Temperature,
                Visibility = dataAccessWeather.Visibility,
                Wind = dataAccessWeather.Wind,
            };

            return weather;
        }
    }
}
