using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIEleicao.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ESTUDOS");

            migrationBuilder.CreateTable(
                name: "Candidato",
                schema: "ESTUDOS",
                columns: table => new
                {
                    Id_candidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VICE = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CODIGO = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    LEGENDA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DATA_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.Id_candidato);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidato",
                schema: "ESTUDOS");
        }
    }
}
