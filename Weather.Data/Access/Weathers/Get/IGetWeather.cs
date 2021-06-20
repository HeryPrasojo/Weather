namespace Weather.Data.Access.Weathers.Get
{
    public interface IGetWeather
    {
        public Model.Weather GetSingle(string cityName);
    }
}
