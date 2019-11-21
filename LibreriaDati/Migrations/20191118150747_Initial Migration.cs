using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibreriaDati.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BibliotecaCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Seriale = table.Column<string>(nullable: false),
                    DataDiCreazione = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BibliotecaCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filiale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Indirizzo = table.Column<string>(maxLength: 30, nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    Descrizione = table.Column<string>(nullable: true),
                    DataDiApertura = table.Column<DateTime>(nullable: false),
                    ImmagineUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Descrizione = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Cognome = table.Column<string>(nullable: false),
                    Indirizzo = table.Column<string>(nullable: true),
                    DataDiNascita = table.Column<DateTime>(nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    BibliotecaCardId = table.Column<int>(nullable: true),
                    FilialeDiAppartenenzaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_BibliotecaCard_BibliotecaCardId",
                        column: x => x.BibliotecaCardId,
                        principalTable: "BibliotecaCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Filiale_FilialeDiAppartenenzaId",
                        column: x => x.FilialeDiAppartenenzaId,
                        principalTable: "Filiale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilialeId = table.Column<int>(nullable: true),
                    GiorniSettimanali = table.Column<int>(nullable: false),
                    OrarioDiApertura = table.Column<int>(nullable: false),
                    OrarioDiChiusura = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orario_Filiale_FilialeId",
                        column: x => x.FilialeId,
                        principalTable: "Filiale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RisorseBiblioteca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titolo = table.Column<string>(nullable: false),
                    Anno = table.Column<int>(nullable: false),
                    StatoId = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false),
                    ImmagineUrlId = table.Column<int>(nullable: true),
                    NumeroDiCopie = table.Column<int>(nullable: false),
                    FilialeId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Codice = table.Column<string>(nullable: true),
                    Autore = table.Column<string>(nullable: true),
                    CasaEditrice = table.Column<string>(nullable: true),
                    Genere = table.Column<string>(nullable: true),
                    Direttore = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RisorseBiblioteca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RisorseBiblioteca_Filiale_FilialeId",
                        column: x => x.FilialeId,
                        principalTable: "Filiale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RisorseBiblioteca_RisorseBiblioteca_ImmagineUrlId",
                        column: x => x.ImmagineUrlId,
                        principalTable: "RisorseBiblioteca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RisorseBiblioteca_Stato_StatoId",
                        column: x => x.StatoId,
                        principalTable: "Stato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RisorseBibliotecaId = table.Column<int>(nullable: false),
                    BibliotecaCardId = table.Column<int>(nullable: true),
                    Da = table.Column<DateTime>(nullable: false),
                    A = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkout_BibliotecaCard_BibliotecaCardId",
                        column: x => x.BibliotecaCardId,
                        principalTable: "BibliotecaCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Checkout_RisorseBiblioteca_RisorseBibliotecaId",
                        column: x => x.RisorseBibliotecaId,
                        principalTable: "RisorseBiblioteca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CronologiaCheckout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RisorseBibliotecaId = table.Column<int>(nullable: false),
                    BibliotecaCardId = table.Column<int>(nullable: false),
                    Entrata = table.Column<DateTime>(nullable: false),
                    Uscita = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CronologiaCheckout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CronologiaCheckout_BibliotecaCard_BibliotecaCardId",
                        column: x => x.BibliotecaCardId,
                        principalTable: "BibliotecaCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CronologiaCheckout_RisorseBiblioteca_RisorseBibliotecaId",
                        column: x => x.RisorseBibliotecaId,
                        principalTable: "RisorseBiblioteca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_BibliotecaCardId",
                table: "Checkout",
                column: "BibliotecaCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_RisorseBibliotecaId",
                table: "Checkout",
                column: "RisorseBibliotecaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_BibliotecaCardId",
                table: "Cliente",
                column: "BibliotecaCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_FilialeDiAppartenenzaId",
                table: "Cliente",
                column: "FilialeDiAppartenenzaId");

            migrationBuilder.CreateIndex(
                name: "IX_CronologiaCheckout_BibliotecaCardId",
                table: "CronologiaCheckout",
                column: "BibliotecaCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CronologiaCheckout_RisorseBibliotecaId",
                table: "CronologiaCheckout",
                column: "RisorseBibliotecaId");

            migrationBuilder.CreateIndex(
                name: "IX_Orario_FilialeId",
                table: "Orario",
                column: "FilialeId");

            migrationBuilder.CreateIndex(
                name: "IX_RisorseBiblioteca_FilialeId",
                table: "RisorseBiblioteca",
                column: "FilialeId");

            migrationBuilder.CreateIndex(
                name: "IX_RisorseBiblioteca_ImmagineUrlId",
                table: "RisorseBiblioteca",
                column: "ImmagineUrlId");

            migrationBuilder.CreateIndex(
                name: "IX_RisorseBiblioteca_StatoId",
                table: "RisorseBiblioteca",
                column: "StatoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkout");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "CronologiaCheckout");

            migrationBuilder.DropTable(
                name: "Orario");

            migrationBuilder.DropTable(
                name: "BibliotecaCard");

            migrationBuilder.DropTable(
                name: "RisorseBiblioteca");

            migrationBuilder.DropTable(
                name: "Filiale");

            migrationBuilder.DropTable(
                name: "Stato");
        }
    }
}
