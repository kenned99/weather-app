using System.Text.Json.Serialization;

namespace DomainModel
{
    public class Summary
    {
        [JsonPropertyName("symbol_code")]
        public string SymbolCode { get; set; } 
    }
}