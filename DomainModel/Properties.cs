using System.Text.Json.Serialization; 
using System.Collections.Generic;

namespace DomainModel
{
    public class Properties    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; } 

        [JsonPropertyName("timeseries")]
        public List<Timesery> Timeseries { get; set; } 
    }
}