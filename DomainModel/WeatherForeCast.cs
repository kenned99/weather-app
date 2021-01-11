using System.Text.Json.Serialization;

namespace DomainModel
{
    public class WeatherForeCast
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } 

        [JsonPropertyName("geometry")]
        public Geometry Geometry { get; set; } 

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; } 
    }
}