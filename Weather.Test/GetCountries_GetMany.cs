using Xunit;

namespace Weather.Test
{
    public class GetCountries_GetMany
    {
        [Fact]
        public void GetMany_NotNull()
        {
            var dataAccess = new Data.Access.Countries.Get.Mock();

            var service = new Services.Countries.Get.GetCountries(dataAccess);

            var result = service.GetMany();

            Assert.NotNull(result);
        }
    }
}
