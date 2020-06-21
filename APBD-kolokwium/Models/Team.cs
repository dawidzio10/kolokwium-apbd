using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_kolokwium.Models
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTeam { get; set; }
        [Required]
        [MaxLength(30)]
        public string TeamName { get; set; }
        [Required]
        public int MaxAge { get; set; }
        public ICollection<PlayerTeam> PlayerTeams { get; set; }
        public ICollection<ChampionshipTeam> ChampionshipTeams { get; set; }


    }
}
