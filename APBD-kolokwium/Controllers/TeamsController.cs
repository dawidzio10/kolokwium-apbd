using APBD_kolokwium.DTOs.Requests;
using APBD_kolokwium.Exceptions;
using APBD_kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_kolokwium.Controllers
{
    [ApiController]
    [Route("api/teams")]
    public class TeamsController : ControllerBase
    {
        private readonly IMyDBService _dbService;

        public TeamsController(IMyDBService dbService)
        {
            _dbService = dbService;
        }
        [HttpGet("{id:int}/players")]
        public IActionResult AddPlayerToTeam(AddPlayerToTeamRequest request, int id)
        {
            try
            {
                _dbService.AddPlayerToTeams(request, id);
                return Ok();
            }
            catch (NotExistsException exc)
            {
                return BadRequest(exc.Message);
            }
            catch(WrongAgeException exc)
            {
                return BadRequest(exc.Message);
            }
            catch(AlreadyExistsException exc)
            {
                return BadRequest(exc.Message);
            }
        }
    }
}