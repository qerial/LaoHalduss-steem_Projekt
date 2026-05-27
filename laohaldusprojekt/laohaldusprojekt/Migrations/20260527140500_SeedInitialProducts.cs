using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace laohaldusprojekt.Migrations
{
    public partial class SeedInitialProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "TooteNimi", "Kogus", "Hind", "Kategooria" },
                values: new object[,]
                {
                    { 1, "Lihapihvid, MAKS&MOORITS", 4, 3.55, "Liha- ja kalatooted" },
                    { 2, "Kodune šašlõkk", 2, 5.0, "Liha- ja kalatooted" },
                    { 3, "Juustupulgad Pik-Nik", 5, 3.19, "Piimatooted" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3 });
        }
    }
}
