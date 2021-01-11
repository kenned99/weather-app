using System;
using System.Text.Json.Serialization;

namespace DomainModel
{
    public class Meta
    {
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; } 

        [JsonPropertyName("units")]
        public Units Units { get; set; } 
    }
}