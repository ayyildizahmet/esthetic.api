using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostMedia_Image_ImageId1",
                table: "PostMedia");

            migrationBuilder.DropForeignKey(
                name: "FK_PostMedia_Video_VideoId1",
                table: "PostMedia");

            migrationBuilder.DropIndex(
                name: "IX_PostMedia_ImageId1",
                table: "PostMedia");

            migrationBuilder.DropIndex(
                name: "IX_PostMedia_VideoId1",
                table: "PostMedia");

            migrationBuilder.DropColumn(
                name: "ImageId1",
                table: "PostMedia");

            migrationBuilder.DropColumn(
                name: "VideoId1",
                table: "PostMedia");

            migrationBuilder.AlterColumn<Guid>(
                name: "VideoId",
                table: "PostMedia",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "PostMedia",
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
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8564), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8566), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8171), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8372), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8374), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8376), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8377), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8379), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8582), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8584), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8586), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8534), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8537), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8538), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8541), new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.CreateIndex(
                name: "IX_PostMedia_ImageId",
                table: "PostMedia",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_PostMedia_VideoId",
                table: "PostMedia",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_Image_ImageId",
                table: "PostMedia",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_Video_VideoId",
                table: "PostMedia",
                column: "VideoId",
                principalTable: "Video",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostMedia_Image_ImageId",
                table: "PostMedia");

            migrationBuilder.DropForeignKey(
                name: "FK_PostMedia_Video_VideoId",
                table: "PostMedia");

            migrationBuilder.DropIndex(
                name: "IX_PostMedia_ImageId",
                table: "PostMedia");

            migrationBuilder.DropIndex(
                name: "IX_PostMedia_VideoId",
                table: "PostMedia");

            migrationBuilder.AlterColumn<int>(
                name: "VideoId",
                table: "PostMedia",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "PostMedia",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId1",
                table: "PostMedia",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

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
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6178), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6183), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5884), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5903), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5905), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5907), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5909), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5912), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6208), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6211), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6214), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6089), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6092), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6139), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6145), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6146), new DateTime(2022, 6, 12, 14, 7, 23, 987, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.CreateIndex(
                name: "IX_PostMedia_ImageId1",
                table: "PostMedia",
                column: "ImageId1");

            migrationBuilder.CreateIndex(
                name: "IX_PostMedia_VideoId1",
                table: "PostMedia",
                column: "VideoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_Image_ImageId1",
                table: "PostMedia",
                column: "ImageId1",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_Video_VideoId1",
                table: "PostMedia",
                column: "VideoId1",
                principalTable: "Video",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
