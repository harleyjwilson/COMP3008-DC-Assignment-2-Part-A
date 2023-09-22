using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocalDBWebApiUsingEF.Migrations
{
    /// <inheritdoc />
    public partial class RandomeTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "AccountNumber", "AccountHolderName", "Balance", "UserId" },
                values: new object[,]
                {
                    { 1, "User1's Account", 7961.459559686311, 1 },
                    { 2, "User2's Account", 2981.7301179986621, 2 },
                    { 3, "User3's Account", 3459.0267806906272, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Age", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "Address 1", 51, "user1@mail.com", "User1", "password1", "123-456-1", "/images/man2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Age", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "Address 2", 41, "user2@mail.com", "User2", "password2", "123-456-2", "/images/man2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Age", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "Address 3", 59, "user3@mail.com", "User3", "password3", "123-456-3", "/images/women2.jpeg" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Age", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[,]
                {
                    { 4, "Address 4", 31, "user4@mail.com", "User4", "password4", "123-456-4", "/images/man1.jpeg" },
                    { 5, "Address 5", 37, "user5@mail.com", "User5", "password5", "123-456-5", "/images/women2.jpeg" },
                    { 6, "Address 6", 25, "user6@mail.com", "User6", "password6", "123-456-6", "/images/man1.jpeg" },
                    { 7, "Address 7", 44, "user7@mail.com", "User7", "password7", "123-456-7", "/images/women2.jpeg" },
                    { 8, "Address 8", 34, "user8@mail.com", "User8", "password8", "123-456-8", "/images/women1.jpeg" },
                    { 9, "Address 9", 33, "user9@mail.com", "User9", "password9", "123-456-9", "/images/man2.jpeg" },
                    { 10, "Address 10", 59, "user10@mail.com", "User10", "password10", "123-456-10", "/images/women1.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "AccountNumber", "AccountHolderName", "Balance", "UserId" },
                values: new object[,]
                {
                    { 4, "User4's Account", 6465.3549225893494, 4 },
                    { 5, "User5's Account", 9601.417471628085, 5 },
                    { 6, "User6's Account", 2878.910772457496, 6 },
                    { 7, "User7's Account", 4494.3094863356901, 7 },
                    { 8, "User8's Account", 316.54979178725171, 8 },
                    { 9, "User9's Account", 7003.8382905224771, 9 },
                    { 10, "User10's Account", 1804.2373217178408, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "AccountNumber", "AccountHolderName", "Balance", "UserId" },
                values: new object[,]
                {
                    { 10001, "Sajib's Account", 5000.5, 1 },
                    { 10002, "Mistry's Account", 2500.75, 2 },
                    { 10003, "Mike's Account", 12000.0, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Age", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "Bently", 20, "email1@gmail.com", "Sajib", "mypassword1", "111-111-1111", "/images/man.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Age", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "Victoria Park", 30, "email2@gmail.com", "Mistry", "mypassword2", "222-222-2222", "/images/man.jpeg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Age", "Email", "Name", "Password", "Phone", "Picture" },
                values: new object[] { "Northbridge", 40, "email3@gmail.com", "Mike", "mypassword3", "333-333-3333", "/images/man.jpeg" });
        }
    }
}
