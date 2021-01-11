using System.Text.Json.Serialization; 

namespace DomainModel
{
    public class Next12Hours
    {
        [JsonPropertyName("summary")]
        public Summary Summary { get; set; } 
    }
}