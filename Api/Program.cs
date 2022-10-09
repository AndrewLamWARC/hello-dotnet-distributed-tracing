using Api.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<WeatherService>();
var app = builder.Build();

app.MapGet("api/weatherforecast", (WeatherService weatherService) => weatherService.Get());

app.Run();
