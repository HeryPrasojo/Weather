using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Weather.Services.Countries.Get;

namespace Weather.HTTP.Controllers.API.Countries
{
    [Route("api/countries")]
    [ApiController]
    public class GetController : ControllerBase
    {
        private readonly IGetCountries getCountriesService;

        public GetController(IGetCountries getCountriesService)
        {
            this.getCountriesService = getCountriesService;
        }

        [HttpPost("get-many")]
        public IEnumerable<Models.API.Countries.Get.Country> GetMany()
        {
            var serviceCountries = getCountriesService.GetMany();

            var countries = serviceCountries.Select(country => new Models.API.Countries.Get.Country
            {
                Id = country.Id,
                Name = country.Name,
            });

            return countries;
        }
    }
}
