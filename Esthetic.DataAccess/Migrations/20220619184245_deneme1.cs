using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class deneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Image");

            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "Image",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9893), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9895), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9761), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9776), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9777), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9778), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9779), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9781), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9905), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9906), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9907), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9875), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9876), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9877), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9878), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9879), new DateTime(2022, 6, 19, 21, 42, 44, 892, DateTimeKind.Local).AddTicks(9880) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extension",
                table: "Image");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Image",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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
    }
}
