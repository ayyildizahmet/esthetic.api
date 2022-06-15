using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OperationStatusType",
                table: "PostMedia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1134), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1140), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(477), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(608), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(614), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(618), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(622), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(627), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1171), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1175), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1180), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1181) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1073), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1078), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1081), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1085), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1089), new DateTime(2022, 6, 15, 21, 40, 44, 504, DateTimeKind.Local).AddTicks(1090) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperationStatusType",
                table: "PostMedia");

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
    }
}
