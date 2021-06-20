using System;
using System.Collections.Generic;
using System.Linq;
using Weather.Data.Model;

namespace Weather.Data.Access.Cities.Get
{
    public class Mock : IGetCities
    {
        public IEnumerable<City> GetMany(int countryId)
        {
            if (countryId == default)
            {
                throw new Exception("countryId is default");
            }

            var cities = Data.Mock.Cities.cities.Where(city => city.CountryId == countryId)
                .Select(city => new City
                {
                    Id = city.Id,
                    CountryId = city.CountryId,
                    Name = city.Name,
                })
                .OrderBy(city => city.Name);

            return cities;
        }

        public City GetSingle(int id)
        {
            return Data.Mock.Cities.cities.SingleOrDefault(city => city.Id == id);
        }
    }
}
