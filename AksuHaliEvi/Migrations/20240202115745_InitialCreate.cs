using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AksuHaliEvi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    MethodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MethodName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.MethodID);
                });

            migrationBuilder.CreateTable(
                name: "Turnovers",
                columns: table => new
                {
                    TurnoverID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalIncome = table.Column<decimal>(nullable: false),
                    TotalExpense = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnovers", x => x.TurnoverID);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(nullable: false),
                    ExpenseDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MethodID = table.Column<int>(nullable: false),
                    PaymentMethodMethodID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseID);
                    table.ForeignKey(
                        name: "FK_Expenses_PaymentMethods_PaymentMethodMethodID",
                        column: x => x.PaymentMethodMethodID,
                        principalTable: "PaymentMethods",
                        principalColumn: "MethodID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    IncomeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(nullable: false),
                    IncomeDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MethodID = table.Column<int>(nullable: false),
                    PaymentMethodMethodID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.IncomeID);
                    table.ForeignKey(
                        name: "FK_Incomes_PaymentMethods_PaymentMethodMethodID",
                        column: x => x.PaymentMethodMethodID,
                        principalTable: "PaymentMethods",
                        principalColumn: "MethodID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_PaymentMethodMethodID",
                table: "Expenses",
                column: "PaymentMethodMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_PaymentMethodMethodID",
                table: "Incomes",
                column: "PaymentMethodMethodID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "Turnovers");

            migrationBuilder.DropTable(
                name: "PaymentMethods");
        }
    }
}
