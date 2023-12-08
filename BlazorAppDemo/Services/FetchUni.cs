using BlazorAppDemo.Dtos;
using System.Net.Http.Json;

namespace BlazorAppDemo.Services
{
    public class FetchUni : IFetchUni
    {
        private readonly HttpClient _httpClient;

        public FetchUni(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }        

        public async Task<UniversityDto[]> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<UniversityDto[]>("/search?country=Norway");
        }
    }
}
