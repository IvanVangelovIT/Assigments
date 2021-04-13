using Microsoft.EntityFrameworkCore.Migrations;

namespace CsvFile.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "offer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    offerId = table.Column<int>(type: "int", nullable: false),
                    monthlyFee = table.Column<int>(type: "int", nullable: false),
                    newContractsForMonth = table.Column<int>(type: "int", nullable: false),
                    sameContractsForMonth = table.Column<int>(type: "int", nullable: false),
                    CancelledContractsForMonth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_offer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "offer");
        }
    }
}
