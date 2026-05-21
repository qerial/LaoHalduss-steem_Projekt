using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace laohaldusprojekt.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TooteNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kogus = table.Column<int>(type: "int", nullable: false),
                    Hind = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kategooria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
