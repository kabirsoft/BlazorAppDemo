using System.Text.Json.Serialization;

namespace BlazorAppDemo.Dtos
{   
    public partial class CountryGraphQlData
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonPropertyName("countries")]
        public CountryDto[] Countries { get; set; }
    }        
    
}
