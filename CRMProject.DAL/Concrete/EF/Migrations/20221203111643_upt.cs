using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMProject.DAL.Concrete.EF.Migrations
{
    public partial class upt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "UserAccount",
                newName: "UserName");

            migrationBuilder.InsertData(
                table: "UserAccount",
                columns: new[] { "UserId", "Fullname", "ModifiedDate", "Password", "RecordDate", "UserName" },
                values: new object[] { 1, "Admin", new DateTime(2022, 12, 3, 14, 16, 43, 227, DateTimeKind.Local).AddTicks(3067), "1", new DateTime(2022, 12, 3, 14, 16, 43, 227, DateTimeKind.Local).AddTicks(3078), "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserAccount",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "UserAccount",
                newName: "Username");
        }
    }
}
