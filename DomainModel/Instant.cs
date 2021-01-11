using System.Text.Json.Serialization; 

namespace DomainModel
{
    public class Instant    {
        [JsonPropertyName("details")]
        public Details Details { get; set; } 
    }
}