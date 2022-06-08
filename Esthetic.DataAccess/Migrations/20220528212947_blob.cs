using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class blob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Image_LogoId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_LogoId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "LogoId",
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

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "CreatedDate", "Logo", "ModifiedDate", "Name", "State" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(821), null, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(843), "Akl Poliklinik", 1 },
                    { 2, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(848), null, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(849), "Medeks Hair Center", 1 },
                    { 3, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(850), null, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(851), "Asuman Hair Transplant Clinic", 1 },
                    { 4, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(851), null, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(852), "Esteworld", 1 },
                    { 5, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(853), null, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(854), "Maya Estetik", 1 },
                    { 6, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(855), null, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(856), "Life Time Esthetic", 1 }
                });

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

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "CreatedDate", "ModifiedDate", "Name", "State" },
                values: new object[] { 3, 2, new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1056), new DateTime(2022, 5, 29, 0, 29, 47, 470, DateTimeKind.Local).AddTicks(1057), "Ataşehir", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Company");

            migrationBuilder.AddColumn<int>(
                name: "LogoId",
                table: "Company",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Company_LogoId",
                table: "Company",
                column: "LogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Image_LogoId",
                table: "Company",
                column: "LogoId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
