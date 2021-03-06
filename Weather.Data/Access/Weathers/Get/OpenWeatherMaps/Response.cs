using System.Collections.Generic;

namespace Weather.Data.Access.Weathers.Get.OpenWeatherMaps
{
    public class Response
    {
        public Coord Coord { get; set; }

        public IEnumerable<Weather> Weather { get; set; }

        public string Base { get; set; }

        public Main Main { get; set; }

        public int Visibility { get; set; }

        public Wind Wind { get; set; }

        public Clouds Clouds { get; set; }

        public int Dt { get; set; }

        public Sys Sys { get; set; }

        public int TimeZone { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Cod { get; set; }
    }
}
