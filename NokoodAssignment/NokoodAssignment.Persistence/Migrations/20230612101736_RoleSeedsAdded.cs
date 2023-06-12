using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NokoodAssignment.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RoleSeedsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ea7675a-a749-41eb-891c-e6fd98c306db", null, "AppUser", "APPUSER" },
                    { "3ae088b6-58b3-40af-bd1c-ca7394d66b62", null, "Admins", "ADMINS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ea7675a-a749-41eb-891c-e6fd98c306db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ae088b6-58b3-40af-bd1c-ca7394d66b62");
        }
    }
}
