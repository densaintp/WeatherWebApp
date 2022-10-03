using WeatherWebApp.OpenWeatherMapModel;

namespace WeatherWebApp.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(string city);
    }
}
