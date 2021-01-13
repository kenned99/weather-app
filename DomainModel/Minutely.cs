using DomainModel.JsonConverters;
using Newtonsoft.Json;
using System;

namespace DomainModel
{
    public class Minutely
    {
        [JsonProperty("dt")]
        [JsonConverter(typeof(UTCDateTimeConverter))]
        public DateTime DateTime { get; set; }

        [JsonProperty("precipitation")]
        public double Precipitation { get; set; } 
    }
}