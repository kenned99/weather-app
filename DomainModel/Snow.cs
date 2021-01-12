using Newtonsoft.Json;

namespace DomainModel
{
    public class Snow
    {
        [JsonPropertyAttribute("1h")]
        public double Amount { get; set; }
    }
}