using DomainModel;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class API
    {
        public async Task<WeatherForeCast> GetWeatherForeCastAsync(double Latitude, double Longitude, double Altitude)
        {
            string url = "https://api.met.no/weatherapi/locationforecast/2.0/complete?lat={0}&lon={1}&altitude={2}";

            return await RestService.GetDataAsync<WeatherForeCast>(string.Format(url, Latitude, Longitude, Altitude));
        }
    }
}
