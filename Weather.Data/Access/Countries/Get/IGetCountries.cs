using System.Collections.Generic;
using Weather.Data.Model;

namespace Weather.Data.Access.Countries.Get
{
    public interface IGetCountries
    {
        public bool Any(int countryId);

        public IEnumerable<Country> GetMany();
    }
}
