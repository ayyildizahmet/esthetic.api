using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Size",
                table: "Image",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "Image",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7814), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7818), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7443), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7467), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7469), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7471), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7473), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7475), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7842), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7846), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7849), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7773), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7776), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7778), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7779), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7784), new DateTime(2022, 6, 12, 23, 37, 15, 688, DateTimeKind.Local).AddTicks(7784) });
        }
    }
}
