using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "ImagePost",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "VideoId",
                table: "ImagePost",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7827), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7829), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7689), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7690), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7692), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7693), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7694), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7839), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7841), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7842), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7807), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7808), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7810), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7811), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7812), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.CreateIndex(
                name: "IX_ImagePost_VideoId",
                table: "ImagePost",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagePost_Video_VideoId",
                table: "ImagePost",
                column: "VideoId",
                principalTable: "Video",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagePost_Video_VideoId",
                table: "ImagePost");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropIndex(
                name: "IX_ImagePost_VideoId",
                table: "ImagePost");

            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "ImagePost");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "ImagePost",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2059), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2061), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2062), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2064), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2065), new DateTime(2022, 6, 9, 23, 31, 38, 766, DateTimeKind.Local).AddTicks(2065) });
        }
    }
}
