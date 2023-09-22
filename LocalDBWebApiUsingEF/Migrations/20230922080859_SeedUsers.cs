using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocalDBWebApiUsingEF.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "AccountNumber",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 39, "/images/man1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 43, "/images/women2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 47, "/images/man2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 51, "/images/women2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Age",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 33, "/images/man2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 55, "/images/women1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 20, "/images/women2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 47, "/images/women1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 22, "/images/women2.jpeg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "AccountNumber", "AccountHolderName", "Balance", "UserId" },
                values: new object[,]
                {
                    { 1, "User1's Account", 7961.459559686311, 1 },
                    { 2, "User2's Account", 2981.7301179986621, 2 },
                    { 3, "User3's Account", 3459.0267806906272, 3 },
                    { 4, "User4's Account", 6465.3549225893494, 4 },
                    { 5, "User5's Account", 9601.417471628085, 5 },
                    { 6, "User6's Account", 2878.910772457496, 6 },
                    { 7, "User7's Account", 4494.3094863356901, 7 },
                    { 8, "User8's Account", 316.54979178725171, 8 },
                    { 9, "User9's Account", 7003.8382905224771, 9 },
                    { 10, "User10's Account", 1804.2373217178408, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 51, "/images/man2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 41, "/images/man2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 59, "/images/women2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 31, "/images/man1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Age",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 25, "/images/man1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 44, "/images/women2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 34, "/images/women1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 33, "/images/man2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "Picture" },
                values: new object[] { 59, "/images/women1.jpeg" });
        }
    }
}
