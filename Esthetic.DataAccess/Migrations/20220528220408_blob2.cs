using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class blob2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Company");

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Company",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8430), new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8432), new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LogoUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8293), "http://ayyildiz.xyz:8070/company/akl.png", new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LogoUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8312), "http://ayyildiz.xyz:8070/company/medeks.png", new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LogoUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8313), "http://ayyildiz.xyz:8070/company/asuman.png", new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LogoUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8314), "http://ayyildiz.xyz:8070/company/esteworld.png", new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LogoUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8316), "http://ayyildiz.xyz:8070/company/maya.png", new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LogoUrl", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8317), "http://ayyildiz.xyz:8070/company/esteplace.png", new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8317), "Este Place" });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8445), new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8447), new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8448), new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8448) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Company");

            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "Company",
                type: "longblob",
                maxLength: 16777215,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1037), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1039), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(821), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(848), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(850), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(851), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(853), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(855), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(856), "Life Time Esthetic" });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1053), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1055), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1056), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1057) });
        }
    }
}
