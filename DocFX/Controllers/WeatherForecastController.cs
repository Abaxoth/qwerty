using Microsoft.AspNetCore.Mvc;

namespace DocFX.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Get weather forecast
    /// </summary>
    /// <returns></returns>
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    /// <summary>
    /// Get random number [0, int.Max]
    /// </summary>
    /// <returns></returns>
    [HttpGet(Name = "RandomNumber")]
    public int RandomNumber()
    {
        return new Random().Next(0, int.MaxValue);
    }

    [HttpGet(Name = "Random string")]
    public string RandomString()
    {
        return "";
    }

    [HttpGet(Name = "Random string 2")]
    public string RandomString2()
    {
        return "";
    }

    [HttpGet(Name = "Random string 3")]
    public string RandomString3()
    {
        return "";
    }

    [HttpGet(Name = "Random string 5")]
    public string RandomString5()
    {
        return "";
    }

    [HttpGet(Name = "Random string 55")]
    public string RandomString55()
    {
        return "";
    }
}
