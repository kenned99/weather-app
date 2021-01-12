using DomainModel;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class API
    {
        private static string API_KEY = "7b14c4158ae9c11329484ce7ad915ca7";

        public async Task<WeatherForeCast> GetWeatherForeCastAsync(double Latitude, double Longitude, double Altitude)
        {
            string url = "https://api.openweathermap.org/data/2.5/onecall?units=metric&lat={0}&lon={1}&appid={2}";

            return await RestService.GetDataAsync<WeatherForeCast>(string.Format(url, Latitude, Longitude, API_KEY));
        }
    }
}
