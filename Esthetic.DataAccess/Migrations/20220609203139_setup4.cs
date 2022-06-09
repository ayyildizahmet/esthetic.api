using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2080), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2081), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1934), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1948), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1949), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1951), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1952), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1953), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2095), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2097), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2123), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.InsertData(
                table: "OperationType",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "Name", "State" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2059), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2059), "Saç Ekimi", 1 },
                    { 2, new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2061), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2061), "Kök Hücre Tedavisi", 1 },
                    { 3, new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2062), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2062), "P.R.P", 1 },
                    { 4, new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2064), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2064), "Botoks", 1 },
                    { 5, new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2065), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2065), "Lazer Epilasyon", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(139), new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(141), new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(6), new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(21), new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(22), new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(24), new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(25), new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(26), new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(154), new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(156), new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(157), new DateTime(2022, 6, 9, 23, 26, 28, 680, DateTimeKind.Local).AddTicks(158) });
        }
    }
}
