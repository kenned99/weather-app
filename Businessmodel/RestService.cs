using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BusinessModel
{
    internal static class RestService
    {
        public static async Task<T> GetDataAsync<T>(string url) where T : class
        {
            T res = null;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    res = JsonConvert.DeserializeObject<T>(content);
                }

                return res;
            }
        }
    }
}
