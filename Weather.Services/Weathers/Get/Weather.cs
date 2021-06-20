using System;

namespace Weather.Services.Weathers.Get
{
    public class Weather
    {
        public string Location { get; set; }

        public DateTime Time { get; set; }

        public string Wind { get; set; }

        public string Visibility { get; set; }

        public string SkyConditions { get; set; }

        public string Temperature { get; set; }

        public string DewPoint { get; set; }

        public string RelativeHumidity { get; set; }

        public string Pressure { get; set; }
    }
}
