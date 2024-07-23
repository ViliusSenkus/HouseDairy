using HouseDairy.Models;
using Microsoft.AspNetCore.Mvc;

namespace HouseDairy.Controllers
{
    [ApiController]
    [Route("Jobs")]
    public class JobController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<JobController> _logger;

        public JobController(ILogger<JobController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]

        public async Task<IActionResult> Create([FromBody] Jobs job)
        {
            Jobs newJob = new Jobs
            {
                Id = Guid.Parse("7330F811-F47F-41BC-A4FF-E792D073F41F"),
                Date = DateOnly.FromDateTime(DateTime.Now),
                JobName = job.JobName,
                JobType = job.JobType,
                Area = job.Area,
                Objects = job.Objects,
                JobDescription = job.JobDescription,
                Media = job.Media
            };


            return CreatedAtAction(nameof(Get), new {key = newJob.Id}, newJob);
        }
    }
}
