using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_ImageType_ImageTypeId",
                table: "Image");

            migrationBuilder.DropTable(
                name: "ImageType");

            migrationBuilder.DropIndex(
                name: "IX_Image_ImageTypeId",
                table: "Image");

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageCategoryType",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageType",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6749), new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6751), new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6566), new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6586), new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6588), new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6591), new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6593), new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6766), new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6768), new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6771) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ImageCategoryType",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ImageType",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Image");

            migrationBuilder.CreateTable(
                name: "ImageType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageType", x => x.Id);
                })
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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8293), new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8312), new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8313), new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8314), new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8316), new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8317), new DateTime(2022, 5, 29, 1, 4, 7, 716, DateTimeKind.Local).AddTicks(8317) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Image_ImageTypeId",
                table: "Image",
                column: "ImageTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_ImageType_ImageTypeId",
                table: "Image",
                column: "ImageTypeId",
                principalTable: "ImageType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
