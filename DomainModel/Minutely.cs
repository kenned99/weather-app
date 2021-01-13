using Newtonsoft.Json;

namespace DomainModel
{
    public class Minutely
    {
        [JsonProperty("dt")]
        public int Dt { get; set; } 

        [JsonProperty("precipitation")]
        public double Precipitation { get; set; } 
    }
}