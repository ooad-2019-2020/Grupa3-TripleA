using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaOOAD.Migrations
{
    public partial class Migracija11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "OstvareniPopust",
                table: "Osoba",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OstvareniPopust",
                table: "Osoba");
        }
    }
}
