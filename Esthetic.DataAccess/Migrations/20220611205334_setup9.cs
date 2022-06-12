using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostMedia_Image_ImageId",
                table: "PostMedia");

            migrationBuilder.DropIndex(
                name: "IX_PostMedia_ImageId",
                table: "PostMedia");

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId1",
                table: "PostMedia",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Image",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1530), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1532), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1339), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1353), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1355), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1357), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1358), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1359), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1545), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1547), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1548), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1475), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1477), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1478), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1508), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1510), new DateTime(2022, 6, 11, 23, 53, 34, 557, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.CreateIndex(
                name: "IX_PostMedia_ImageId1",
                table: "PostMedia",
                column: "ImageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_Image_ImageId1",
                table: "PostMedia",
                column: "ImageId1",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostMedia_Image_ImageId1",
                table: "PostMedia");

            migrationBuilder.DropIndex(
                name: "IX_PostMedia_ImageId1",
                table: "PostMedia");

            migrationBuilder.DropColumn(
                name: "ImageId1",
                table: "PostMedia");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Image",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8864), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8867), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8628), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8647), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8649), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8652), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8654), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8656), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8887), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8892), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8827), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8829), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8832), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8834), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8836), new DateTime(2022, 6, 11, 0, 15, 57, 144, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.CreateIndex(
                name: "IX_PostMedia_ImageId",
                table: "PostMedia",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_Image_ImageId",
                table: "PostMedia",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
