using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        public WeatherController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = new List<object>();

           for (int i = 0; i < 10; i++)
            {
                var random = Random.Shared;

                result.Add(new
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(i)),
                    TemperatureC = random.Next(-20, 55),
                    Summary = "Are u OK?"
                });
            }

            return Ok(result);
        }
    }
}
