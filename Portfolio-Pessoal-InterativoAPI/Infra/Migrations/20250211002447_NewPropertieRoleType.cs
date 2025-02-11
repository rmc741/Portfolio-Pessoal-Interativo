using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class NewPropertieRoleType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("4c1e031a-631a-401a-953e-e867ed8f8ce1"));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("2d45b517-b33f-4e7a-959a-3eeb188f0d3e"), 0 },
                    { new Guid("5b6ffe16-4c3b-4413-a82b-1698210b889b"), 1 },
                    { new Guid("6598d88b-de4c-4573-89ce-820d2fb37e06"), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2d45b517-b33f-4e7a-959a-3eeb188f0d3e"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5b6ffe16-4c3b-4413-a82b-1698210b889b"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6598d88b-de4c-4573-89ce-820d2fb37e06"));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Type" },
                values: new object[] { new Guid("4c1e031a-631a-401a-953e-e867ed8f8ce1"), 0 });
        }
    }
}
