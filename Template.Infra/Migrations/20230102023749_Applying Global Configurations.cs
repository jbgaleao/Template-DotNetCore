using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Data.Migrations
{
    public partial class ApplyingGlobalConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 1, 23, 37, 49, 143, DateTimeKind.Local).AddTicks(3314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0d05997-e91f-4c57-a205-565e2d95c869"),
                column: "DateCreated",
                value: new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 1, 23, 37, 49, 143, DateTimeKind.Local).AddTicks(3314));
        }
    }
}
