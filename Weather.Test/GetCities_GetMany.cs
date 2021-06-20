using Xunit;

namespace Weather.Test
{
    public class GetCities_GetMany
    {
        [Fact]
        public void GetMany_NotNull()
        {
            var getCountriesDataAccess = new Data.Access.Countries.Get.Mock();

            var dataAccess = new Data.Access.Cities.Get.Mock();

            var service = new Services.Cities.Get.GetCities(getCountriesDataAccess, dataAccess);

            var result = service.GetMany(1);

            Assert.NotNull(result);
        }
    }
}
