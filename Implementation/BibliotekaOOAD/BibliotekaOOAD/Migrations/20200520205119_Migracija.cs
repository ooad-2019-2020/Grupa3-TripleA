using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaOOAD.Migrations
{
    public partial class Migracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojLoginova = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bibliotekar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotekar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojPosjete = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gost", x => x.Id);
                });

           // migrationBuilder.CreateTable(
             //   name: "PlacanjeClanarine",
               // columns: table => new
                //{
                //},
                //constraints: table =>
                //{
                //});

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojRacuna = table.Column<int>(nullable: false),
                    Stanje = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VipKorisnik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OstvareniPopust = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VipKorisnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObicniKorisnik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    RacunId = table.Column<int>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    KrajVazenjaClanarine = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObicniKorisnik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObicniKorisnik_Racun_RacunId",
                        column: x => x.RacunId,
                        principalTable: "Racun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Lozinka = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    BrojLoginova = table.Column<int>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    RacunId = table.Column<int>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: true),
                    KrajVazenjaClanarine = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Osoba_Racun_RacunId",
                        column: x => x.RacunId,
                        principalTable: "Racun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Biblioteka",
                columns: table => new
                {
                    GostId = table.Column<int>(nullable: true),
                    AdministratorId = table.Column<int>(nullable: true),
                    Info = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Biblioteka_Osoba_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Biblioteka_Gost_GostId",
                        column: x => x.GostId,
                        principalTable: "Gost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Knjiga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Rating = table.Column<decimal>(nullable: false),
                    KorisnikKojiJePosudioId = table.Column<int>(nullable: true),
                    BibliotekarDbId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knjiga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Knjiga_Bibliotekar_BibliotekarDbId",
                        column: x => x.BibliotekarDbId,
                        principalTable: "Bibliotekar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Knjiga_Osoba_KorisnikKojiJePosudioId",
                        column: x => x.KorisnikKojiJePosudioId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obavjestenje",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tekst = table.Column<string>(nullable: true),
                    PosiljaocId = table.Column<int>(nullable: true),
                    PrimaocId = table.Column<int>(nullable: true),
                    DatumSlanja = table.Column<DateTime>(nullable: false),
                    ObicniKorisnikDbId = table.Column<int>(nullable: true),
                    ObicniKorisnikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavjestenje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Obavjestenje_ObicniKorisnik_ObicniKorisnikDbId",
                        column: x => x.ObicniKorisnikDbId,
                        principalTable: "ObicniKorisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Obavjestenje_Osoba_ObicniKorisnikId",
                        column: x => x.ObicniKorisnikId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Obavjestenje_Osoba_PosiljaocId",
                        column: x => x.PosiljaocId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Obavjestenje_Osoba_PrimaocId",
                        column: x => x.PrimaocId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KnjigaZahtjev",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: true),
                    KnjigaId = table.Column<int>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_KnjigaZahtjev_Knjiga_KnjigaId",
                        column: x => x.KnjigaId,
                        principalTable: "Knjiga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KnjigaZahtjev_Osoba_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TekstRecenzije = table.Column<string>(nullable: true),
                    BrojZvjezdica = table.Column<int>(nullable: false),
                    DatumObjave = table.Column<DateTime>(nullable: false),
                    KnjigaId = table.Column<int>(nullable: true),
                    NeprimjerenSadrzaj = table.Column<bool>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recenzija_Knjiga_KnjigaId",
                        column: x => x.KnjigaId,
                        principalTable: "Knjiga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recenzija_Osoba_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zanr",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(nullable: true),
                    Vrsta = table.Column<string>(nullable: true),
                    KnjigaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanr", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zanr_Knjiga_KnjigaId",
                        column: x => x.KnjigaId,
                        principalTable: "Knjiga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biblioteka_AdministratorId",
                table: "Biblioteka",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Biblioteka_GostId",
                table: "Biblioteka",
                column: "GostId");

            migrationBuilder.CreateIndex(
                name: "IX_Knjiga_BibliotekarDbId",
                table: "Knjiga",
                column: "BibliotekarDbId");

            migrationBuilder.CreateIndex(
                name: "IX_Knjiga_KorisnikKojiJePosudioId",
                table: "Knjiga",
                column: "KorisnikKojiJePosudioId");

            migrationBuilder.CreateIndex(
                name: "IX_KnjigaZahtjev_KnjigaId",
                table: "KnjigaZahtjev",
                column: "KnjigaId");

            migrationBuilder.CreateIndex(
                name: "IX_KnjigaZahtjev_KorisnikId",
                table: "KnjigaZahtjev",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavjestenje_ObicniKorisnikDbId",
                table: "Obavjestenje",
                column: "ObicniKorisnikDbId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavjestenje_ObicniKorisnikId",
                table: "Obavjestenje",
                column: "ObicniKorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavjestenje_PosiljaocId",
                table: "Obavjestenje",
                column: "PosiljaocId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavjestenje_PrimaocId",
                table: "Obavjestenje",
                column: "PrimaocId");

            migrationBuilder.CreateIndex(
                name: "IX_ObicniKorisnik_RacunId",
                table: "ObicniKorisnik",
                column: "RacunId");

            migrationBuilder.CreateIndex(
                name: "IX_Osoba_RacunId",
                table: "Osoba",
                column: "RacunId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_KnjigaId",
                table: "Recenzija",
                column: "KnjigaId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_KorisnikId",
                table: "Recenzija",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Zanr_KnjigaId",
                table: "Zanr",
                column: "KnjigaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "Biblioteka");

            migrationBuilder.DropTable(
                name: "KnjigaZahtjev");

            migrationBuilder.DropTable(
                name: "Obavjestenje");

            migrationBuilder.DropTable(
                name: "PlacanjeClanarine");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "VipKorisnik");

            migrationBuilder.DropTable(
                name: "Zanr");

            migrationBuilder.DropTable(
                name: "Gost");

            migrationBuilder.DropTable(
                name: "ObicniKorisnik");

            migrationBuilder.DropTable(
                name: "Knjiga");

            migrationBuilder.DropTable(
                name: "Bibliotekar");

            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.DropTable(
                name: "Racun");
        }
    }
}
