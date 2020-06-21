using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_kolokwium.Migrations
{
    public partial class fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerTeams",
                table: "PlayerTeams");

            migrationBuilder.DropIndex(
                name: "IX_PlayerTeams_IdPlayer",
                table: "PlayerTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChampionshipTeams",
                table: "ChampionshipTeams");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerTeams",
                table: "PlayerTeams",
                columns: new[] { "IdPlayer", "IdTeam" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChampionshipTeams",
                table: "ChampionshipTeams",
                columns: new[] { "IdChampionship", "IdTeam" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTeams_IdTeam",
                table: "PlayerTeams",
                column: "IdTeam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerTeams",
                table: "PlayerTeams");

            migrationBuilder.DropIndex(
                name: "IX_PlayerTeams_IdTeam",
                table: "PlayerTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChampionshipTeams",
                table: "ChampionshipTeams");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerTeams",
                table: "PlayerTeams",
                column: "IdTeam");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChampionshipTeams",
                table: "ChampionshipTeams",
                column: "IdChampionship");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTeams_IdPlayer",
                table: "PlayerTeams",
                column: "IdPlayer");
        }
    }
}
