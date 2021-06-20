using System.Collections.Generic;
using System.Linq;

namespace Weather.Services.Countries.Get
{
    public class GetCountries : IGetCountries
    {
        private readonly Data.Access.Countries.Get.IGetCountries getCountriesDataAccess;

        public GetCountries(Data.Access.Countries.Get.IGetCountries getCountriesDataAccess)
        {
            this.getCountriesDataAccess = getCountriesDataAccess;
        }

        public IEnumerable<Country> GetMany()
        {
            var dataAccessCountries = getCountriesDataAccess.GetMany();

            var countries = dataAccessCountries.Select(country => new Country
            {
                Id = country.Id,
                Name = country.Name,
            });

            return countries;
        }
    }
}
