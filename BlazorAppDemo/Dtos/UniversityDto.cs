using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorAppDemo.Dtos
{
    public partial class UniversityDto
    {        
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("alpha_two_code")]
        public string? AlphaTwoCode { get; set; }
        
    }
}
