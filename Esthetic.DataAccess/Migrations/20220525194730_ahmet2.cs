using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class ahmet2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "User",
                type: "varchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 25, 22, 47, 29, 660, DateTimeKind.Local).AddTicks(218), new DateTime(2022, 5, 25, 22, 47, 29, 660, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 25, 22, 47, 29, 660, DateTimeKind.Local).AddTicks(251), new DateTime(2022, 5, 25, 22, 47, 29, 660, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 25, 22, 47, 29, 660, DateTimeKind.Local).AddTicks(556), new DateTime(2022, 5, 25, 22, 47, 29, 660, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 25, 22, 47, 29, 660, DateTimeKind.Local).AddTicks(561), new DateTime(2022, 5, 25, 22, 47, 29, 660, DateTimeKind.Local).AddTicks(562) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "User");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 20, 9, 30, 9, 365, DateTimeKind.Local).AddTicks(2933), new DateTime(2022, 5, 20, 9, 30, 9, 365, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 20, 9, 30, 9, 365, DateTimeKind.Local).AddTicks(2953), new DateTime(2022, 5, 20, 9, 30, 9, 365, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 20, 9, 30, 9, 365, DateTimeKind.Local).AddTicks(3120), new DateTime(2022, 5, 20, 9, 30, 9, 365, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 20, 9, 30, 9, 365, DateTimeKind.Local).AddTicks(3123), new DateTime(2022, 5, 20, 9, 30, 9, 365, DateTimeKind.Local).AddTicks(3124) });
        }
    }
}
