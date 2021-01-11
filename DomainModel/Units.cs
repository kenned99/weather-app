using System.Text.Json.Serialization;

namespace DomainModel
{
    public class Units 
    {
        [JsonPropertyName("air_pressure_at_sea_level")]
        public string AirPressureAtSeaLevel { get; set; } 

        [JsonPropertyName("air_temperature")]
        public string AirTemperature { get; set; } 

        [JsonPropertyName("air_temperature_max")]
        public string AirTemperatureMax { get; set; } 

        [JsonPropertyName("air_temperature_min")]
        public string AirTemperatureMin { get; set; } 

        [JsonPropertyName("cloud_area_fraction")]
        public string CloudAreaFraction { get; set; } 

        [JsonPropertyName("cloud_area_fraction_high")]
        public string CloudAreaFractionHigh { get; set; } 

        [JsonPropertyName("cloud_area_fraction_low")]
        public string CloudAreaFractionLow { get; set; } 

        [JsonPropertyName("cloud_area_fraction_medium")]
        public string CloudAreaFractionMedium { get; set; } 

        [JsonPropertyName("dew_point_temperature")]
        public string DewPointTemperature { get; set; } 

        [JsonPropertyName("fog_area_fraction")]
        public string FogAreaFraction { get; set; } 

        [JsonPropertyName("precipitation_amount")]
        public string PrecipitationAmount { get; set; } 

        [JsonPropertyName("relative_humidity")]
        public string RelativeHumidity { get; set; } 

        [JsonPropertyName("ultraviolet_index_clear_sky")]
        public string UltravioletIndexClearSky { get; set; } 

        [JsonPropertyName("wind_from_direction")]
        public string WindFromDirection { get; set; } 

        [JsonPropertyName("wind_speed")]
        public string WindSpeed { get; set; } 
    }
}