using Microsoft.EntityFrameworkCore.Migrations;

namespace LibreriaDati.Migrations
{
    public partial class Aggiornamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RisorseBiblioteca_RisorseBiblioteca_ImmagineUrlId",
                table: "RisorseBiblioteca");

            migrationBuilder.DropIndex(
                name: "IX_RisorseBiblioteca_ImmagineUrlId",
                table: "RisorseBiblioteca");

            migrationBuilder.DropColumn(
                name: "ImmagineUrlId",
                table: "RisorseBiblioteca");

            migrationBuilder.DropColumn(
                name: "Direttore",
                table: "RisorseBiblioteca");

            migrationBuilder.AddColumn<string>(
                name: "ImmagineUrl",
                table: "RisorseBiblioteca",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImmagineUrl",
                table: "RisorseBiblioteca");

            migrationBuilder.AddColumn<int>(
                name: "ImmagineUrlId",
                table: "RisorseBiblioteca",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direttore",
                table: "RisorseBiblioteca",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RisorseBiblioteca_ImmagineUrlId",
                table: "RisorseBiblioteca",
                column: "ImmagineUrlId");

            migrationBuilder.AddForeignKey(
                name: "FK_RisorseBiblioteca_RisorseBiblioteca_ImmagineUrlId",
                table: "RisorseBiblioteca",
                column: "ImmagineUrlId",
                principalTable: "RisorseBiblioteca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
