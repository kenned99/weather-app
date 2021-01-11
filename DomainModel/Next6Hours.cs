using System.Text.Json.Serialization;

namespace DomainModel
{
    public class Next6Hours
    {
        [JsonPropertyName("summary")]
        public Summary Summary { get; set; } 

        [JsonPropertyName("details")]
        public Details Details { get; set; } 
    }
}