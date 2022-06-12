using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "Image");

            migrationBuilder.RenameColumn(
                name: "Width",
                table: "Image",
                newName: "Size");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Image",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Image",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6178), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6183), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5884), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5903), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5905), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5907), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5909), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5912), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6208), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6211), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6214), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6089), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6092), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6139), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6145), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6146), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6147) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Image",
                newName: "Width");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Url",
                keyValue: null,
                column: "Url",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Image",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Image",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
