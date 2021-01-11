using System;
using System.Text.Json.Serialization;

namespace DomainModel
{
    public class Timesery
    {
        [JsonPropertyName("time")]
        public DateTime Time { get; set; } 

        [JsonPropertyName("data")]
        public Data Data { get; set; } 
    }
}