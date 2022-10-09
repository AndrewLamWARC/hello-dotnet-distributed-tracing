using Refit;
using Web.Services;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services
    .AddRefitClient<IWeatherService>()
    .ConfigureHttpClient(c =>
    {
        c.BaseAddress = new Uri(configuration["WeatherApiUrl"]);
    });

// In production, the react files will be served from this directory
// builder.Services.AddSpaStaticFiles(configuration =>
// {
//     configuration.RootPath = "wwwroot";
// });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");;

app.Run();
