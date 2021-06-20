using System.Collections.Generic;

namespace Weather.Services.Cities.Get
{
    public interface IGetCities
    {
        public IEnumerable<City> GetMany(int countryId);
    }
}
