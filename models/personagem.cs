using System.Text.Json.Serialization;

namespace BlazorDbzApiPersonaExtra.models
{
    public class Personagem
    {
    
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("race")]
        public string? Race { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }
    }
}