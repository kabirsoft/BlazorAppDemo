using BlazorAppDemo;
using BlazorAppDemo.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["api_base_url"]) });
builder.Services.AddHttpClient<IFetchUni, FetchUni>(sp => sp.BaseAddress = new Uri(builder.Configuration["api_base_url"]));
builder.Services.AddHttpClient<ICountryData, CountryData>(sp => sp.BaseAddress = new Uri(builder.Configuration["country_graphQL_url"]));

await builder.Build().RunAsync();
