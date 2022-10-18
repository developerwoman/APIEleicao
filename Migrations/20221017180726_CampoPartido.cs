using Microsoft.EntityFrameworkCore.Migrations;

namespace APIEleicao.Migrations
{
    public partial class CampoPartido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Partido",
                schema: "ESTUDOS",
                table: "Candidato",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Partido",
                schema: "ESTUDOS",
                table: "Candidato");
        }
    }
}
