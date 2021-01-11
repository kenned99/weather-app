using System.Text.Json.Serialization;

namespace DomainModel
{
    public class Data
    {
        [JsonPropertyName("instant")]
        public Instant Instant { get; set; }

        [JsonPropertyName("next_12_hours")]
        public Next12Hours Next12Hours { get; set; }

        [JsonPropertyName("next_1_hours")]
        public Next1Hours Next1Hours { get; set; }

        [JsonPropertyName("next_6_hours")]
        public Next6Hours Next6Hours { get; set; }
    }
}