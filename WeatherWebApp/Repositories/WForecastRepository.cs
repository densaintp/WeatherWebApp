using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using WeatherWebApp.OpenWeatherMapModel;

namespace WeatherWebApp.Repositories
{
    public class WForecastRepository : IWForecastRepository
    {
        public WeatherResponse GetForecast(string city)
        {
            string APP_ID = Configuration.Values.API;
            var client = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={city}&lang=ru&appid={APP_ID}&units=metric");
			var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            if (response.IsSuccessful)  
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                return content?.ToObject<WeatherResponse>();
            }
            else
                return null;
        }
    }
}
