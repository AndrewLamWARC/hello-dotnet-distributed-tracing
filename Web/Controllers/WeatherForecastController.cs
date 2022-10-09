using Web.Models;
using Microsoft.AspNetCore.Mvc;
using Web.Services;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> logger;
    private readonly IWeatherService weatherService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService)
    {
        this.logger = logger;
        this.weatherService = weatherService;
    }

    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        // 1. Need exception middleware to log exceptions
        // 2. Need tracing to enable operator to diagnose call chain below
        // Browser -> React FE (Web/ClientApp) -> DotNet web (Web) -> DotNet api (Api)
        return await weatherService.Get();
    }
}
