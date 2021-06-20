using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Weather.Services.Cities.Get;

namespace Weather.HTTP.Controllers.API.Cities
{
    [Route("api/cities")]
    [ApiController]
    public class GetController : ControllerBase
    {
        private readonly IGetCities getCitiesService;

        public GetController(IGetCities getCitiesService)
        {
            this.getCitiesService = getCitiesService;
        }

        [HttpPost("get-many")]
        public IEnumerable<Models.API.Cities.Get.City> GetMany(int countryId)
        {
            if (countryId == default)
            {
                throw new Exception("request is default");
            }


            var serviceCities = getCitiesService.GetMany(countryId);

            var cities = serviceCities.Select(city => new Models.API.Cities.Get.City
            {
                Id = city.Id,
                Name = city.Name,
            });

            return cities;
        }
    }
}
