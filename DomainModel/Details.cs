using System.Text.Json.Serialization;

namespace DomainModel
{
    public class Details
    {
        [JsonPropertyName("air_pressure_at_sea_level")]
        public double AirPressureAtSeaLevel { get; set; } 

        [JsonPropertyName("air_temperature")]
        public double AirTemperature { get; set; } 

        [JsonPropertyName("cloud_area_fraction")]
        public double CloudAreaFraction { get; set; } 

        [JsonPropertyName("cloud_area_fraction_high")]
        public double CloudAreaFractionHigh { get; set; } 

        [JsonPropertyName("cloud_area_fraction_low")]
        public double CloudAreaFractionLow { get; set; } 

        [JsonPropertyName("cloud_area_fraction_medium")]
        public double CloudAreaFractionMedium { get; set; } 

        [JsonPropertyName("dew_point_temperature")]
        public double DewPointTemperature { get; set; } 

        [JsonPropertyName("fog_area_fraction")]
        public double FogAreaFraction { get; set; } 

        [JsonPropertyName("relative_humidity")]
        public double RelativeHumidity { get; set; } 

        [JsonPropertyName("ultraviolet_index_clear_sky")]
        public double UltravioletIndexClearSky { get; set; } 

        [JsonPropertyName("wind_from_direction")]
        public double WindFromDirection { get; set; } 

        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; set; } 

        [JsonPropertyName("precipitation_amount")]
        public int PrecipitationAmount { get; set; } 

        [JsonPropertyName("air_temperature_max")]
        public double AirTemperatureMax { get; set; } 

        [JsonPropertyName("air_temperature_min")]
        public double AirTemperatureMin { get; set; } 
    }
}