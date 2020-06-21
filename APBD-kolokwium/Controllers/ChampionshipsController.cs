using APBD_kolokwium.Exceptions;
using APBD_kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_kolokwium.Controllers
{
    [ApiController]
    [Route("api/championships")]
    public class ChampionshipsController : ControllerBase
    {
        private readonly IMyDBService _dbService;
    
        public ChampionshipsController(IMyDBService dbService)
        {
            _dbService = dbService;
        }
        [HttpGet("{id:int}/teams")]
        public IActionResult GetChampionships(int id)
        {
            try
            {
                var response = _dbService.GetTeams(id);
                return Ok(response);
            }
            catch(NotExistsException exc)
            {
                return NotFound(exc.Message);
            }
        }
    }
}