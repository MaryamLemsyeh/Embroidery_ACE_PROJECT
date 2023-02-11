using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Handmade.Service.EmbroideryAPI.Migrations
{
    public partial class BDDEMB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Embroideries",
                columns: table => new
                {
                    EmbroideryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmbroideryName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Embroideries", x => x.EmbroideryId);
                });

            migrationBuilder.InsertData(
                table: "Embroideries",
                columns: new[] { "EmbroideryId", "CategoryName", "EmbroideryName", "ImageURL", "Price" },
                values: new object[] { 1, "categorie1", "ChaiseBoisMassif", "1.jpg", 15.0 });

            migrationBuilder.InsertData(
                table: "Embroideries",
                columns: new[] { "EmbroideryId", "CategoryName", "EmbroideryName", "ImageURL", "Price" },
                values: new object[] { 2, "categorie1", "ChaiseBoisMassif", "1.jpg", 15.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Embroideries");
        }
    }
}
