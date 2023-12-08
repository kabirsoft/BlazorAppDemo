using BlazorAppDemo.Dtos;

namespace BlazorAppDemo.Services
{
    public interface IFetchUni
    {
        Task<UniversityDto[]> GetAll();
    }
}
