using System;

namespace Weather.Data.Mock
{
    internal static class Weathers
    {
        internal static readonly Model.Weather[] weathers = new Model.Weather[]
        {
            new Model.Weather
            {
                Location = "Jakarta",
                Time = DateTime.UtcNow.ToString(),
                Wind             = "Jakarta Wind",
                DewPoint         = "Jakarta DewPoint",
                RelativeHumidity = "Jakarta RelativeHumidity",
                Pressure         = "Jakarta Pressure",
                SkyConditions    = new string[] { "Jakarta SkyConditions" },
                Temperature      = "Jakarta Temperature",
                Visibility       = "Jakarta Visibility",
            },
            new Model.Weather
            {
                Location = "Denpasar",
                Time = DateTime.UtcNow.ToString(),
                Wind             = "Denpasar Wind",
                DewPoint         = "Denpasar DewPoint",
                RelativeHumidity = "Denpasar RelativeHumidity",
                Pressure         = "Denpasar Pressure",
                SkyConditions    = new string[] { "Denpasar SkyConditions" },
                Temperature      = "Denpasar Temperature",
                Visibility       = "Denpasar Visibility",
           },
            new Model.Weather
            {
                Location = "Yogyakarta",
                Time = DateTime.UtcNow.ToString(),
                Wind             = "Yogyakarta Wind",
                DewPoint         = "Yogyakarta DewPoint",
                RelativeHumidity = "Yogyakarta RelativeHumidity",
                Pressure         = "Yogyakarta Pressure",
                SkyConditions    = new string[] { "Yogyakarta SkyConditions" },
                Temperature      = "Yogyakarta Temperature",
                Visibility       = "Yogyakarta Visibility",
            },
            new Model.Weather
            {
                Location = "London",
                Time = DateTime.UtcNow.ToString(),
                Wind             = "London Wind",
                DewPoint         = "London DewPoint",
                RelativeHumidity = "London RelativeHumidity",
                Pressure         = "London Pressure",
                SkyConditions    = new string[] { "London SkyConditions" },
                Temperature      = "London Temperature",
                Visibility       = "London Visibility",
            },
            new Model.Weather
            {
                Location = "Liverpool",
                Time = DateTime.UtcNow.ToString(),
                Wind             = "Liverpool Wind",
                DewPoint         = "Liverpool DewPoint",
                RelativeHumidity = "Liverpool RelativeHumidity",
                Pressure         = "Liverpool Pressure",
                SkyConditions    = new string[] { "Liverpool SkyConditions" },
                Temperature      = "Liverpool Temperature",
                Visibility       = "Liverpool Visibility",
            },
            new Model.Weather
            {
                Location = "Manchester",
                Time = DateTime.UtcNow.ToString(),
                Wind             = "Manchester Wind",
                DewPoint         = "Manchester DewPoint",
                RelativeHumidity = "Manchester RelativeHumidity",
                Pressure         = "Manchester Pressure",
                SkyConditions    = new string[] { "Manchester SkyConditions" },
                Temperature      = "Manchester Temperature",
                Visibility       = "Manchester Visibility",
            },
            new Model.Weather
            {
                Location = "Canberra",
                Time = DateTime.UtcNow.ToString(),
                Wind             = "Canberra Wind",
                DewPoint         = "Canberra DewPoint",
                RelativeHumidity = "Canberra RelativeHumidity",
                Pressure         = "Canberra Pressure",
                SkyConditions    = new string[] { "Canberra SkyConditions" },
                Temperature      = "Canberra Temperature",
                Visibility       = "Canberra Visibility",
           },
            new Model.Weather
            {
                Location = "Sydney",
                Time = DateTime.UtcNow.ToString(),
                Wind             = "Sydney Wind",
                DewPoint         = "Sydney DewPoint",
                RelativeHumidity = "Sydney RelativeHumidity",
                Pressure         = "Sydney Pressure",
                SkyConditions    = new string[] { "Sydney SkyConditions" },
                Temperature      = "Sydney Temperature",
                Visibility       = "Sydney Visibility",
           },
            new Model.Weather
            {
                Location = "Melbourne",
                Time = DateTime.UtcNow.ToString(),
                Wind             = "Melbourne Wind",
                DewPoint         = "Melbourne DewPoint",
                RelativeHumidity = "Melbourne RelativeHumidity",
                Pressure         = "Melbourne Pressure",
                SkyConditions    = new string[] { "Melbourne SkyConditions" },
                Temperature      = "Melbourne Temperature",
                Visibility       = "Melbourne Visibility",
          },
        };
    }
}
