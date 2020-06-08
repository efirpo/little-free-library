using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class AddBookLocationJoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "BookLocation",
                columns: table => new
                {
                    BookLocationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    CurrentLocation = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookLocation", x => x.BookLocationId);
                    table.ForeignKey(
                        name: "FK_BookLocation_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookLocation_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookLocation_BookId",
                table: "BookLocation",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookLocation_LocationId",
                table: "BookLocation",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookLocation");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }
    }
}
