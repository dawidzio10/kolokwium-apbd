using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_kolokwium.Models
{
    public class ChampionshipTeam
    {
        public int IdTeam { get; set; }
        public int IdChampionship { get; set; }
        [Required]
        public int Score { get; set; }
        [ForeignKey("IdTeam")]
        public virtual Team Team { get; set; }
        [ForeignKey("IdChampionship")]
        public virtual Championship Championship { get; set; }
    }
}
