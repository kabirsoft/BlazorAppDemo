using BlazorAppDemo.Dtos;
using System.Text;
using System.Text.Json;

namespace BlazorAppDemo.Services
{
    public class CountryData : ICountryData
    {
        private readonly HttpClient _httpClient;
        public CountryData( HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<CountryDto[]> GetAll()
        {
            var queryObject = new
            {
                query = @"{countries {code name emoji}}",
                variables = new {}
            };

            var countryQuery = new StringContent(
                JsonSerializer.Serialize(queryObject),
                Encoding.UTF8,
                "application/json"
                );
            var response = await _httpClient.PostAsync("/", countryQuery);
            if (response.IsSuccessStatusCode) 
            {
                var gqlData =  await JsonSerializer.DeserializeAsync<CountryGraphQlData>
                (await response.Content.ReadAsStreamAsync());

                return gqlData.Data.Countries;
            }            
            return null;
        }
    }
}
