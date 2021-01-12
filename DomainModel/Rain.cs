using Newtonsoft.Json;

namespace DomainModel
{
    public class Rain
    {
        [JsonProperty("1h")]
        public double Amount { get; set; }
    }
}