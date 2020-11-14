using System.Threading.Tasks;
using DogKeepers.Server.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DogKeepers.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RaceController : ControllerBase
    {
        private readonly IRaceService raceService;

        public RaceController(IRaceService raceService)
        {
            this.raceService = raceService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var races = await raceService.Get();
            
            return Ok(races);
        }
    }
}