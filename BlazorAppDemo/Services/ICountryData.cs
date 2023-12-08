using BlazorAppDemo.Dtos;

namespace BlazorAppDemo.Services
{
    public interface ICountryData
    {
        Task<CountryDto[]> GetAll();
    }
}
