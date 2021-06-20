using Xunit;

namespace Weather.Test
{
    public class GetWeather_Mock_GetSingle
    {
        [Fact]
        public void GetSingle_NotNull()
        {
            var getCitiesDataAccess = new Data.Access.Cities.Get.Mock();

            var dataAccess = new Data.Access.Weathers.Get.Mock();

            var service = new Services.Weathers.Get.GetWeather(dataAccess, getCitiesDataAccess);

            var result = service.GetSingle(1);

            Assert.NotNull(result);
        }
    }
}
