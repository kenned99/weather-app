using System.Text.Json.Serialization; 
using System.Collections.Generic;

namespace DomainModel
{
    public class Geometry    {
        [JsonPropertyName("type")]
        public string Type { get; set; } 

        [JsonPropertyName("coordinates")]
        public List<int> Coordinates { get; set; } 
    }
}