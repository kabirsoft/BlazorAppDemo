using BlazorAppDemo.Dtos;
using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;

namespace BlazorAppDemo.Services
{
    public class FetchUni : IFetchUni
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _apiKey;

        public FetchUni(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _apiKey = _configuration["ApiKey"];
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _apiKey);
        }        

        public async Task<UniversityDto[]> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<UniversityDto[]>("/search?country=Norway");
        }
    }
}
