using Microsoft.EntityFrameworkCore.Migrations;

namespace KasaProgramı.Migrations
{
    public partial class mg1RemainderAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Remainder",
                table: "Turnovers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remainder",
                table: "Turnovers");
        }
    }
}
