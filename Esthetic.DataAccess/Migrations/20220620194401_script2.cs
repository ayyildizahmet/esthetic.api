using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class script2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationType_Image_ImageId1",
                table: "OperationType");

            migrationBuilder.DropIndex(
                name: "IX_OperationType_ImageId1",
                table: "OperationType");

            migrationBuilder.DropColumn(
                name: "ImageId1",
                table: "OperationType");

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "OperationType",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9942), new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9944), new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9741), new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9758), new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9762), new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9764), new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9766), new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9964), new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9965), new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 44, 1, 174, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.CreateIndex(
                name: "IX_OperationType_ImageId",
                table: "OperationType",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationType_Image_ImageId",
                table: "OperationType",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationType_Image_ImageId",
                table: "OperationType");

            migrationBuilder.DropIndex(
                name: "IX_OperationType_ImageId",
                table: "OperationType");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "OperationType",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId1",
                table: "OperationType",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(608), new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(610), new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(398), new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(411), new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(413), new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(414), new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(415), new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(417), new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(623), new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(625), new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(626), new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 20, 22, 43, 16, 695, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.CreateIndex(
                name: "IX_OperationType_ImageId1",
                table: "OperationType",
                column: "ImageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationType_Image_ImageId1",
                table: "OperationType",
                column: "ImageId1",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
