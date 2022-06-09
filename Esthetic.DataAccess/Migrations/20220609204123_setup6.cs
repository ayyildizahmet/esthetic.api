using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    public partial class setup6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagePost_Image_ImageId",
                table: "ImagePost");

            migrationBuilder.DropForeignKey(
                name: "FK_ImagePost_Post_PostId",
                table: "ImagePost");

            migrationBuilder.DropForeignKey(
                name: "FK_ImagePost_Video_VideoId",
                table: "ImagePost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImagePost",
                table: "ImagePost");

            migrationBuilder.RenameTable(
                name: "ImagePost",
                newName: "PostMedia");

            migrationBuilder.RenameIndex(
                name: "IX_ImagePost_VideoId",
                table: "PostMedia",
                newName: "IX_PostMedia_VideoId");

            migrationBuilder.RenameIndex(
                name: "IX_ImagePost_PostId",
                table: "PostMedia",
                newName: "IX_PostMedia_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_ImagePost_ImageId",
                table: "PostMedia",
                newName: "IX_PostMedia_ImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostMedia",
                table: "PostMedia",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2154), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2156), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2019), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2032), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2033), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2034), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2035), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2037), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2167), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2168), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2172), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2134), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2136), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2137), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2138), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2140), new DateTime(2022, 6, 9, 23, 41, 23, 411, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_Image_ImageId",
                table: "PostMedia",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostMedia_Post_PostId",
                table: "PostMedia",
                column: "PostId",
                principalTable: "Post",
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
                name: "FK_PostMedia_Post_PostId",
                table: "PostMedia");

            migrationBuilder.DropForeignKey(
                name: "FK_PostMedia_Video_VideoId",
                table: "PostMedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostMedia",
                table: "PostMedia");

            migrationBuilder.RenameTable(
                name: "PostMedia",
                newName: "ImagePost");

            migrationBuilder.RenameIndex(
                name: "IX_PostMedia_VideoId",
                table: "ImagePost",
                newName: "IX_ImagePost_VideoId");

            migrationBuilder.RenameIndex(
                name: "IX_PostMedia_PostId",
                table: "ImagePost",
                newName: "IX_ImagePost_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_PostMedia_ImageId",
                table: "ImagePost",
                newName: "IX_ImagePost_ImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImagePost",
                table: "ImagePost",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7827), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7829), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7689), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7690), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7692), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7693), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7694), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7839), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7841), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "District",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7842), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7807), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7808), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7810), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7811), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "OperationType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7812), new DateTime(2022, 6, 9, 23, 40, 39, 949, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.AddForeignKey(
                name: "FK_ImagePost_Image_ImageId",
                table: "ImagePost",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ImagePost_Post_PostId",
                table: "ImagePost",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ImagePost_Video_VideoId",
                table: "ImagePost",
                column: "VideoId",
                principalTable: "Video",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
