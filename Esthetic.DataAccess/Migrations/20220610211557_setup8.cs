using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostMedia_PostMedia_MediaTypeId",
                table: "PostMedia");

            migrationBuilder.DropIndex(
                name: "IX_PostMedia_MediaTypeId",
                table: "PostMedia");

            migrationBuilder.DropColumn(
                name: "MediaTypeId",
                table: "PostMedia");

            migrationBuilder.AddColumn<int>(
                name: "MediaType",
                table: "PostMedia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Post",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MediaType",
                table: "PostMedia");

            migrationBuilder.AddColumn<int>(
                name: "MediaTypeId",
                table: "PostMedia",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Post",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9751), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9753), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9389), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9473), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9477), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9479), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9481), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9483), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9772), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9775), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9716), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9719), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9721), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9723), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9725), new DateTime(2022, 6, 10, 23, 3, 27, 849, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.CreateIndex(
                name: "IX_PostMedia_MediaTypeId",
                table: "PostMedia",
                column: "MediaTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_PostMedia_MediaTypeId",
                table: "PostMedia",
                column: "MediaTypeId",
                principalTable: "PostMedia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
