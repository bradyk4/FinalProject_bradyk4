using Microsoft.EntityFrameworkCore.Migrations;

namespace finalProject_wsad_bradyk4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medals",
                columns: table => new
                {
                    MedalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Event = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Place = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medals", x => x.MedalId);
                });

            migrationBuilder.InsertData(
                table: "Medals",
                columns: new[] { "MedalId", "Event", "Name", "Place", "Year" },
                values: new object[] { 1, "US University Nationals", "Jordan Burroughs", 2, 2007 });

            migrationBuilder.InsertData(
                table: "Medals",
                columns: new[] { "MedalId", "Event", "Name", "Place", "Year" },
                values: new object[] { 2, "US Open", "Jordan Burroughs", 1, 2011 });

            migrationBuilder.InsertData(
                table: "Medals",
                columns: new[] { "MedalId", "Event", "Name", "Place", "Year" },
                values: new object[] { 3, "World Championships", "Jordan Burroughs", 1, 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medals");
        }
    }
}
