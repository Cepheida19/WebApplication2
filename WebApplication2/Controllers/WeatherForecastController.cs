using Microsoft.AspNetCore.Mvc;
using WebApplication2.ServicesLayer;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICalculationService _calculationService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICalculationService calculationService)
        {
            _logger = logger;
            _calculationService = calculationService;
        }

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
        
        [HttpPost("PostSumNumbers")]
        public int Post(int number1, int number2)
        {
            return _calculationService.SumTwoNumbers(number1, number2);
        }
    }
}
