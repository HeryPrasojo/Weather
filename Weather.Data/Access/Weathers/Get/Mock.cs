using System;
using System.Linq;

namespace Weather.Data.Access.Weathers.Get
{
    public class Mock : IGetWeather
    {
        public Model.Weather GetSingle(string cityName)
        {
            if (string.IsNullOrWhiteSpace(cityName))
            {
                throw new Exception("cityName is null or empty or white-space only");
            }

            return Data.Mock.Weathers.weathers.SingleOrDefault(weather => weather.Location == cityName);
        }
    }
}
