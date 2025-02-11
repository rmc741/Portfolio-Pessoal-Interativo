using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class NewPropertieRoleTypeConversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Role",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1a75624c-a600-4dd2-a0c9-b80c3707fd06"), "ADMIN" },
                    { new Guid("45e9f23c-8793-4d9d-9943-3ee08a995ab8"), "USER" },
                    { new Guid("924952ef-c556-45ad-8728-760fe333d37a"), "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1a75624c-a600-4dd2-a0c9-b80c3707fd06"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("45e9f23c-8793-4d9d-9943-3ee08a995ab8"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("924952ef-c556-45ad-8728-760fe333d37a"));

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Role",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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
    }
}
