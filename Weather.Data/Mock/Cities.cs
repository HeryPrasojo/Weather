using Weather.Data.Model;

namespace Weather.Data.Mock
{
    internal static class Cities
    {
        internal static readonly City[] cities = new City[]
        {
            new City
            {
                Id = 1,
                CountryId = 1,
                Name = "Jakarta",
            },
            new City
            {
                Id = 2,
                CountryId = 1,
                Name = "Denpasar",
            },
            new City
            {
                Id = 3,
                CountryId = 1,
                Name = "Yogyakarta",
            },
            new City
            {
                Id = 4,
                CountryId = 2,
                Name = "London",
            },
            new City
            {
                Id = 5,
                CountryId = 2,
                Name = "Liverpool",
            },
            new City
            {
                Id = 6,
                CountryId = 2,
                Name = "Manchester",
            },
            new City
            {
                Id = 7,
                CountryId = 3,
                Name = "Canberra",
            },
            new City
            {
                Id = 8,
                CountryId = 3,
                Name = "Sydney",
            },
            new City
            {
                Id = 9,
                CountryId = 3,
                Name = "Melbourne",
            },
        };
    }
}
