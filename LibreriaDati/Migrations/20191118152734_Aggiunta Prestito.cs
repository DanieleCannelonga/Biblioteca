using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibreriaDati.Migrations
{
    public partial class AggiuntaPrestito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestito",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RisorseBibliotecaId = table.Column<int>(nullable: true),
                    BibliotecaCardId = table.Column<int>(nullable: true),
                    DataPrestito = table.Column<DateTime>(nullable: false),
                    risorsa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestito_BibliotecaCard_BibliotecaCardId",
                        column: x => x.BibliotecaCardId,
                        principalTable: "BibliotecaCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestito_RisorseBiblioteca_RisorseBibliotecaId",
                        column: x => x.RisorseBibliotecaId,
                        principalTable: "RisorseBiblioteca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prestito_BibliotecaCardId",
                table: "Prestito",
                column: "BibliotecaCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestito_RisorseBibliotecaId",
                table: "Prestito",
                column: "RisorseBibliotecaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prestito");
        }
    }
}
