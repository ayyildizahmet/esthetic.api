using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperationType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationType");

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
    }
}
