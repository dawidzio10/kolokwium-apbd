using APBD_kolokwium.DTOs.Requests;
using APBD_kolokwium.Exceptions;
using APBD_kolokwium.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APBD_kolokwium.Services
{
    public class MyDBService : IMyDBService
    {
        private readonly s17878DBContext _context;

        public MyDBService(s17878DBContext context)
        {
            _context = context;
        }

        public void AddPlayerToTeams(AddPlayerToTeamRequest request, int id)
        {
            var team = _context.Teams
                               .Include(p => p.PlayerTeams)
                               .SingleOrDefaultAsync(p => p.IdTeam == id)
                               .Result;
            if (team == null)
            {
                throw new NotExistsException("Team with  id " + id + "doesn't exist");
            }
            var maxTaemsAge = team.MaxAge;
            var playerAge = DateTime.Now.Year - request.BirthDate.Year;
            if (playerAge > maxTaemsAge)
            {
                throw new WrongAgeException("Player is too old for this team");
            }
            var tmpPlayer = _context
                                .Players
                                .Where(p => p.FirstName == request.FirstName && p.LastName == request.LastName && p.DateOfBirth == request.BirthDate)
                                .FirstOrDefault();

            var countPlayerTeams = _context
                                    .PlayerTeams
                                    .Count(p => p.IdPlayer == tmpPlayer.IdPlayer);

            if(countPlayerTeams > 0)
            {
                throw new AlreadyExistsException("Player already has a team");
            }

            _context.PlayerTeams.Add(new PlayerTeam()
            {
                IdTeam = team.IdTeam,
                NumOnShirt = request.NumOnShirt,
                Comment = request.Comment
            });
        }

        public IEnumerable<ChampionshipTeam> GetTeams(int id)
        {
            var championships = _context.ChampionshipTeams
                                        .Where(t => t.IdChampionship == id)
                                        .Include(t => t.Team)
                                        .OrderBy(t => t.Score).ToList();
            if(championships == null)
            {
                throw new NotExistsException("Chamipons ship with  id " + id + "doesn't exist");
            }
            return championships;
        }
    }


}
