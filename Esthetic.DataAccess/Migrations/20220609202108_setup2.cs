using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MediaType",
                table: "Post");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4820), new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4822), new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4488), new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4508), new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4511), new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4513), new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4515), new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4517), new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4847), new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4850), new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4852), new DateTime(2022, 6, 9, 23, 21, 7, 746, DateTimeKind.Local).AddTicks(4853) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MediaType",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3337), new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3339), new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3211), new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3223), new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3224), new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3226), new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3228), new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3229), new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3351), new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3352), new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3354), new DateTime(2022, 6, 9, 23, 6, 7, 455, DateTimeKind.Local).AddTicks(3354) });
        }
    }
}
