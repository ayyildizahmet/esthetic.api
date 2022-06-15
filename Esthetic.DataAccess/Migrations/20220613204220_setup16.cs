using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "PostMedia",
                type: "varchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 250)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5242), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5268), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5272), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5276), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5280), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5285), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5693), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5700), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5582), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5586), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5593), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5597), new DateTime(2022, 6, 13, 23, 42, 19, 501, DateTimeKind.Local).AddTicks(5598) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Content",
                table: "PostMedia",
                type: "int",
                maxLength: 250,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8875), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8382), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8414), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8419), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8422), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8426), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8430), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8917), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8921), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8925), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8717), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8722), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8726), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8729), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8825), new DateTime(2022, 6, 13, 23, 30, 6, 518, DateTimeKind.Local).AddTicks(8826) });
        }
    }
}
