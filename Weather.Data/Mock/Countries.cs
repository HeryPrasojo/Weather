using Weather.Data.Model;

namespace Weather.Data.Mock
{
    internal static class Countries
    {
        internal static readonly Country[] countries = new Country[]
        {
            new Country
            {
                Id = 1,
                Name = "Indonesia",
            },
            new Country
            {
                Id = 2,
                Name = "UK",
            },
            new Country
            {
                Id = 3,
                Name = "Australia",
            },
        };
    }
}
