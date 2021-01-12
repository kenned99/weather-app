using Newtonsoft.Json; 
using System.Collections.Generic;

namespace DomainModel
{
    public class Hourly
    {
        [JsonProperty("dt")]
        public int Dt { get; set; } 

        [JsonProperty("temp")]
        public double Temp { get; set; } 

        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; } 

        [JsonProperty("pressure")]
        public int Pressure { get; set; } 

        [JsonProperty("humidity")]
        public int Humidity { get; set; } 

        [JsonProperty("dew_point")]
        public double DewPoint { get; set; } 

        [JsonProperty("uvi")]
        public double Uvi { get; set; } 

        [JsonProperty("clouds")]
        public int Clouds { get; set; } 

        [JsonProperty("visibility")]
        public int Visibility { get; set; } 

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; } 

        [JsonProperty("wind_deg")]
        public int WindDeg { get; set; } 

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; } 

        [JsonProperty("pop")]
        public int Pop { get; set; } 
    }
}