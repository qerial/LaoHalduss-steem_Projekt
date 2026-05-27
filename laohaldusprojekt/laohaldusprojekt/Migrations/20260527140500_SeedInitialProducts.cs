using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace laohaldusprojekt.Migrations
{
    public partial class SeedInitialProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert rows only if they do not already exist to make the migration idempotent
            migrationBuilder.Sql(@"IF NOT EXISTS (SELECT 1 FROM [Product] WHERE [Id] = 1)
BEGIN
    SET IDENTITY_INSERT [Product] ON;
    INSERT INTO [Product] ([Id], [TooteNimi], [Kogus], [Hind], [Kategooria]) VALUES (1, N'Lihapihvid, MAKS&MOORITS', 4, 3.55, N'Liha- ja kalatooted');
    SET IDENTITY_INSERT [Product] OFF;
END");

            migrationBuilder.Sql(@"IF NOT EXISTS (SELECT 1 FROM [Product] WHERE [Id] = 2)
BEGIN
    SET IDENTITY_INSERT [Product] ON;
    INSERT INTO [Product] ([Id], [TooteNimi], [Kogus], [Hind], [Kategooria]) VALUES (2, N'Kodune šašlõkk', 2, 5.0, N'Liha- ja kalatooted');
    SET IDENTITY_INSERT [Product] OFF;
END");

            migrationBuilder.Sql(@"IF NOT EXISTS (SELECT 1 FROM [Product] WHERE [Id] = 3)
BEGIN
    SET IDENTITY_INSERT [Product] ON;
    INSERT INTO [Product] ([Id], [TooteNimi], [Kogus], [Hind], [Kategooria]) VALUES (3, N'Juustupulgad Pik-Nik', 5, 3.19, N'Piimatooted');
    SET IDENTITY_INSERT [Product] OFF;
END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM [Product] WHERE [Id] IN (1,2,3);");
        }
    }
}
