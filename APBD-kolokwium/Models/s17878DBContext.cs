using Microsoft.EntityFrameworkCore;

namespace APBD_kolokwium.Models
{
    public class s17878DBContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerTeam> PlayerTeams { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ChampionshipTeam> ChampionshipTeams { get; set; }
        public DbSet<Championship> Championships { get; set; }

        public s17878DBContext()
        {

        }
        public s17878DBContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ChampionshipTeam>(opt =>
            {
                opt.HasKey(c => new { c.IdChampionship, c.IdTeam });
            });

            modelBuilder.Entity<PlayerTeam>(opt =>
            {
                opt.HasKey(c => new { c.IdPlayer, c.IdTeam });
            });
        }
    }
}
