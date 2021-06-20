using System.Collections.Generic;

namespace Weather.Services.Countries.Get
{
    public interface IGetCountries
    {
        public IEnumerable<Country> GetMany();
    }
}
