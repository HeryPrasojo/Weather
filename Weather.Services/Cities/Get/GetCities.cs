using System;
using System.Collections.Generic;
using System.Linq;

namespace Weather.Services.Cities.Get
{
    public class GetCities : IGetCities
    {
        private readonly Data.Access.Countries.Get.IGetCountries getCountriesDataAccess;
        private readonly Data.Access.Cities.Get.IGetCities getCitiesDataAccess;

        public GetCities(Data.Access.Countries.Get.IGetCountries getCountriesDataAccess, Data.Access.Cities.Get.IGetCities getCitiesDataAccess)
        {
            this.getCitiesDataAccess = getCitiesDataAccess;
            this.getCountriesDataAccess = getCountriesDataAccess;
        }

        public IEnumerable<City> GetMany(int countryId)
        {
            if (countryId == default)
            {
                throw new Exception("countryId is default");
            }


            var anyCountry = getCountriesDataAccess.Any(countryId);
            if (!anyCountry)
            {
                throw new Exception("request countryId is not found");
            }


            var dataAccessCities = getCitiesDataAccess.GetMany(countryId);

            var cities = dataAccessCities.Select(country => new City
            {
                Id = country.Id,
                Name = country.Name,
            });

            return cities;
        }
    }
}
