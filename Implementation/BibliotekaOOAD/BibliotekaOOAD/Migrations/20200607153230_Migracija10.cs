using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaOOAD.Migrations
{
    public partial class Migracija10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BibliotekarId",
                table: "Knjiga",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Knjiga_BibliotekarId",
                table: "Knjiga",
                column: "BibliotekarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Knjiga_Osoba_BibliotekarId",
                table: "Knjiga",
                column: "BibliotekarId",
                principalTable: "Osoba",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Knjiga_Osoba_BibliotekarId",
                table: "Knjiga");

            migrationBuilder.DropIndex(
                name: "IX_Knjiga_BibliotekarId",
                table: "Knjiga");

            migrationBuilder.DropColumn(
                name: "BibliotekarId",
                table: "Knjiga");
        }
    }
}
