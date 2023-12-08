using System.Text.Json.Serialization;

namespace BlazorAppDemo.Dtos
{    
    public partial class CountryDto
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("emoji")]
        public string? Emoji { get; set; }
    }
}
