using BlazorAppDemo.Dtos;
using BlazorAppDemo.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorAppDemo.Pages
{
    public partial class FetchUni
    {
        [Inject]
        IFetchUni fetchUni { get; set; }

        private UniversityDto[]? universities;

        protected override async Task OnInitializedAsync()
        {
            universities = await fetchUni.GetAll();
        }
    }
}
