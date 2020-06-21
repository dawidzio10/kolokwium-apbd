using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_kolokwium.Models
{
    public class Championship
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdChampionship { get; set; }
        [Required]
        [MaxLength(100)]
        public string OfficialName { get; set; }
        [Required]
        public int Year { get; set; }
        public ICollection<ChampionshipTeam> ChampionshipTeams { get; set; }
    }
}
