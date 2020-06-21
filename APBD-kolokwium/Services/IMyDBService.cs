using APBD_kolokwium.DTOs.Requests;
using APBD_kolokwium.Models;
using System.Collections.Generic;

namespace APBD_kolokwium.Services
{
    public interface IMyDBService
    {
        public IEnumerable<ChampionshipTeam> GetTeams(int id);
        public void AddPlayerToTeams(AddPlayerToTeamRequest request, int id);

    }
}
