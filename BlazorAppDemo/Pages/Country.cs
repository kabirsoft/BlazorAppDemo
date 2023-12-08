using BlazorAppDemo.Dtos;
using BlazorAppDemo.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorAppDemo.Pages
{
    public partial class Country
    {
        [Inject]
        ICountryData countryData { get; set; }

        private CountryDto[]? countries;

        protected override async Task OnInitializedAsync()
        {            
            countries = await countryData.GetAll();
        }
    }
}
