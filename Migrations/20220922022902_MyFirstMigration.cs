using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIEleicao.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Eleicoes");

            migrationBuilder.CreateTable(
                name: "Candidato",
                schema: "Eleicoes",
                columns: table => new
                {
                    ID_CANDIDATO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VICE = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CODIGO = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    LEGENDA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DATA_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Voto",
                schema: "Eleicoes",
                columns: table => new
                {
                    Id_voto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_CANDIDATO = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    DATA_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidato",
                schema: "Eleicoes");

            migrationBuilder.DropTable(
                name: "Voto",
                schema: "Eleicoes");
        }
    }
}
