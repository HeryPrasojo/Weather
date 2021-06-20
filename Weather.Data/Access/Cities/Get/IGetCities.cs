using System.Collections.Generic;
using Weather.Data.Model;

namespace Weather.Data.Access.Cities.Get
{
    public interface IGetCities
    {
        public IEnumerable<City> GetMany(int countryId);

        public City GetSingle(int id);
    }
}
