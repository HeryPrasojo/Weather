namespace Weather.Services.Weathers.Get
{
    public interface IGetWeather
    {
        public Weather GetSingle(int cityId);
    }
}
