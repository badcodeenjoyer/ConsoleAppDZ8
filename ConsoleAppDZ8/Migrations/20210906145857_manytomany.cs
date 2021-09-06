using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppDZ8.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Farmers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CowFarmer",
                columns: table => new
                {
                    CowsId = table.Column<int>(type: "int", nullable: false),
                    FarmersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CowFarmer", x => new { x.CowsId, x.FarmersId });
                    table.ForeignKey(
                        name: "FK_CowFarmer_Cows_CowsId",
                        column: x => x.CowsId,
                        principalTable: "Cows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CowFarmer_Farmers_FarmersId",
                        column: x => x.FarmersId,
                        principalTable: "Farmers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CowFarmer_FarmersId",
                table: "CowFarmer",
                column: "FarmersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CowFarmer");

            migrationBuilder.DropTable(
                name: "Cows");

            migrationBuilder.DropTable(
                name: "Farmers");
        }
    }
}
