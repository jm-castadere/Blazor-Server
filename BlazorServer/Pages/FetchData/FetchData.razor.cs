using BlazorModel;
using BlazorService;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazorServer.Pages.FetchData
{
    public partial class FetchData
    {

        // services.AddSingleton<IWeatherForecastService, WeatherForecastService>()
        // @inject WeatherForecastService ForecastService
        [Inject]
        protected IWeatherForecastService ForecastService { get; set; }

        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }


    }
}
