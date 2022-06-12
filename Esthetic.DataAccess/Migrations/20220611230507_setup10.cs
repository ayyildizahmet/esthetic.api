using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostMedia_Video_VideoId",
                table: "PostMedia");

            migrationBuilder.DropIndex(
                name: "IX_PostMedia_VideoId",
                table: "PostMedia");

            migrationBuilder.DropColumn(
                name: "ImageTypeId",
                table: "Image");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Video",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<Guid>(
                name: "VideoId1",
                table: "PostMedia",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

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

            migrationBuilder.CreateIndex(
                name: "IX_PostMedia_VideoId1",
                table: "PostMedia",
                column: "VideoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_Video_VideoId1",
                table: "PostMedia",
                column: "VideoId1",
                principalTable: "Video",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostMedia_Video_VideoId1",
                table: "PostMedia");

            migrationBuilder.DropIndex(
                name: "IX_PostMedia_VideoId1",
                table: "PostMedia");

            migrationBuilder.DropColumn(
                name: "VideoId1",
                table: "PostMedia");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Video",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "ImageTypeId",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "IX_PostMedia_VideoId",
                table: "PostMedia",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_Video_VideoId",
                table: "PostMedia",
                column: "VideoId",
                principalTable: "Video",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
