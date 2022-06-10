using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MediaTypeId",
                table: "PostMedia",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9751), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9753), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9389), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9473), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9477), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9479), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9481), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9483), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9772), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9775), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9716), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9719), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9721), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9723), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9725), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.CreateIndex(
                name: "IX_PostMedia_MediaTypeId",
                table: "PostMedia",
                column: "MediaTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_PostMedia_MediaTypeId",
                table: "PostMedia",
                column: "MediaTypeId",
                principalTable: "PostMedia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostMedia_PostMedia_MediaTypeId",
                table: "PostMedia");

            migrationBuilder.DropIndex(
                name: "IX_PostMedia_MediaTypeId",
                table: "PostMedia");

            migrationBuilder.DropColumn(
                name: "MediaTypeId",
                table: "PostMedia");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2154), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2156), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2019), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2032), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2033), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2034), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2035), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2037), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2167), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2168), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2172), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2134), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2136), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2137), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2138), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2140), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2141) });
        }
    }
}
