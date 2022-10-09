using Web.Models;
using Refit;

namespace Web.Services;

public interface IWeatherService
{
    [Get("/api/weatherforecast")]
    Task<IEnumerable<WeatherForecast>> Get();
}

// Code below replaced with auto-generated refit client
//public class WeatherService : IWeatherService
//{
//    private readonly HttpClient httpClient;

//    public WeatherService(HttpClient httpClient)
//    {
//        this.httpClient = httpClient;
//    }

//    public async Task<IEnumerable<WeatherForecast>> Get()
//    {
//        var response = await httpClient.GetAsync($"api/weatherforecast");
//        var responseAsString = await response.Content.ReadAsStringAsync();
//        var options = new JsonSerializerOptions
//        {
//            PropertyNameCaseInsensitive = true
//        };
//        return JsonSerializer.Deserialize<IEnumerable<WeatherForecast>>(responseAsString, options)!;
//    }
//}
