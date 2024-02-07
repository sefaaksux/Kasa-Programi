using Microsoft.EntityFrameworkCore.Migrations;

namespace AksuHaliEvi.Migrations
{
    public partial class mg5AddedPhoneForDebt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Debts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Debts");
        }
    }
}
