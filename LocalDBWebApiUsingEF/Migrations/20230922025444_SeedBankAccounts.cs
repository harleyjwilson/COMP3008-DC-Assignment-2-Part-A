using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocalDBWebApiUsingEF.Migrations
{
    /// <inheritdoc />
    public partial class SeedBankAccounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "AccountNumber", "AccountHolderName", "Balance", "UserId" },
                values: new object[,]
                {
                    { 10001, "Sajib's Account", 5000.5, 1 },
                    { 10002, "Mistry's Account", 2500.75, 2 },
                    { 10003, "Mike's Account", 12000.0, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 10001);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 10002);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 10003);
        }
    }
}
