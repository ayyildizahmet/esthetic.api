using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Data",
                table: "Image",
                type: "LongBlob",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "MediumBlob");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7814), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7818), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7443), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7467), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7469), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7471), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7473), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7475), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7842), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7846), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7849), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7773), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7776), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7778), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7779), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7784), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7784) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Data",
                table: "Image",
                type: "MediumBlob",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "LongBlob");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8564), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8566), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8171), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8372), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8374), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8376), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8377), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8379), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8582), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8584), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8586), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8534), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8537), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8538), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8541), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8542) });
        }
    }
}
