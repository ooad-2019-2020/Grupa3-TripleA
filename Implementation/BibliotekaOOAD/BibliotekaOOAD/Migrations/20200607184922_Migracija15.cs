using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaOOAD.Migrations
{
    public partial class Migracija15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatumRodjenja",
                table: "VipKorisnik",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "VipKorisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "VipKorisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KorisnickoIme",
                table: "VipKorisnik",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "KrajVazenjaClanarine",
                table: "VipKorisnik",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Lozinka",
                table: "VipKorisnik",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "VipKorisnik",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RacunId",
                table: "VipKorisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ObicniKorisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "ObicniKorisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lozinka",
                table: "ObicniKorisnik",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "ObicniKorisnik",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VipKorisnikDbId",
                table: "Obavjestenje",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Bibliotekar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "Bibliotekar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lozinka",
                table: "Bibliotekar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "Bibliotekar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Administrator",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "Administrator",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lozinka",
                table: "Administrator",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "Administrator",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VipKorisnik_RacunId",
                table: "VipKorisnik",
                column: "RacunId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavjestenje_VipKorisnikDbId",
                table: "Obavjestenje",
                column: "VipKorisnikDbId");

            migrationBuilder.AddForeignKey(
                name: "FK_Obavjestenje_VipKorisnik_VipKorisnikDbId",
                table: "Obavjestenje",
                column: "VipKorisnikDbId",
                principalTable: "VipKorisnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VipKorisnik_Racun_RacunId",
                table: "VipKorisnik",
                column: "RacunId",
                principalTable: "Racun",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obavjestenje_VipKorisnik_VipKorisnikDbId",
                table: "Obavjestenje");

            migrationBuilder.DropForeignKey(
                name: "FK_VipKorisnik_Racun_RacunId",
                table: "VipKorisnik");

            migrationBuilder.DropIndex(
                name: "IX_VipKorisnik_RacunId",
                table: "VipKorisnik");

            migrationBuilder.DropIndex(
                name: "IX_Obavjestenje_VipKorisnikDbId",
                table: "Obavjestenje");

            migrationBuilder.DropColumn(
                name: "DatumRodjenja",
                table: "VipKorisnik");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "VipKorisnik");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "VipKorisnik");

            migrationBuilder.DropColumn(
                name: "KorisnickoIme",
                table: "VipKorisnik");

            migrationBuilder.DropColumn(
                name: "KrajVazenjaClanarine",
                table: "VipKorisnik");

            migrationBuilder.DropColumn(
                name: "Lozinka",
                table: "VipKorisnik");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "VipKorisnik");

            migrationBuilder.DropColumn(
                name: "RacunId",
                table: "VipKorisnik");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ObicniKorisnik");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "ObicniKorisnik");

            migrationBuilder.DropColumn(
                name: "Lozinka",
                table: "ObicniKorisnik");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "ObicniKorisnik");

            migrationBuilder.DropColumn(
                name: "VipKorisnikDbId",
                table: "Obavjestenje");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Bibliotekar");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "Bibliotekar");

            migrationBuilder.DropColumn(
                name: "Lozinka",
                table: "Bibliotekar");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "Bibliotekar");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Administrator");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "Administrator");

            migrationBuilder.DropColumn(
                name: "Lozinka",
                table: "Administrator");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "Administrator");
        }
    }
}
