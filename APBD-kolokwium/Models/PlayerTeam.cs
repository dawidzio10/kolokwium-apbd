using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_kolokwium.Models
{
    public class PlayerTeam
    {
        public int IdPlayer { get; set; }
        public int IdTeam { get; set; }
        [Required]
        public int NumOnShirt { get; set; }
        [Required]
        [MaxLength(300)]
        public string Comment { get; set; }
        [ForeignKey("IdPlayer")]
        public virtual Player Player { get; set; }
        [ForeignKey("IdTeam")]
        public virtual Team Team { get; set; }
    }
}
