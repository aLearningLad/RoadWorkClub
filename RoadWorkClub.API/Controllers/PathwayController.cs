using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoadWorkClub.API.Models.Domain;

namespace RoadWorkClub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PathwayController : ControllerBase
    {

        // get all single pathway
        [HttpGet]
        public IActionResult GetAll()
        {

            var pathways = new List<Pathway>
            {
                new Pathway
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.Now,
                    AvgDuration = new TimeSpan(1,45,55),
                    Description = "Route from Princess Park primary to Edenvale railway",
                    DifficultyRating = Enums.Difficulty.Easy,
                    DistanceInKm = 22.3,
                    IsLoop = false,
                    Name = "Thanos' Date",
                    RecommendedStartTime = new TimeSpan(16,30,00),
                }
            };
            return Ok(pathways);
        }
    }
}
