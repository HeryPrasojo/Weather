using System.Collections.Generic;
using System.Linq;
using Weather.Data.Model;

namespace Weather.Data.Access.Countries.Get
{
    public class Mock : IGetCountries
    {
        public bool Any(int countryId)
        {
            return Data.Mock.Countries.countries.Any(country => country.Id == countryId);
        }

        public IEnumerable<Country> GetMany()
        {
            var countries = Data.Mock.Countries.countries.Select(country => new Country
            {
                Id = country.Id,
                Name = country.Name,
            })
                .OrderBy(country => country.Name);

            return countries;
        }
    }
}
