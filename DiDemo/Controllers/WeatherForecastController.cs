using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DiDemo.Controllers
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
        private readonly ITest _test;
        private readonly IEnumerable<ITest> _tests;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ITest test, IEnumerable<ITest> tests)
        {
            _logger = logger;
            _test = test;
            _tests = tests;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            var result = _test.Add(1, 2);
            foreach (var v in _tests)
            {
                result = v.Add(2, 3);

            }


            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
