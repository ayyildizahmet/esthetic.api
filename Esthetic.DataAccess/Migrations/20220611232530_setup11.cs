using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Data",
                table: "Image",
                type: "MediumBlob",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "longblob");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1388), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1391), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1122), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1142), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1145), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1146), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1148), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1150), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1409), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1411), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1413), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1288), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1290), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1292), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1293), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1363), new DateTime(2022, 6, 12, 2, 25, 29, 966, DateTimeKind.Local).AddTicks(1363) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Data",
                table: "Image",
                type: "longblob",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "MediumBlob");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5369), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5372), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5179), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5195), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5196), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5198), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5199), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5385), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5387), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5388), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5343), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5345), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5346), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5347), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5349), new DateTime(2022, 6, 12, 2, 5, 7, 71, DateTimeKind.Local).AddTicks(5349) });
        }
    }
}
